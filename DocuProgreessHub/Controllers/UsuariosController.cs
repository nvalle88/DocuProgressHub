using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocuProgreessHub.BaseDatos.ContextoBaseDatos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NumberGenerate;
using SistemaCalidad.Extensions;
using SistemaCalidad.Models;
using SistemaPedidos.Utilidades;
using SistemaPedidos.Utils;
using SmartAdmin.Seed.Utils;
using SmartAdminSaludsa.Extensores;
using SmartAdminSaludsa.Models;
using SmartAdminSaludsa.Services;

namespace SistemasLegales.Controllers
{
    [Authorize(Policy = "Administracion")]
    public class UsuariosController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _rolManager;

        private readonly IEmailSender _emailSender;
        public IConfiguration Configuration { get; }
        public UsuariosController(IEmailSender _emailSender, IConfiguration configuration, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> rolManager)
        {
            _rolManager = rolManager;
            _userManager = userManager;

            this._emailSender = _emailSender;
            Configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var lista = new List<ApplicationUser>();
            try
            {
                lista = await _userManager.Users.ToListAsync();
            }
            catch (Exception)
            {
                TempData["Mensaje"] = $"{Mensaje.Error}|{Mensaje.ErrorListado}";
            }
            return View(lista);
        }


        public async Task<IActionResult> Gestionar(string id)
        {
            try
            {
                ViewBag.accion = string.IsNullOrEmpty(id) == true ? "Crear" : "Editar";
                ViewData["IdRol"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(await _rolManager.Roles.ToListAsync(), "Name", "Name");
                if (id != null)
                {
                    var user = await _userManager.Users.FirstOrDefaultAsync(c => c.Id == id);
                    if (user == null)
                        return this.Redireccionar($"{Mensaje.Error}|{Mensaje.RegistroNoEncontrado}");

                    var rolName = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
                    return View(new RegisterViewModel { Status = user.Status, IdRol = rolName, Id = user.Id, Address = user.Address, Email = user.Email, LastName = user.LastName, Name = user.Name, PhoneNumber = user.PhoneNumber });
                }
                return View(new RegisterViewModel { Status = true, });
            }
            catch (Exception)
            {
                return this.Redireccionar($"{Mensaje.Error}|{Mensaje.ErrorCargarDatos}");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Gestionar(RegisterViewModel user)
        {
            var id = DateTime.Now.Ticks;
            try
            {

                ViewBag.accion = string.IsNullOrEmpty(user.Id) == true ? "Crear" : "Editar";

                Log.Logger.Info($"{User.Identity.Name}-{id} - {ViewBag.accion} - Solicitud - {user.Serializar()}");

                if (ModelState.IsValid)
                {
                    var existeUsuario = false;
                    var CurrentUser = await _userManager.Users.Where(c => c.UserName.ToUpper().Trim() == user.Email.ToUpper().Trim()).FirstOrDefaultAsync();

                    if (string.IsNullOrEmpty(user.Id) == true)
                    {
                        if (CurrentUser == null)
                        {
                            var RegistredUser = new ApplicationUser
                            {
                                Name = user.Name,
                                LastName = user.LastName,
                                Address = user.Address,
                                PhoneNumber = user.PhoneNumber,
                                UserName = user.Email,
                                Email = user.Email,
                                EmailConfirmed = true,
                                Status = user.Status,
                                TwoFactorEnabled=false,
                                NormalizedEmail=user.Email.ToUpper(),
                                NormalizedUserName=user.Email.ToUpper(),
                                FechaCreacion=DateTime.Now,
                                
                            };
                            var password = "AgendaMedicaSmart" + GenerateNumber.Generate().ToString();
                            await _userManager.CreateAsync(RegistredUser, password);

                            Log.Logger.Info($"{User.Identity.Name}-{id} - Usuario creado - {RegistredUser.Serializar()}");

                            var userd = await _userManager.FindByEmailAsync(user.Email);
                            await _userManager.AddToRoleAsync(userd, user.IdRol);

                            Log.Logger.Info($"{User.Identity.Name}-{id} - Adicionar Rol - {userd.Email} - {user.IdRol}");

                            var listadoEmails = new List<string>();
                            listadoEmails.Add(user.Email);
                            var cuerpo = _emailSender.CuerpoCreateUser(Configuration.GetSection("CreateUsuarioCorreo").Value, string.Format("{0} {1}", userd.Name, userd.LastName),
                                                                      userd.Email, password, Configuration.GetSection("EmailLink").Value);
                            _emailSender.SendEmailAsync(listadoEmails, Mensaje.AsuntoCorreo, cuerpo);

                            Log.Logger.Info($"{User.Identity.Name}-{id} - Envio Email - {cuerpo.Serializar()}");

                            return this.Redireccionar($"{Mensaje.MensajeSatisfactorio}|{Mensaje.Satisfactorio}");
                        }
                        else
                        {
                            existeUsuario = true;
                        }
                    }
                    else
                    {
                        if (CurrentUser.Id == user.Id)
                        {
                            //var CurrentUser = await _userManager.FindByIdAsync(user.Id);
                            CurrentUser.LastName = user.LastName;
                            CurrentUser.Name = user.Name;
                            CurrentUser.Address = user.Address;
                            CurrentUser.PhoneNumber = user.PhoneNumber;
                            CurrentUser.UserName = user.Email;
                            CurrentUser.Email = user.Email;
                            CurrentUser.Status = user.Status;

                            if (!await _userManager.IsInRoleAsync(CurrentUser, user.IdRol))
                            {
                                Log.Logger.Info($"{User.Identity.Name}-{id} - Actualizar Rol");

                                var RolsUser = _userManager.GetRolesAsync(CurrentUser).Result.FirstOrDefault();

                                await _userManager.RemoveFromRoleAsync(CurrentUser, RolsUser);
                                Log.Logger.Info($"{User.Identity.Name}-{id} - {user.Email} - RemoveFromRoleAsync - {CurrentUser.Email} - {RolsUser}");
                                await _userManager.AddToRoleAsync(CurrentUser, user.IdRol);

                                Log.Logger.Info($"{User.Identity.Name}-{id} - {user.Email} - AddToRoleAsync - {CurrentUser.Email} - {user.IdRol}");
                            }
                            await _userManager.UpdateAsync(CurrentUser);
                            Log.Logger.Info($"{User.Identity.Name}-{id} - UpdateAsync - {CurrentUser.Serializar()}");

                            return this.Redireccionar($"{Mensaje.MensajeSatisfactorio}|{Mensaje.Satisfactorio}");
                        }
                        else
                        {
                            existeUsuario = true;
                        }
                    };

                    if (existeUsuario)
                    {
                        Log.Logger.Info($"{User.Identity.Name}-{id} - existeUsuario - {CurrentUser.Email} ");
                        this.TempData["Mensaje"] = $"{Mensaje.Aviso}|{Mensaje.ExisteUsuario}";
                        ViewData["IdRol"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(await _rolManager.Roles.ToListAsync(), "Name", "Name", user.IdRol);
                        return View(user);
                    }
                }

                Log.Logger.Info($"{User.Identity.Name}-{id} - ModelState.IsValid = False");
                this.TempData["Mensaje"] = $"{Mensaje.Error}|{Mensaje.CorregirFormulario}";
                ViewData["IdRol"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(await _rolManager.Roles.ToListAsync(), "Name", "Name", user.IdRol);
                return View(user);

            }
            catch (Exception ex)
            {
                Log.Logger.Info($"{User.Identity.Name}-{id} - Exception - {ex.Serializar()}");
                return this.Redireccionar($"{Mensaje.Error}|{Mensaje.Excepcion}");
            }
        }


        [HttpGet]
        public async Task<JsonResult> EliminarUsuario(string id)
        {
            try
            {
                Log.Logger.Info($"{User.Identity.Name}-{id} -Solicitud Eliminar Usuario");
                var usuario = await _userManager.FindByIdAsync(id);
                if (usuario == null)
                {

                    Log.Logger.Info($"{User.Identity.Name}-{id} - Usuario no encontrado");
                    return Json(new
                    {
                        Estado = Constantes.EstadoError,
                        Mensaje = Mensaje.RegistroNoEncontrado
                    });
                }

                var usuarioEliminado = await _userManager.DeleteAsync(usuario);

                if (usuarioEliminado.Succeeded)
                {

                    Log.Logger.Info($"{User.Identity.Name}-{id} - Usuario eliminado - {usuarioEliminado.Serializar()}");
                    this.TempData["Mensaje"] = $"{Mensaje.MensajeSatisfactorio}|  {Mensaje.Satisfactorio}";
                    return Json(new
                    {
                        Estado = Constantes.EstadoOK,
                        Mensaje = Mensaje.Satisfactorio
                    });
                }

                Log.Logger.Info($"{User.Identity.Name}-{id} - Usuario no fue eliminado");
                return Json(new
                {
                    Estado = Constantes.EstadoError,
                    Mensaje = Mensaje.BorradoNoSatisfactorio
                });
            }
            catch (Exception ex)
            {
                Log.Logger.Info($"{User.Identity.Name}-{id} - Exception - {ex.Serializar()}");
                return Json(new
                {
                    Estado = Constantes.EstadoError,
                    Mensaje = ex.Message
                });
            }
        }


    }
}
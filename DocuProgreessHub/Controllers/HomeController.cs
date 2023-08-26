#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DocuProgreessHub.BaseDatos.ContextoBaseDatos;
using DocuProgreessHub.Models.ViewModels;
using DocuProgreessHub.Models.ViewModels.SistemaCalidad.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaPedidos.Utilidades;
using SistemaPedidos.Utils;
using SmartAdmin.Seed.Utils;
using SmartAdminSaludsa.Models;
using SmartAdminSaludsa.Models.Utiles;

#endregion

namespace SmartAdminSaludsa.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly DContext _db;
        public IConfiguration Configuration { get; }

        public HomeController(IConfiguration configuration, UserManager<ApplicationUser> userManager, DContext db)
        {
            _db = db;
            _userManager = userManager;
            Configuration = configuration;
        }

        #region Pedidos Actuales

        //[Authorize(Policy = "Administrador")]
        [Authorize]
        public IActionResult Index()
        {
            if (User.IsInRole(Perfiles.Cliente))
                return RedirectToAction("IndexCliente");
            else
                if (User.IsInRole(Perfiles.Administrador))
                return RedirectToAction("IndexAdmin");
            else
                    if (User.IsInRole(Perfiles.Gestor))
                return RedirectToAction("IndexAdmin");

            return RedirectToAction("Error");

        }
        [Authorize(Policy = "Administracion")]
        public async Task<IActionResult> IndexAdmin()
        {
            var lista = await _db.AspNetUserRoles.GroupBy(x => x.Role.Name).Select(y => new { Cantidad = y.Count(), Rol = y.Key }).ToListAsync();
            
            return View(new IndexAdminViewModel
            {
                Administradores = new Administradores
                {
                    Cantidad = lista.Any(x => x.Rol.Equals(Perfiles.Administrador)) ? lista.FirstOrDefault(x => x.Rol.Equals(Perfiles.Administrador)).Cantidad : 0,
                },
                Clientes = new Clientes
                {
                    Cantidad = lista.Any(x => x.Rol.Equals(Perfiles.Cliente)) ? lista.FirstOrDefault(x => x.Rol.Equals(Perfiles.Cliente)).Cantidad : 0,
                },
                Gestores = new Gestores
                {
                    Cantidad = lista.Any(x => x.Rol.Equals(Perfiles.Gestor)) ? lista.FirstOrDefault(x => x.Rol.Equals(Perfiles.Gestor)).Cantidad : 0,
                },
            });
        }

        [Authorize(Policy = "Cliente")]
        public IActionResult IndexCliente()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> ObtenerClientesPorFecha()
        {
            var listaUsuarioPorFecha = await _db.AspNetUsers
                .Where(x=>x.AspNetUserRoles.FirstOrDefault().Role.Name==Perfiles.Cliente)
                .GroupBy(x => x.FechaCreacion.Date).OrderBy(x => x.Key)
                .Select(y => new UserFecha { Cantidad = y.Count(), Fecha = y.Key }).ToListAsync();

            return Json(new
            {
                clientes = listaUsuarioPorFecha,
            });
        }

        #endregion
    }
}

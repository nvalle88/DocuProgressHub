using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NumberGenerate;
using SistemaCalidad.Models;
using SistemaPedidos.Utilidades;
using SistemaPedidos.Utils;
using SmartAdmin.Seed.Extensions;
using SmartAdminSaludsa.Extensores;
using SmartAdminSaludsa.Models;
using SmartAdminSaludsa.Models.Utiles;
using SmartAdminSaludsa.Services;

namespace SmartAdminSaludsa.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    [Layout("_AuthLayout")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public IConfiguration Configuration { get; }
        private readonly ILogger _logger;
        private readonly IEmailSender _emailSender;


        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            IEmailSender emailSender,
            ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            Configuration = configuration;
            _emailSender = emailSender;
            _logger = logger;

            Log.Logger.Info($"AccountController -  Constructor");
        }

        [TempData]
        public string ErrorMessage { get; set; }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            var id = DateTime.Now.Ticks;

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl;
            Log.Logger.Info($"{id} - AccountController -  Login - Init");
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var id = DateTime.Now.Ticks;
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.Users.Where(c => c.UserName.ToUpper().Trim() == model.Email.ToUpper().Trim()).FirstOrDefaultAsync();
                    if (user == null)
                    {
                        Log.Logger.Info($"{id} - {model.Email} - Intento de inicio de sesión no válido");
                        ModelState.AddModelError(string.Empty, "Intento de inicio de sesión no válido.");
                        return View(model);
                    }


                    var usuario = await _userManager.FindByEmailAsync(model.Email);

                    var existe = await _signInManager.CheckPasswordSignInAsync(usuario, model.Password, lockoutOnFailure: false);

                    if (existe.Succeeded)
                    {

                        var IsConfirmed = await _userManager.Users.Where(x => x.EmailConfirmed == false && x.Email == model.Email).FirstOrDefaultAsync();
                        if (IsConfirmed != null)
                        {
                            Log.Logger.Info($"{id} - {model.Email} - IsConfirmed = False - ConfirmAccount");
                            return RedirectToAction(nameof(AccountController.ConfirmAccount), "Account", new { email = usuario.Email });
                        }

                    }

                    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

                    if (result.Succeeded)
                    {
                        Log.Logger.Info($"{id} - {model.Email} - Succeeded");
                        this.TempData["Mensaje"] = $"{Mensaje.MensajeSatisfactorio}| Bienvenido {User.Identity.Name}";
                        return RedirectToAction("Index", "Home");
                    }

                    Log.Logger.Info($"{id} - {model.Email} - PasswordSignInAsync - Succeeded = false - Invalid login attempt.");
                    ModelState.AddModelError(string.Empty, "usuario o contraseña incorrecto");
                    return View(model);
                }

                Log.Logger.Info($"{id} - {model.Email} - ModelState.IsValid = True");
                ModelState.AddModelError(string.Empty, "Modelo inválido, contacte con el administrador del sistema");
                return View(model);
            }
            catch (Exception ex)
            {
                Log.Logger.Info($"{id} - {model.Email} - Exception {ex.Serializar()}");
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(model);
            }
        }

        public IActionResult ConfirmAccount(string email, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View(new ConfirmAccount { Email = email });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmAccount(ConfirmAccount confirmAccount)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(confirmAccount.Email);
                if (user != null)
                {
                    var changePassword = await _userManager.ChangePasswordAsync(user, confirmAccount.CurrentPassword, confirmAccount.Password);

                    if (changePassword.Succeeded)
                    {
                        var CurrentUser = await _userManager.FindByEmailAsync(confirmAccount.Email);
                        CurrentUser.EmailConfirmed = true;
                        await _userManager.UpdateAsync(CurrentUser);
                        var result = await _signInManager.PasswordSignInAsync(confirmAccount.Email, confirmAccount.Password, true, lockoutOnFailure: false);
                        if (result.Succeeded)
                        {
                            _logger.LogInformation("User logged in.");
                            this.TempData["Mensaje"] = $"{Mensaje.MensajeSatisfactorio}|{"Bienvenido"}";
                            return RedirectToAction(nameof(HomeController.Index), "Home");
                        }
                    }
                    ModelState.AddModelError(string.Empty, "Intento de inicio de sesión no válido.");
                    return View(confirmAccount);

                }
                ModelState.AddModelError(string.Empty, "Intento de inicio de sesión no válido.");
                return View(confirmAccount);

            }
            ModelState.AddModelError(string.Empty, "Intento de inicio de sesión no válido.");
            return View(confirmAccount);
        }



        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterOnlineViewModel register)
        {
            if (!ModelState.IsValid)
            {
                this.TempData["Mensaje"] = $"{Mensaje.Error}| Debe introducir los datos solicitados";
                return View(new RegisterOnlineViewModel {Email= register.Email });
            }
           
            var usuario = await _userManager.FindByEmailAsync(register.Email);
            if (usuario != null)
            {
                this.TempData["Mensaje"] = $"{Mensaje.Error}| El correo electrónico {register.Email} ya existe, intente con otro.";
                return View(register);
            }

            var user = new ApplicationUser
            {
                Address = "N/A",
                Email = register.Email,
                EmailConfirmed = true,
                LastName = register.LastName,
                Name = register.Name,
                NormalizedEmail = register.Email.ToUpper(),
                Status = true,
                NormalizedUserName = register.Email.ToUpper(),
                PhoneNumber = register.PhoneNumber,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                UserName = register.Email,
                FechaCreacion=DateTime.Now,
            };
            
            await _userManager.CreateAsync(user, register.Password);

            await _userManager.AddToRoleAsync(user, Perfiles.Cliente);

            return RedirectToAction("Index", "Home");
        }



        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction(nameof(AccountController.Login), "Account");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            // Something failed, redisplay form
            if (!ModelState.IsValid)
                return View(model);

            // Check if the user exists in the data store
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                var password = "AgendaMedicaSmart" + GenerateNumber.Generate().ToString();
                await _userManager.RemovePasswordAsync(user);
                await _userManager.AddPasswordAsync(user, password);
                user.EmailConfirmed = false;
                await _userManager.UpdateAsync(user);

                var listadoEmails = new List<string>();
                listadoEmails.Add(user.Email);
                var cuerpo = _emailSender.CuerpoCreateUser(Configuration.GetSection("ResetearContrasenaCorreo").Value, string.Format("{0} {1}", user.Name, user.LastName),
                                                          user.Email, password, Configuration.GetSection("EmailLink").Value);
                _emailSender.SendEmailAsync(listadoEmails, Mensaje.AsuntoCorreo, cuerpo);

                return RedirectToAction(nameof(ForgotPasswordConfirmation));

            }
            ModelState.AddModelError(string.Empty, "El correo electrónico ingresado no existe.");
            return View(model);

        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code = null)
        {
            if (code == null)
            {
                throw new ApplicationException("A code must be supplied for password reset.");
            }
            var model = new ResetPasswordViewModel { Code = code };
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }
            AddErrors(result);
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}

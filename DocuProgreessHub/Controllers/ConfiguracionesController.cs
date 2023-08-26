//#region Using

//using System;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using SistemaPedidos.Utilidades;
//using SistemaPedidos.Utils;
//using SmartAdmin.Seed.BaseDatos.ContextoBaseDatos;

//#endregion

//namespace SmartAdminSaludsa.Controllers
//{
//    [Authorize]
//    public class ConfiguracionesController : Controller
//    {
//        public IConfiguration Configuration { get; }

//        private readonly SaludsaContext db;

//        public ConfiguracionesController(IConfiguration configuration, SaludsaContext context)
//        {
//            Configuration = configuration;
//            this.db = context;
//        }

//        public async Task<IActionResult> ListaCatalogos()
//        {
//            var listaSalidsa = await db.AdmItemCatalogo.Include(x=>x.Cat).ToListAsync();
//            return View(listaSalidsa);
//        }

//        public async Task<IActionResult> ListaParametros()
//        {
//            var listaSalidsa = await db.ParametroServicioWeb.ToListAsync();
//            return View(listaSalidsa);
//        }

//        #region Pedidos Actuales

//        [Authorize(Policy = "Administracion")]
//        public IActionResult General()
//        {
//            return View();
//        }

//        #endregion
//    }
//}

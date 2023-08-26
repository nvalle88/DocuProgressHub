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
//    public class CreditoFarmaciaController : Controller
//    {
//        public IConfiguration Configuration { get; }

//        private readonly SaludsaContext db;

//        public CreditoFarmaciaController(IConfiguration configuration, SaludsaContext context)
//        {
//            Configuration = configuration;
//            this.db = context;
//        }

//        public async Task<IActionResult> ListaProductos()
//        {
//            var listaSalidsa = await db.Cfproducto.ToListAsync();
//            return View(listaSalidsa);
//        }
        
//        public async Task<IActionResult> ListaProductoPlan()
//        {
//            var listaSalidsa = await db.ComoUsarPlanProducto.ToListAsync();
//            return View(listaSalidsa);
//        }

//        public async Task<IActionResult> ListaGuiaUso()
//        {
//            var listaSalidsa = await db.ComoUsarPlanGuiaUso.Include(x=>x.ComoUsarPlanCanalOrigen).Include(x=>x.ComoUsarPlanProducto).ToListAsync();
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

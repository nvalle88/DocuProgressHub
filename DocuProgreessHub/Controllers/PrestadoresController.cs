//#region Using

//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using SistemaPedidos.Utilidades;
//using SmartAdmin.Seed.BaseDatos.ContextoBaseDatos;
//using SmartAdmin.Seed.Models.DTO;
//using SmartAdminSaludsa.DBcontextPrestadores;
//using SmartAdminSaludsa.Extensores;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//#endregion

//namespace SmartAdminSaludsa.Controllers
//{
//    [Authorize]
//    public class PrestadoresController : Controller
//    {
//        public IConfiguration Configuration { get; }
//        private readonly PrestadoresContext db;

//        public PrestadoresController(IConfiguration configuration, PrestadoresContext context)
//        {
//            Configuration = configuration;
//            this.db = context;
//        }

//        #region Pedidos Actuales

//        [Authorize(Policy = "Administracion")]
//        public IActionResult ConvenioPlan()
//        {
//            return View();
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="numeroConvenio"></param>
//        /// <param name="codigoProducto"></param>
//        /// <param name="codigoPlan"></param>
//        /// <param name="versionPlan"></param>
//        /// <param name="numeroPagina"></param>
//        /// <param name="cantidadRegistros"></param>
//        /// <returns></returns>
//        [Authorize(Policy = "Administracion")]
//        public async Task<JsonResult> ObtenerConvenioPlan(int? numeroConvenio, 
//            string codigoProducto, 
//            string codigoPlan, 
//            int? versionPlan, int numeroPagina=1, int cantidadRegistros=50)
//        {

        
//            try
//            {


//                var query = db.ConvenioPlan
//                    .OrderBy(x=>x.CodigoProducto)
//                    .ThenBy(x=>x.CodigoPlan)
//                    .ThenBy(x=>x.VersionPlan).AsQueryable();

//                if (numeroConvenio.HasValue)
//                    query = query.Where(x => x.NumeroConvenio== numeroConvenio.Value);

//                if (!string.IsNullOrWhiteSpace(codigoProducto))
//                    query = query.Where(x => x.CodigoProducto.Equals(codigoProducto.Trim(), StringComparison.InvariantCultureIgnoreCase));

//                if (!string.IsNullOrWhiteSpace(codigoPlan))
//                    query = query.Where(x => x.CodigoPlan.Equals(codigoPlan.Trim(), StringComparison.InvariantCultureIgnoreCase));

//                if (versionPlan.HasValue)
//                    query = query.Where(x => x.VersionPlan==versionPlan.Value);


//                var TotalRegistros = query.Count();

//                var resultado = await query.Skip(cantidadRegistros * (numeroPagina - 1)).Take(cantidadRegistros).ToListAsync();

              

//                return new JsonResult(new RespuestaGenericaPaginada
//                {
//                    Estado = Respuesta.OK,
//                    Resultado = resultado   == null ? new List<ConvenioPlan>() : resultado,
//                    TotalRegistros = resultado == null ? 0 : TotalRegistros,
//                    Mensaje = TotalRegistros == 0 ? "No existen " : string.Empty ,

//                });

//            }
//            catch (Exception ex)
//            {
//                Log.WriteLog(TypeError.Error, $"Detalle error:{ex.Serializar()}");

//                return new JsonResult(new RespuestaGenericaPaginada
//                {
//                    Estado = Respuesta.Error,
//                    TotalRegistros=0,
//                    Mensaje = ex.Message,
//                    Resultado = null,
//                });
//            }

//        }


//        public async Task<JsonResult> obtenerBeneficiosPlan(int idConvenioPlan)
//        {
//            try
//            {


//                var query = db.BeneficioConvenio
//                    .Where(x=>x.IdConvenioPlan== idConvenioPlan)
//                    .OrderBy(x => x.CodigoBeneficio).AsQueryable();

              
//                var resultado = await query.ToListAsync();

//                return new JsonResult(new RespuestaGenericaPaginada
//                {
//                    Estado = Respuesta.OK,
//                    Resultado = resultado == null ? new List<BeneficioConvenio>() : resultado,
//                    TotalRegistros = resultado.Count
//                });

//            }
//            catch (Exception ex)
//            {
//                Log.WriteLog(TypeError.Error, $"Detalle error:{ex.Serializar()}");

//                return new JsonResult(new RespuestaGenericaPaginada
//                {
//                    Estado = Respuesta.Error,
//                    TotalRegistros = 0,
//                    Mensaje = ex.Message,
//                    Resultado = null,
//                });
//            }

//        }
//        #endregion
//    }
//}

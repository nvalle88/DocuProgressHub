//#region Using

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using SmartAdmin.Seed.BaseDatos.ContextoBaseDatos;
//using SmartAdmin.Seed.BaseDatos.ModelosBaseDatos.bdd_MessageBroker;
//using SmartAdmin.Seed.Models.DTO;

//#endregion

//namespace SmartAdminSaludsa.Controllers
//{
//    [Authorize]
//    public class MessageBrokersController : Controller
//    {
//        public IConfiguration Configuration { get; }

//        private readonly bdd_MessageBrokerContext db;

//        public MessageBrokersController(IConfiguration configuration, bdd_MessageBrokerContext context)
//        {
//            Configuration = configuration;
//            this.db = context;
//        }

//        public async Task<IActionResult> ListaSobres()
//        {
//            return View();
//        }

//        public async Task<IActionResult> ObtenerSobres(DateTime fechaInicio,
//            DateTime fechaFin,
//            string numeroSobre,
//            int numeroTicketZendesk, int numeroPagina = 1, int cantidadRegistros = 50)
//        {

//            try
//            {
//                if (fechaFin < fechaInicio)
//                {
//                    return new JsonResult(new RespuestaGenericaPaginada
//                    {
//                        Estado = Respuesta.Error,
//                        TotalRegistros = 0,
//                        Mensaje = "La fecha de inicio debe ser mayor que la fecha fin.",
//                        Resultado = null,
//                    });
//                }

//                var query = db.Sobre
//                        .OrderBy(x => x.FechaCreacion).AsQueryable();

//                query = query.Where(x => x.FechaCreacion >= fechaInicio && x.FechaCreacion <= fechaFin);

//                if (numeroSobre == null)
//                    query = query.Where(x => x.NumeroSobre.Equals(numeroSobre, StringComparison.InvariantCultureIgnoreCase));


//                if (numeroTicketZendesk > 0)
//                    query = query.Where(x => x.NumeroTicketZendesk.Equals(numeroTicketZendesk));


//                var TotalRegistros = await query.CountAsync();

//                var resultado = await query.Skip(cantidadRegistros * (numeroPagina - 1)).Take(cantidadRegistros).ToListAsync();


//                return new JsonResult(new RespuestaGenericaPaginada
//                {
//                    Estado = Respuesta.OK,
//                    Resultado = resultado ==null ? new List<Sobre>() : resultado,
//                    TotalRegistros = resultado==null ? 0 : TotalRegistros,
//                    Mensaje = TotalRegistros == 0 ? "No existen " : string.Empty,

//                });
//            }
//            catch (Exception ex)
//            {

//                return new JsonResult(new RespuestaGenericaPaginada
//                {
//                    Estado = Respuesta.Error,
//                    Resultado =  new List<Sobre>(),
//                    TotalRegistros =0,
//                    Mensaje = ex.Message,

//                });
//            }
//        }

//        public async Task<IActionResult> ListaParametros()
//        {
//            var listaSalidsa = await db.Sobre.ToListAsync();
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

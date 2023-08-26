using System;
using System.Collections.Generic;

namespace SmartAdmin.Seed.BaseDatos.ModelosBaseDatos.bdd_MessageBroker
{
    public partial class Sobre
    {
        public Sobre()
        {
            EncuestaSobre = new HashSet<EncuestaSobre>();
            HistorialEstadoSobre = new HashSet<HistorialEstadoSobre>();
            ReconocimientoSobre = new HashSet<ReconocimientoSobre>();
        }

        public int Id { get; set; }
        public string NumeroSobre { get; set; }
        public int? IdSobreArmonix { get; set; }
        public int? NumeroTicketZendesk { get; set; }
        public int? CodigoContrato { get; set; }
        public decimal ValorPresentado { get; set; }
        public string Telefono { get; set; }
        public int NumeroPersonaBeneficiario { get; set; }
        public bool? AceptoTerminos { get; set; }
        public string ComentarioCliente { get; set; }
        public string DiagnosticoCliente { get; set; }
        public string DiagnosticoFinalLiquidacion { get; set; }
        public string CategoriaReembolso { get; set; }
        public bool? EsGuiado { get; set; }
        public bool? GastoOncologico { get; set; }
        public bool? MedicinaContinua { get; set; }
        public int? CodigoAplicacion { get; set; }
        public int? CodigoPlataforma { get; set; }
        public string UsuarioCreacion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Observacion { get; set; }
        public int? CantidadFacturaElectronicaPdf { get; set; }
        public Guid NombreCarpeta { get; set; }
        public string ListaFichero { get; set; }
        public string ListaFicheroOptimizado { get; set; }
        public string InformacionCliente { get; set; }
        public string Estado { get; set; }
        public bool Eliminar { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool? GastoCovid { get; set; }
        public bool? Maternidad { get; set; }
        public bool? AplicaShift { get; set; }
        public string RespuestaLiquidacionAutomatica { get; set; }

        public ICollection<EncuestaSobre> EncuestaSobre { get; set; }
        public ICollection<HistorialEstadoSobre> HistorialEstadoSobre { get; set; }
        public ICollection<ReconocimientoSobre> ReconocimientoSobre { get; set; }
    }
}

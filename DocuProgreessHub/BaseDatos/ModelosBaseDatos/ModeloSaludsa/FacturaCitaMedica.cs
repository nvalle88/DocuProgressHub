using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class FacturaCitaMedica
    {
        public int Id { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string FormaPago { get; set; }
        public string CodigoCompania { get; set; }
        public string Descripcion { get; set; }
        public decimal? Importe { get; set; }
        public long? IdentificadorFactura { get; set; }
        public long? IdentificadorDetalleFactura { get; set; }
        public string RespuestaRegistraFactura { get; set; }
        public string CodigoFormaPago { get; set; }
        public string Caja { get; set; }
        public string TipoTarjeta { get; set; }
        public string ReferenciaPago { get; set; }
        public string MarcaTarjeta { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaCrearClienteFactura { get; set; }
        public DateTime? FechaCabeceraFactura { get; set; }
        public DateTime? FechaDetalleFactura { get; set; }
        public DateTime? FechaDetallePago { get; set; }
        public DateTime? FechaRegistroFactura { get; set; }
        public DateTime? FechaEliminarFactura { get; set; }
        public string IdentificacionCliente { get; set; }
        public string TipoIdentificacionCliente { get; set; }
        public string NombresCliente { get; set; }
        public string ApellidosCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string TipoOrganizacion { get; set; }
        public string EmailCliente { get; set; }
        public long IdCitaSalud { get; set; }
        public int IdPagoCitaMedica { get; set; }
        public bool? RegistroError { get; set; }
        public string DetalleError { get; set; }
        public bool? Eliminada { get; set; }
    }
}

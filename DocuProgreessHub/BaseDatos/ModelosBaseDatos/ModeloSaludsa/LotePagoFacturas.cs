using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class LotePagoFacturas
    {
        public int ImagenFacturaId { get; set; }
        public int LotePagoId { get; set; }
        public string UrlArchivoXml { get; set; }
        public string NombreArchivoXml { get; set; }
        public string NombreOriginalArchivoXml { get; set; }
        public string UrlArchivoRide { get; set; }
        public string NombreArchivoRide { get; set; }
        public string NombreOriginalArchivoRide { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string TicketZendesk { get; set; }
        public string ClaveAccesoFactura { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; }
        public DateTime? FechaEnvioFactura { get; set; }

        public LotePago LotePago { get; set; }
    }
}

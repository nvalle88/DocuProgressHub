using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CfconciliacionCredito
    {
        public CfconciliacionCredito()
        {
            CfconciliacionDetalle = new HashSet<CfconciliacionDetalle>();
        }

        public int Id { get; set; }
        public int IdConciliacion { get; set; }
        public int? IdCredito { get; set; }
        public int? TotalItemsRegistrado { get; set; }
        public int? TotalItemsEnviado { get; set; }
        public decimal? ValorTotalRegistrado { get; set; }
        public decimal? ValorTotalEnviado { get; set; }
        public string Estado { get; set; }
        public string NumeroFactura { get; set; }
        public string AutorizacionSri { get; set; }
        public string ClaveAcceso { get; set; }
        public DateTime? FechaFactura { get; set; }

        public Cfconciliacion IdConciliacionNavigation { get; set; }
        public ICollection<CfconciliacionDetalle> CfconciliacionDetalle { get; set; }
    }
}

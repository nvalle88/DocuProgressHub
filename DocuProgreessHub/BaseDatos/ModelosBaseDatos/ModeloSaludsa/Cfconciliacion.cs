using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cfconciliacion
    {
        public Cfconciliacion()
        {
            CfconciliacionCredito = new HashSet<CfconciliacionCredito>();
        }

        public int IdConciliacion { get; set; }
        public int NumeroConvenio { get; set; }
        public int CodigoCuadre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }
        public string CorreosNotificacion { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? TotalItems { get; set; }
        public decimal? ValorTotal { get; set; }
        public string NombreArchivo { get; set; }
        public string Url { get; set; }

        public ICollection<CfconciliacionCredito> CfconciliacionCredito { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CfobservacionSolicitud
    {
        public int Id { get; set; }
        public int IdConvenio { get; set; }
        public int IdCredito { get; set; }
        public string Peticion { get; set; }
        public string Respuesta { get; set; }
        public string EstadoSolicitud { get; set; }
        public string Observacion { get; set; }
        public string EstadoConciliacion { get; set; }
        public DateTime? FechaObservacion { get; set; }
    }
}

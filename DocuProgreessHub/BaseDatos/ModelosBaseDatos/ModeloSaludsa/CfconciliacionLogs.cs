using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CfconciliacionLogs
    {
        public int Id { get; set; }
        public int? IdConciliacion { get; set; }
        public int? IdCredito { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public DateTime? FechaRespuesta { get; set; }
        public string DatosEnvio { get; set; }
        public string DatosRespuesta { get; set; }
        public string Proceso { get; set; }
        public string SubProceso { get; set; }
    }
}

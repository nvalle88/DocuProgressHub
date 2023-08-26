using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class InclusionExclusionDiaria
    {
        public long Id { get; set; }
        public int NumeroConvenio { get; set; }
        public int CodigoMovimiento { get; set; }
        public int NumeroPersona { get; set; }
        public string InclusionExclusion { get; set; }
        public int Reintento { get; set; }
        public DateTime Fecha { get; set; }
        public bool Procesado { get; set; }
        public string MensajeError { get; set; }
        public DateTime? FechaProcesada { get; set; }
        public DateTime? FechaEnvioPrestador { get; set; }
    }
}

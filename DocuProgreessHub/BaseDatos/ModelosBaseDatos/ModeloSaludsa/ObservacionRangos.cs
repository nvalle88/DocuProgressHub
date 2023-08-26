using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ObservacionRangos
    {
        public int IdObservacion { get; set; }
        public string Descripcion { get; set; }
        public int? CodigoRangos { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Usuario { get; set; }
        public bool Estado { get; set; }

        public Rangos CodigoRangosNavigation { get; set; }
    }
}

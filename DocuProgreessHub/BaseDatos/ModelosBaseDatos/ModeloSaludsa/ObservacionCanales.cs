using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ObservacionCanales
    {
        public int IdObservacion { get; set; }
        public string Descripcion { get; set; }
        public int? CodigoCanales { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Usuario { get; set; }
        public bool Estado { get; set; }

        public Canales CodigoCanalesNavigation { get; set; }
    }
}

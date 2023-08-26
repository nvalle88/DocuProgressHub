using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Subtipos
    {
        public Subtipos()
        {
            ObservacionSubtipo = new HashSet<ObservacionSubtipo>();
            Rangos = new HashSet<Rangos>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool? Estado { get; set; }

        public ICollection<ObservacionSubtipo> ObservacionSubtipo { get; set; }
        public ICollection<Rangos> Rangos { get; set; }
    }
}

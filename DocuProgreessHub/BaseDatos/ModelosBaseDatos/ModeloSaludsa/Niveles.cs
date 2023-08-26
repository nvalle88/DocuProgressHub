using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Niveles
    {
        public Niveles()
        {
            InverseCodigoNivelesNavigation = new HashSet<Niveles>();
            ObservacionNiveles = new HashSet<ObservacionNiveles>();
            Tipo = new HashSet<Tipo>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public int? CodigoNiveles { get; set; }

        public Niveles CodigoNivelesNavigation { get; set; }
        public ICollection<Niveles> InverseCodigoNivelesNavigation { get; set; }
        public ICollection<ObservacionNiveles> ObservacionNiveles { get; set; }
        public ICollection<Tipo> Tipo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Tipo
    {
        public Tipo()
        {
            ObservacionTipo = new HashSet<ObservacionTipo>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool EstadoTipo { get; set; }
        public int? CodigoNivel { get; set; }

        public Niveles CodigoNivelNavigation { get; set; }
        public ICollection<ObservacionTipo> ObservacionTipo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Canales
    {
        public Canales()
        {
            ObservacionCanales = new HashSet<ObservacionCanales>();
            Rangos = new HashSet<Rangos>();
            Salas = new HashSet<Salas>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public ICollection<ObservacionCanales> ObservacionCanales { get; set; }
        public ICollection<Rangos> Rangos { get; set; }
        public ICollection<Salas> Salas { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Tematica
    {
        public Tematica()
        {
            Equivalencia = new HashSet<Equivalencia>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public ICollection<Equivalencia> Equivalencia { get; set; }
    }
}

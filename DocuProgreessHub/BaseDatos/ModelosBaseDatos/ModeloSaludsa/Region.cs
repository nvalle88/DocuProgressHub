using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Region
    {
        public Region()
        {
            Ciudad = new HashSet<Ciudad>();
        }

        public short Id { get; set; }
        public string Nombre { get; set; }
        public short PaisId { get; set; }
        public bool EstadoActivo { get; set; }

        public Pais Pais { get; set; }
        public ICollection<Ciudad> Ciudad { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Productos
    {
        public Productos()
        {
            Planes = new HashSet<Planes>();
        }

        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public ICollection<Planes> Planes { get; set; }
    }
}

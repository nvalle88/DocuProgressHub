using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Productos1
    {
        public Productos1()
        {
            GrupoProductoPlan1 = new HashSet<GrupoProductoPlan1>();
            Planes1 = new HashSet<Planes1>();
        }

        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public ICollection<GrupoProductoPlan1> GrupoProductoPlan1 { get; set; }
        public ICollection<Planes1> Planes1 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Planes1
    {
        public string IdPlan { get; set; }
        public string IdProducto { get; set; }
        public string NombrePlan { get; set; }
        public string DescripcionPlan { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public Productos1 IdProductoNavigation { get; set; }
    }
}

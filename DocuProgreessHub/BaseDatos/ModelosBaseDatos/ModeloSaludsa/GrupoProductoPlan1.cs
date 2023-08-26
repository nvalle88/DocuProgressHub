using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class GrupoProductoPlan1
    {
        public int IdGrupoProductoPlan { get; set; }
        public string IdGrupo { get; set; }
        public string IdProducto { get; set; }
        public string IdPlan { get; set; }
        public bool Seleccionado { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime? FechaDesactivacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public Productos1 IdProductoNavigation { get; set; }
    }
}

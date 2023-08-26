using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ServiciosHabilitadosApps
    {
        public string IdProducto { get; set; }
        public string IdPlan { get; set; }
        public string Servicio { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaInicioServicio { get; set; }
        public DateTime FechaFinServicio { get; set; }
    }
}

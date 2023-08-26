using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Servicio1
    {
        public int IdServicio { get; set; }
        public string CodigoServicio { get; set; }
        public string NombreServicio { get; set; }
        public bool? EstadoActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}

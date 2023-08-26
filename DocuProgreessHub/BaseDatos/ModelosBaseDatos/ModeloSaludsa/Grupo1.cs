using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Grupo1
    {
        public string IdGrupo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaCreación { get; set; }
        public DateTime? FechaDesactivacion { get; set; }
    }
}

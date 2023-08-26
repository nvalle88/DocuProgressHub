using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Grupo
    {
        public string IdGrupo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaDesactivacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}

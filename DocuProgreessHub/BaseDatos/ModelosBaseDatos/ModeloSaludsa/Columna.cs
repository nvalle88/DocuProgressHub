using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Columna
    {
        public int IdColumna { get; set; }
        public int IdTabla { get; set; }
        public string NombreColumna { get; set; }
        public string NombrePropiedad { get; set; }
        public string TipoDato { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public Tabla IdTablaNavigation { get; set; }
    }
}

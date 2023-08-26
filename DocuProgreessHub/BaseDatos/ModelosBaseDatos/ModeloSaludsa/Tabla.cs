using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Tabla
    {
        public Tabla()
        {
            Columna = new HashSet<Columna>();
        }

        public int IdTabla { get; set; }
        public string Nombre { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public ICollection<Columna> Columna { get; set; }
    }
}

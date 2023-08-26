using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class TipoEntidad
    {
        public TipoEntidad()
        {
            Entidad = new HashSet<Entidad>();
        }

        public byte Id { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public ICollection<Entidad> Entidad { get; set; }
    }
}

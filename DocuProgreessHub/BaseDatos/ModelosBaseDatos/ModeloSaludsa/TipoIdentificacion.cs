using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class TipoIdentificacion
    {
        public TipoIdentificacion()
        {
            Organizacion = new HashSet<Organizacion>();
        }

        public byte Id { get; set; }
        public string CodigoAlfa { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public ICollection<Organizacion> Organizacion { get; set; }
    }
}

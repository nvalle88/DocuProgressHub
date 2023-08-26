using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class TipoPrestador
    {
        public TipoPrestador()
        {
            Prestador = new HashSet<Prestador>();
            TipoPrestadorCiudadPrestador = new HashSet<TipoPrestadorCiudadPrestador>();
        }

        public short Id { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public ICollection<Prestador> Prestador { get; set; }
        public ICollection<TipoPrestadorCiudadPrestador> TipoPrestadorCiudadPrestador { get; set; }
    }
}

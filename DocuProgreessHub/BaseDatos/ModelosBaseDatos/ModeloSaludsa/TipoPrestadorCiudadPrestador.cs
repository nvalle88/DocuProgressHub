using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class TipoPrestadorCiudadPrestador
    {
        public TipoPrestadorCiudadPrestador()
        {
            SucursalesPrestador = new HashSet<SucursalesPrestador>();
        }

        public int Id { get; set; }
        public short IdTipoPrestador { get; set; }
        public short IdCiudad { get; set; }
        public int IdInformacionPrestador { get; set; }
        public bool EstadoActivo { get; set; }

        public Ciudad IdCiudadNavigation { get; set; }
        public InformacionPrestador IdInformacionPrestadorNavigation { get; set; }
        public TipoPrestador IdTipoPrestadorNavigation { get; set; }
        public ICollection<SucursalesPrestador> SucursalesPrestador { get; set; }
    }
}

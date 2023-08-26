using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class OrdenCentroMedico
    {
        public int Id { get; set; }
        public short IdCiudad { get; set; }
        public int IdPrestador { get; set; }
        public short Orden { get; set; }

        public Ciudad IdCiudadNavigation { get; set; }
        public Prestador IdPrestadorNavigation { get; set; }
    }
}

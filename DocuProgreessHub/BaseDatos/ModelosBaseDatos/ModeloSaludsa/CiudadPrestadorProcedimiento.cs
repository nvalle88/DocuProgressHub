using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CiudadPrestadorProcedimiento
    {
        public int IdCiudad { get; set; }
        public int NumeroConvenio { get; set; }
        public int IdProcedimiento { get; set; }
        public bool EstadoActivo { get; set; }

        public Ciudad1 IdCiudadNavigation { get; set; }
        public Procedimiento IdProcedimientoNavigation { get; set; }
        public Prestador1 NumeroConvenioNavigation { get; set; }
    }
}

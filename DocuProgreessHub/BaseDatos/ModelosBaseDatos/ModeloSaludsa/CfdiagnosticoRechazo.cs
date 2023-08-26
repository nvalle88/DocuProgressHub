using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CfdiagnosticoRechazo
    {
        public int Id { get; set; }
        public int IdSolicitud { get; set; }
        public string CodigoDiagnostico { get; set; }
        public string DescripcionDiagnostico { get; set; }
        public string ReglaAplicada { get; set; }

        public CfsolicitudRechazo IdSolicitudNavigation { get; set; }
    }
}

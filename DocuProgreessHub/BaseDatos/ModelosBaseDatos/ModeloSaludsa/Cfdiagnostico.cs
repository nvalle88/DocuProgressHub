using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cfdiagnostico
    {
        public int Id { get; set; }
        public int IdSolicitud { get; set; }
        public string CodigoDiagnostico { get; set; }
        public string DescripcionDiagnostico { get; set; }

        public Cfsolicitud IdSolicitudNavigation { get; set; }
    }
}

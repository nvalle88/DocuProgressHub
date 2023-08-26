using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cfingreso
    {
        public int Id { get; set; }
        public int IdSolicitud { get; set; }
        public string CodigoIngreso { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Observacion { get; set; }
        public DateTime? FechaConciliacion { get; set; }
        public string DataSolicitudIngresoCredito { get; set; }

        public Cfsolicitud IdSolicitudNavigation { get; set; }
    }
}

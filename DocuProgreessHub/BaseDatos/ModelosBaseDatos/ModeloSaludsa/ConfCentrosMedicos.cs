using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ConfCentrosMedicos
    {
        public ConfCentrosMedicos()
        {
            ConfCentrosMedicosNotificacion = new HashSet<ConfCentrosMedicosNotificacion>();
            ConfParametrosConsultas = new HashSet<ConfParametrosConsultas>();
        }

        public string NombreCorto { get; set; }
        public bool Estado { get; set; }

        public ICollection<ConfCentrosMedicosNotificacion> ConfCentrosMedicosNotificacion { get; set; }
        public ICollection<ConfParametrosConsultas> ConfParametrosConsultas { get; set; }
    }
}

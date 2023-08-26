using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ConfCentrosMedicosNotificacion
    {
        public int CodigoNotificacion { get; set; }
        public string NombreCorto { get; set; }

        public Notificacion CodigoNotificacionNavigation { get; set; }
        public ConfCentrosMedicos NombreCortoNavigation { get; set; }
    }
}

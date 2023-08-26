using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Notificacion
    {
        public Notificacion()
        {
            ConfCentrosMedicosNotificacion = new HashSet<ConfCentrosMedicosNotificacion>();
        }

        public int CodigoNotificacion { get; set; }
        public string CorreoNotificacion { get; set; }

        public ICollection<ConfCentrosMedicosNotificacion> ConfCentrosMedicosNotificacion { get; set; }
    }
}

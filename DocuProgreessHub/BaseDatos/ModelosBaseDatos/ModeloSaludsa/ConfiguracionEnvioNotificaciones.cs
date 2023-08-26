using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ConfiguracionEnvioNotificaciones
    {
        public ConfiguracionEnvioNotificaciones()
        {
            DetalleConfiguracionEnvioNotificaciones = new HashSet<DetalleConfiguracionEnvioNotificaciones>();
        }

        public int Id { get; set; }
        public string DescripcionNotificacion { get; set; }
        public string CodigoProducto { get; set; }
        public string NivelReferencia { get; set; }
        public string CentroMedicoIdInc { get; set; }
        public string CentroMedicoIdExc { get; set; }
        public string NombreCortoCm { get; set; }
        public string Region { get; set; }
        public string TipoCita { get; set; }
        public bool Estado { get; set; }

        public ICollection<DetalleConfiguracionEnvioNotificaciones> DetalleConfiguracionEnvioNotificaciones { get; set; }
    }
}

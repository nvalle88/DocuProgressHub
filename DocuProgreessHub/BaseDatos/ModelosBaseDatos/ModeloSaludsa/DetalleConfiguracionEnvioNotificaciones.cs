using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class DetalleConfiguracionEnvioNotificaciones
    {
        public int Id { get; set; }
        public int IdConfiguracionEnvioNotificaciones { get; set; }
        public string TipoEnvio { get; set; }
        public string DescripcionMensaje { get; set; }
        public string IdDepartamentoMensaje { get; set; }
        public string IdEnvioMensaje { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string HoraEnvio { get; set; }
        public string TiempoEnvioMensaje { get; set; }
        public bool Estado { get; set; }
        public string PeriodoEnvioMensaje { get; set; }
        public string IdPlantillaCorreoElectronico { get; set; }
        public bool? ValidarPorRango { get; set; }
        public int? DiasEnviosDespues { get; set; }
        public string EstadosEntidad { get; set; }
        public string AsuntoPersonalizado { get; set; }

        public ConfiguracionEnvioNotificaciones IdConfiguracionEnvioNotificacionesNavigation { get; set; }
    }
}

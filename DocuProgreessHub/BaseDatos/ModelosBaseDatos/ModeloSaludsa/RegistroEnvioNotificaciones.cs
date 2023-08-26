using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class RegistroEnvioNotificaciones
    {
        public int Id { get; set; }
        public long? IdCitaMedica { get; set; }
        public int IdConfiguracionEnvioNotificaciones { get; set; }
        public int IdDetConfiguracionEnvioNotificaciones { get; set; }
        public DateTime? FechaProceso { get; set; }
        public string EstadoProceso { get; set; }
        public bool Estado { get; set; }
        public string MensajeError { get; set; }
    }
}

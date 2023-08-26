using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class NotificacionTerminosCondiciones
    {
        public int Id { get; set; }
        public int CodigoContrato { get; set; }
        public int NumeroPersona { get; set; }
        public DateTime FechaNotificacion { get; set; }
        public int CodigoPlataforma { get; set; }
        public int CodigoAplicacion { get; set; }
        public string SistemaOperativo { get; set; }
        public string DispositivoNavegador { get; set; }
        public string DireccionIp { get; set; }
    }
}

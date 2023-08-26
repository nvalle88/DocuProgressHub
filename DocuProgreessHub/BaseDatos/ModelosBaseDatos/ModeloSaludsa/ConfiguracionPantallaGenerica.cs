using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ConfiguracionPantallaGenerica
    {
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string Funcionalidad { get; set; }
        public string Personalizacion { get; set; }
        public string Data { get; set; }
        public bool Activo { get; set; }
        public string CodigoPlanExcepsion { get; set; }
    }
}

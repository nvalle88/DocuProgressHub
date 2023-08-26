using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ConfiguracionPantalla
    {
        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string DataInformacion { get; set; }
        public bool Activo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PresupuestoVendedor
    {
        public int Codigo { get; set; }
        public int? Desde { get; set; }
        public int? Hasta { get; set; }
        public bool? Comodin { get; set; }
        public bool? Estado { get; set; }
        public int? CodigoRango { get; set; }
        public int? Porcentaje { get; set; }
        public int? TipoPresupuesto { get; set; }

        public Rangos CodigoRangoNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Rangos
    {
        public Rangos()
        {
            ObservacionRangos = new HashSet<ObservacionRangos>();
            PresupuestoVendedor = new HashSet<PresupuestoVendedor>();
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int? CodigoSubtipo { get; set; }
        public int? CodigoSucursal { get; set; }
        public bool Estado { get; set; }
        public int? Desde { get; set; }
        public int? Hasta { get; set; }
        public int? CodigoCanales { get; set; }

        public Canales CodigoCanalesNavigation { get; set; }
        public Subtipos CodigoSubtipoNavigation { get; set; }
        public ICollection<ObservacionRangos> ObservacionRangos { get; set; }
        public ICollection<PresupuestoVendedor> PresupuestoVendedor { get; set; }
    }
}

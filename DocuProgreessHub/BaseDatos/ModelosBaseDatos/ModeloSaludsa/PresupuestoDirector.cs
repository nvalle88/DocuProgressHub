using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PresupuestoDirector
    {
        public int Codigo { get; set; }
        public bool? Comodin { get; set; }
        public bool? Estado { get; set; }
        public int? CodigoSala { get; set; }
        public string CodigoProducto { get; set; }
        public int? Monto { get; set; }

        public Salas CodigoSalaNavigation { get; set; }
    }
}

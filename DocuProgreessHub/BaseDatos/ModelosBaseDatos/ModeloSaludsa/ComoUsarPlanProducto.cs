using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ComoUsarPlanProducto
    {
        public ComoUsarPlanProducto()
        {
            ComoUsarPlanGuiaUso = new HashSet<ComoUsarPlanGuiaUso>();
        }

        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }

        public ICollection<ComoUsarPlanGuiaUso> ComoUsarPlanGuiaUso { get; set; }
    }
}

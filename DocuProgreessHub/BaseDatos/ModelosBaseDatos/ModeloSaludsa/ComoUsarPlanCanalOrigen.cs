using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ComoUsarPlanCanalOrigen
    {
        public ComoUsarPlanCanalOrigen()
        {
            ComoUsarPlanGuiaUso = new HashSet<ComoUsarPlanGuiaUso>();
        }

        public int Id { get; set; }
        public string CanalOrigen { get; set; }

        public ICollection<ComoUsarPlanGuiaUso> ComoUsarPlanGuiaUso { get; set; }
    }
}

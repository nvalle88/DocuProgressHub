using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ComoUsarPlanGuiaUso
    {
        public int IdComoUsarPlanCanalOrigen { get; set; }
        public int IdComoUsarPlanProducto { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Url { get; set; }
        public string UrlIcono { get; set; }

        public ComoUsarPlanCanalOrigen ComoUsarPlanCanalOrigen { get; set; }
        public ComoUsarPlanProducto ComoUsarPlanProducto { get; set; }
    }
}

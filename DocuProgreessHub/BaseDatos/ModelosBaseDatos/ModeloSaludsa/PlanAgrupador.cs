using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PlanAgrupador
    {
        public PlanAgrupador()
        {
            CoberturaSeccion1 = new HashSet<CoberturaSeccion1>();
            DeducibleSeccion = new HashSet<DeducibleSeccion>();
        }

        public int IdPlanAgrupador { get; set; }
        public string Region { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public int VersionPlan { get; set; }
        public string TituloPantalla { get; set; }
        public bool PermiteIndividual { get; set; }
        public string Expresion { get; set; }
        public bool EsCarrusel { get; set; }

        public ICollection<CoberturaSeccion1> CoberturaSeccion1 { get; set; }
        public ICollection<DeducibleSeccion> DeducibleSeccion { get; set; }
    }
}

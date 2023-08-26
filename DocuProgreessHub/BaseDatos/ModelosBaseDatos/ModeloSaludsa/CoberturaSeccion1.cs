using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturaSeccion1
    {
        public CoberturaSeccion1()
        {
            CoberturaBeneficio = new HashSet<CoberturaBeneficio>();
        }

        public int IdCoberturaSeccion { get; set; }
        public int IdPlanAgrupador { get; set; }
        public int? IdAgrupadorCobertura { get; set; }
        public string CodigoCobertura { get; set; }
        public string TipoCobertura { get; set; }
        public string TituloPantalla { get; set; }
        public string SubTitulo { get; set; }
        public string TextoDetalle { get; set; }
        public short Orden { get; set; }
        public bool EsCarrusel { get; set; }
        public string Icono { get; set; }
        public string Experesion { get; set; }
        public bool EsCabecera { get; set; }
        public bool PermiteIndividual { get; set; }

        public AgrupadorCobertura IdAgrupadorCoberturaNavigation { get; set; }
        public PlanAgrupador IdPlanAgrupadorNavigation { get; set; }
        public ICollection<CoberturaBeneficio> CoberturaBeneficio { get; set; }
    }
}

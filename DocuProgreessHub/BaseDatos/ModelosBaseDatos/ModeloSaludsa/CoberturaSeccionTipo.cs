using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturaSeccionTipo
    {
        public CoberturaSeccionTipo()
        {
            CoberturaSeccionTipoCobertura = new HashSet<CoberturaSeccionTipoCobertura>();
        }

        public int IdCoberturaSeccionTipo { get; set; }
        public int IdCoberturaSeccion { get; set; }
        public int IdCoberturaTipo { get; set; }
        public int Orden { get; set; }
        public bool EsCarrusel { get; set; }
        public string Icono { get; set; }

        public CoberturaSeccion IdCoberturaSeccionNavigation { get; set; }
        public CoberturaTipo IdCoberturaTipoNavigation { get; set; }
        public ICollection<CoberturaSeccionTipoCobertura> CoberturaSeccionTipoCobertura { get; set; }
    }
}

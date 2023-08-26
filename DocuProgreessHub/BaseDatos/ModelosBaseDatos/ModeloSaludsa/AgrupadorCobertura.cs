using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class AgrupadorCobertura
    {
        public AgrupadorCobertura()
        {
            CoberturaSeccion1 = new HashSet<CoberturaSeccion1>();
        }

        public int IdAgrupadorCobertura { get; set; }
        public string TituloPantalla { get; set; }

        public ICollection<CoberturaSeccion1> CoberturaSeccion1 { get; set; }
    }
}

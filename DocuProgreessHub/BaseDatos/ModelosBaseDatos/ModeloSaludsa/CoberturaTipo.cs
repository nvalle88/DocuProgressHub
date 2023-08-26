using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturaTipo
    {
        public CoberturaTipo()
        {
            CoberturaSeccionTipo = new HashSet<CoberturaSeccionTipo>();
        }

        public int IdCoberturaTipo { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        public ICollection<CoberturaSeccionTipo> CoberturaSeccionTipo { get; set; }
    }
}

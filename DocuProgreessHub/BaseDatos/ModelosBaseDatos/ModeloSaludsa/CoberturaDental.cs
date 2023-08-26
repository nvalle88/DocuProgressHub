using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturaDental
    {
        public CoberturaDental()
        {
            CoberturasDent = new HashSet<CoberturasDent>();
        }

        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string TituloPantalla { get; set; }
        public string SubTitulo { get; set; }
        public string TextoDetalle { get; set; }

        public ICollection<CoberturasDent> CoberturasDent { get; set; }
    }
}

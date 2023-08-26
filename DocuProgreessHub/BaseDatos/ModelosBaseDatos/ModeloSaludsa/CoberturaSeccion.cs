using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturaSeccion
    {
        public CoberturaSeccion()
        {
            CoberturaSeccionTipo = new HashSet<CoberturaSeccionTipo>();
        }

        public int IdCoberturaSeccion { get; set; }
        public string Region { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public int VersionPlan { get; set; }
        public string TituloPantalla { get; set; }
        public string SubTitulo { get; set; }
        public string Valor { get; set; }
        public string TextoDetalle { get; set; }
        public string Icono { get; set; }

        public ICollection<CoberturaSeccionTipo> CoberturaSeccionTipo { get; set; }
    }
}

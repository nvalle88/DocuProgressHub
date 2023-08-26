using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturaSeccionTipoCobertura
    {
        public int IdCoberturaSeccionTipoCobertura { get; set; }
        public int IdCoberturaSeccionTipo { get; set; }
        public string Region { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public int VersionPlan { get; set; }
        public string CodigoCobertura { get; set; }
        public string TipoCobertura { get; set; }
        public int Orden { get; set; }
        public string Icono { get; set; }

        public CoberturaSeccionTipo IdCoberturaSeccionTipoNavigation { get; set; }
    }
}

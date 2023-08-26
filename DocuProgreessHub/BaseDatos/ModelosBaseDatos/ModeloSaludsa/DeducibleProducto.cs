using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class DeducibleProducto
    {
        public int IdDeducibleProducto { get; set; }
        public string Region { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public int VersionPlan { get; set; }
        public string CodigoDeducible { get; set; }
        public string TipoCobertura { get; set; }
        public string TituloPantalla { get; set; }
        public string SubTitulo { get; set; }
        public string TextoDetalle { get; set; }
        public short? Orden { get; set; }
        public bool EsCarrusel { get; set; }
        public string Icono { get; set; }
        public string Expresion { get; set; }
        public bool EsCabecera { get; set; }
    }
}

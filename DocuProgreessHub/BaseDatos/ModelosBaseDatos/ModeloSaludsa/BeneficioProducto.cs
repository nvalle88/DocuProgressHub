using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class BeneficioProducto
    {
        public int IdBeneficioProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoCobertura { get; set; }
        public string CodigoBeneficio { get; set; }
        public string TipoCobertura { get; set; }
        public string TituloPantalla { get; set; }
        public string SubTitulo { get; set; }
        public int Orden { get; set; }
        public string Icono { get; set; }
        public string Expresion { get; set; }
        public bool EsCabecera { get; set; }
    }
}

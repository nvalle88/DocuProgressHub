using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturaBeneficio
    {
        public int IdCoberturaBeneficio { get; set; }
        public int IdCoberturaSeccion { get; set; }
        public string CodigoBeneficio { get; set; }
        public string TipoCobertura { get; set; }
        public string TituloPantalla { get; set; }
        public string SubTitulo { get; set; }
        public int Orden { get; set; }
        public string Icono { get; set; }
        public string Expresion { get; set; }
        public bool EsCabecera { get; set; }

        public CoberturaSeccion1 IdCoberturaSeccionNavigation { get; set; }
    }
}

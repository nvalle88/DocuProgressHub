using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ServicioAdicionalSeccion
    {
        public int IdServiciosAdicionalesSeccion { get; set; }
        public string CodigoServicio { get; set; }
        public string TituloPantalla { get; set; }
        public string SubTitulo { get; set; }
        public string TextoDetalle { get; set; }
        public short Orden { get; set; }
        public bool EsCarrusel { get; set; }
        public string Icono { get; set; }
        public string UrlPdf { get; set; }
        public string Expresion { get; set; }
        public bool EsCabecera { get; set; }
    }
}

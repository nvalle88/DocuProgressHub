using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturaNacInt
    {
        public CoberturaNacInt()
        {
            CoberturaNacIntTipoCobertura = new HashSet<CoberturaNacIntTipoCobertura>();
        }

        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string TituloPantalla { get; set; }
        public string SubTitulo { get; set; }
        public string Valor { get; set; }
        public string OrigenCobertura { get; set; }
        public string TextoDetalle { get; set; }
        public string Icono { get; set; }

        public ICollection<CoberturaNacIntTipoCobertura> CoberturaNacIntTipoCobertura { get; set; }
    }
}

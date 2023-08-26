using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CfmedicamentoRechazo
    {
        public int Id { get; set; }
        public int IdSolicitud { get; set; }
        public string CodigoProducto { get; set; }
        public int? CodigoProductoSalud { get; set; }
        public string DescripcionProducto { get; set; }
        public string PrincipioActivo { get; set; }
        public string ReglaAplicada { get; set; }
        public decimal? Valor { get; set; }

        public CfsolicitudRechazo IdSolicitudNavigation { get; set; }
    }
}

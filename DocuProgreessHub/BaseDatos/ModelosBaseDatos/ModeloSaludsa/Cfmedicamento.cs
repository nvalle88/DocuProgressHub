using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cfmedicamento
    {
        public int Id { get; set; }
        public int IdSolicitud { get; set; }
        public string CodigoProducto { get; set; }
        public int? CodigoProductoSalud { get; set; }
        public string DescripcionProducto { get; set; }
        public string PrincipioActivo { get; set; }
        public short? Cantidad { get; set; }
        public short? Prioridad { get; set; }
        public short? CantidadEntregada { get; set; }
        public decimal? Valor { get; set; }
        public short? Cobertura { get; set; }
        public bool? Aprobado { get; set; }
        public int? CodigoProcedimiento { get; set; }
        public string CodigoBeneficio { get; set; }
    }
}

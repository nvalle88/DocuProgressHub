using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class EstadoCuentaBancaria
    {
        public int CodigoBanco { get; set; }
        public DateTime Fecha { get; set; }
        public string Documento { get; set; }
        public decimal Saldo { get; set; }
        public string Codigo { get; set; }
        public string Concepto { get; set; }
        public string Tipo { get; set; }
        public decimal? Monto { get; set; }
    }
}

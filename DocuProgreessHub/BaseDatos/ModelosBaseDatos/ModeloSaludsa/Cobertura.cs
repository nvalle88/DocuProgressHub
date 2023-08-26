using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cobertura
    {
        public int Id { get; set; }
        public double ValorCoberturaMin { get; set; }
        public double ValorCoberturaMax { get; set; }
        public double ValorTasa { get; set; }
        public double ValorPrima { get; set; }
        public int PolizaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public Poliza Poliza { get; set; }
    }
}

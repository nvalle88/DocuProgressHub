using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CriterioValor
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public double Valor { get; set; }
        public string Descripcion { get; set; }
        public int CriterioId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public Criterio Criterio { get; set; }
    }
}

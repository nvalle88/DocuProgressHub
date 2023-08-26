using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Periodo
    {
        public Periodo()
        {
            Resumen = new HashSet<Resumen>();
        }

        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string PeriodoEstado { get; set; }
        public int PolizaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public Poliza Poliza { get; set; }
        public ICollection<Resumen> Resumen { get; set; }
    }
}

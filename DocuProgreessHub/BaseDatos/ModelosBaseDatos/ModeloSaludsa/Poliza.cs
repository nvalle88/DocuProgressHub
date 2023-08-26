using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Poliza
    {
        public Poliza()
        {
            Cobertura = new HashSet<Cobertura>();
            Criterio = new HashSet<Criterio>();
            Periodo = new HashSet<Periodo>();
        }

        public int Id { get; set; }
        public string NumeroPoliza { get; set; }
        public string Version { get; set; }
        public DateTime VersionFecha { get; set; }
        public int ServicioCatalogoId { get; set; }
        public int DiaProcesamiento { get; set; }
        public int DiaCorte { get; set; }
        public int ProveedorId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public Proveedor Proveedor { get; set; }
        public Servicio ServicioCatalogo { get; set; }
        public ICollection<Cobertura> Cobertura { get; set; }
        public ICollection<Criterio> Criterio { get; set; }
        public ICollection<Periodo> Periodo { get; set; }
    }
}

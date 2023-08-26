using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Criterio
    {
        public Criterio()
        {
            CriterioValor = new HashSet<CriterioValor>();
        }

        public int Id { get; set; }
        public int? EdadMin { get; set; }
        public int? EdadMax { get; set; }
        public double? CoberturaMin { get; set; }
        public double? CoberturaMax { get; set; }
        public int? CatalogoRegionId { get; set; }
        public int? CatalogoProductoId { get; set; }
        public int? CatalogoRelacionId { get; set; }
        public int? CatalogoGeneroId { get; set; }
        public int? CatalogoEsTitularId { get; set; }
        public bool TarifaPorContrato { get; set; }
        public int PolizaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public CatalogoGeneral CatalogoEsTitular { get; set; }
        public CatalogoGeneral CatalogoGenero { get; set; }
        public CatalogoGeneral CatalogoProducto { get; set; }
        public CatalogoGeneral CatalogoRegion { get; set; }
        public CatalogoGeneral CatalogoRelacion { get; set; }
        public Poliza Poliza { get; set; }
        public ICollection<CriterioValor> CriterioValor { get; set; }
    }
}

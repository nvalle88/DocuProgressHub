using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CatalogoGeneral
    {
        public CatalogoGeneral()
        {
            BeneficiarioCategoriaCatalogo = new HashSet<Beneficiario>();
            BeneficiarioRelacionCatalogo = new HashSet<Beneficiario>();
            CriterioCatalogoEsTitular = new HashSet<Criterio>();
            CriterioCatalogoGenero = new HashSet<Criterio>();
            CriterioCatalogoProducto = new HashSet<Criterio>();
            CriterioCatalogoRegion = new HashSet<Criterio>();
            CriterioCatalogoRelacion = new HashSet<Criterio>();
            InversePadre = new HashSet<CatalogoGeneral>();
            Resumen = new HashSet<Resumen>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public string CodigoSigmep { get; set; }
        public int? PadreId { get; set; }

        public CatalogoGeneral Padre { get; set; }
        public ICollection<Beneficiario> BeneficiarioCategoriaCatalogo { get; set; }
        public ICollection<Beneficiario> BeneficiarioRelacionCatalogo { get; set; }
        public ICollection<Criterio> CriterioCatalogoEsTitular { get; set; }
        public ICollection<Criterio> CriterioCatalogoGenero { get; set; }
        public ICollection<Criterio> CriterioCatalogoProducto { get; set; }
        public ICollection<Criterio> CriterioCatalogoRegion { get; set; }
        public ICollection<Criterio> CriterioCatalogoRelacion { get; set; }
        public ICollection<CatalogoGeneral> InversePadre { get; set; }
        public ICollection<Resumen> Resumen { get; set; }
    }
}

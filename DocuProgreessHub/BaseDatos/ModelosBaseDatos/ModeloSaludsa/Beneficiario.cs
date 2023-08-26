using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Beneficiario
    {
        public Beneficiario()
        {
            ServicioBeneficiario = new HashSet<ServicioBeneficiario>();
        }

        public int Id { get; set; }
        public string PersonaId { get; set; }
        public bool Titular { get; set; }
        public string BeneficiarioCedula { get; set; }
        public string BeneficiarioNombre { get; set; }
        public DateTime BeneficiarioFechaNacimiento { get; set; }
        public DateTime FechaInclusion { get; set; }
        public int CatalogoRelacionId { get; set; }
        public int CatalogoCategoriaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }
        public int? CategoriaCatalogoId { get; set; }
        public int? RelacionCatalogoId { get; set; }

        public CatalogoGeneral CategoriaCatalogo { get; set; }
        public CatalogoGeneral RelacionCatalogo { get; set; }
        public ICollection<ServicioBeneficiario> ServicioBeneficiario { get; set; }
    }
}

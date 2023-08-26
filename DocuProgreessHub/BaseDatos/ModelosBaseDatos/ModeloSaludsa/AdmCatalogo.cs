using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class AdmCatalogo
    {
        public AdmCatalogo()
        {
            AdmItemCatalogo = new HashSet<AdmItemCatalogo>();
        }

        public int CatId { get; set; }
        public string CatNombre { get; set; }
        public string CatCodigo { get; set; }
        public string CatDescripcion { get; set; }
        public string CatEstado { get; set; }

        public ICollection<AdmItemCatalogo> AdmItemCatalogo { get; set; }
    }
}

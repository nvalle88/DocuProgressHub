using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Catalogo
    {
        public Catalogo()
        {
            InverseCatalogoPadre = new HashSet<Catalogo>();
            ItemCatalogo = new HashSet<ItemCatalogo>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }
        public int? CatalogoPadreId { get; set; }

        public Catalogo CatalogoPadre { get; set; }
        public ICollection<Catalogo> InverseCatalogoPadre { get; set; }
        public ICollection<ItemCatalogo> ItemCatalogo { get; set; }
    }
}

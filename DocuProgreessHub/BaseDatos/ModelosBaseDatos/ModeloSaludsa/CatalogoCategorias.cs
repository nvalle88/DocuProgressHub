using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CatalogoCategorias
    {
        public CatalogoCategorias()
        {
            Noticia = new HashSet<Noticia>();
        }

        public int IdCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public ICollection<Noticia> Noticia { get; set; }
    }
}

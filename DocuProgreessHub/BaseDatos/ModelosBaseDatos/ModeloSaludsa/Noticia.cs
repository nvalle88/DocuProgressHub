using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Noticia
    {
        public Noticia()
        {
            GrupoNoticias = new HashSet<GrupoNoticias>();
        }

        public int IdNoticia { get; set; }
        public string TituloNoticia { get; set; }
        public string SubtituloNoticia { get; set; }
        public string EtiquetaNoticia { get; set; }
        public string UrlImagen { get; set; }
        public DateTime FechaPublicadoInicio { get; set; }
        public DateTime FechaPublicadoFin { get; set; }
        public int IdTipoNoticia { get; set; }
        public int IdTipoFuncionalidad { get; set; }
        public int IdCategoria { get; set; }
        public bool EstadoActivo { get; set; }
        public string UsuarioRegistrador { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string CuerpoNoticia { get; set; }

        public CatalogoCategorias IdCategoriaNavigation { get; set; }
        public ICollection<GrupoNoticias> GrupoNoticias { get; set; }
    }
}

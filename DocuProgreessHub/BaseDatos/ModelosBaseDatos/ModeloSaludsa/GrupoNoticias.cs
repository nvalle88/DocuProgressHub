using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class GrupoNoticias
    {
        public int IdGrupoNoticias { get; set; }
        public int IdNoticia { get; set; }
        public string IdGrupo { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public Grupo2 IdGrupoNavigation { get; set; }
        public Noticia IdNoticiaNavigation { get; set; }
    }
}

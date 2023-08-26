using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Noticia1
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Etiquetas { get; set; }
        public string ImagenUrl { get; set; }
        public DateTime FechaInicioPublicacion { get; set; }
        public DateTime FechaFinPublicacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaUltimaModificacion { get; set; }
        public bool Estado { get; set; }
    }
}

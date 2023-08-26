using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Equivalencia
    {
        public long Id { get; set; }
        public long EntidadId { get; set; }
        public int TematicaId { get; set; }
        public string CodigoExterno { get; set; }
        public string DescripcionExterna { get; set; }
        public int CodigoHomologado { get; set; }
        public string CodigoAlfaHomologado { get; set; }
        public string DescripcionHomologada { get; set; }
        public bool EstadoActivo { get; set; }

        public Entidad Entidad { get; set; }
        public Tematica Tematica { get; set; }
    }
}

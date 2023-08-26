using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class EquivalenciaEntidadPersona
    {
        public long Id { get; set; }
        public long EntidadId { get; set; }
        public string CodigoExterno { get; set; }
        public long PersonaId { get; set; }
        public bool Verificar { get; set; }

        public Entidad Entidad { get; set; }
        public Persona Persona { get; set; }
    }
}

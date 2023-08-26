using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Entidad
    {
        public Entidad()
        {
            Equivalencia = new HashSet<Equivalencia>();
            EquivalenciaEntidadPersona = new HashSet<EquivalenciaEntidadPersona>();
            Prestador = new HashSet<Prestador>();
            Usuario = new HashSet<Usuario>();
        }

        public long Id { get; set; }
        public byte TipoEntidadId { get; set; }

        public TipoEntidad TipoEntidad { get; set; }
        public Organizacion Organizacion { get; set; }
        public Persona Persona { get; set; }
        public ICollection<Equivalencia> Equivalencia { get; set; }
        public ICollection<EquivalenciaEntidadPersona> EquivalenciaEntidadPersona { get; set; }
        public ICollection<Prestador> Prestador { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
    }
}

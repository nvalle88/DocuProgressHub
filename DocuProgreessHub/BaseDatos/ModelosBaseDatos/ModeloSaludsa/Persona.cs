using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Persona
    {
        public Persona()
        {
            EquivalenciaEntidadPersona = new HashSet<EquivalenciaEntidadPersona>();
            Usuario = new HashSet<Usuario>();
        }

        public long Id { get; set; }
        public long EntidadId { get; set; }
        public short NacionalidadId { get; set; }
        public string Identificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoNombre { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Mail { get; set; }
        public string TelefonoMovil { get; set; }
        public bool Genero { get; set; }
        public int NumeroPersona { get; set; }
        public bool? EstadoActivo { get; set; }
        public string TipoIdentificacion { get; set; }

        public Entidad Entidad { get; set; }
        public Pais Nacionalidad { get; set; }
        public ICollection<EquivalenciaEntidadPersona> EquivalenciaEntidadPersona { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
    }
}

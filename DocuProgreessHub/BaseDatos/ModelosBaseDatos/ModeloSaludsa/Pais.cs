using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Pais
    {
        public Pais()
        {
            Ciudad = new HashSet<Ciudad>();
            Organizacion = new HashSet<Organizacion>();
            Persona = new HashSet<Persona>();
            Provincia = new HashSet<Provincia>();
            Region = new HashSet<Region>();
        }

        public short Id { get; set; }
        public string NombreComunPais { get; set; }
        public string NombreIsopais { get; set; }
        public string CodigoIsoalfa2 { get; set; }
        public string CodigoIsoalfa3 { get; set; }
        public short CodigoIsonumerico { get; set; }
        public string CodigoTelefonico { get; set; }
        public string NombreNacionalidad { get; set; }
        public string NombreIdioma { get; set; }
        public bool EstadoActivo { get; set; }

        public ICollection<Ciudad> Ciudad { get; set; }
        public ICollection<Organizacion> Organizacion { get; set; }
        public ICollection<Persona> Persona { get; set; }
        public ICollection<Provincia> Provincia { get; set; }
        public ICollection<Region> Region { get; set; }
    }
}

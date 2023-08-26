using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            EspecialidadCiudad = new HashSet<EspecialidadCiudad>();
            OrdenCentroMedico = new HashSet<OrdenCentroMedico>();
            TipoPrestadorCiudadPrestador = new HashSet<TipoPrestadorCiudadPrestador>();
        }

        public short Id { get; set; }
        public string Nombre { get; set; }
        public short PaisId { get; set; }
        public short RegionId { get; set; }
        public short ProvinciaId { get; set; }
        public bool EstadoActivo { get; set; }

        public Pais Pais { get; set; }
        public Provincia Provincia { get; set; }
        public Region Region { get; set; }
        public ICollection<EspecialidadCiudad> EspecialidadCiudad { get; set; }
        public ICollection<OrdenCentroMedico> OrdenCentroMedico { get; set; }
        public ICollection<TipoPrestadorCiudadPrestador> TipoPrestadorCiudadPrestador { get; set; }
    }
}

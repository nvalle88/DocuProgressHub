using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Prestador
    {
        public Prestador()
        {
            EspecialidadCiudad = new HashSet<EspecialidadCiudad>();
            OrdenCentroMedico = new HashSet<OrdenCentroMedico>();
            PrestadorUsuario = new HashSet<PrestadorUsuario>();
        }

        public int Id { get; set; }
        public short TipoPrestadorId { get; set; }
        public long EntidadId { get; set; }
        public int NumeroConvenio { get; set; }
        public bool? EstadoActivo { get; set; }
        public bool? EmiteOdaPortalPrestadores { get; set; }

        public Entidad Entidad { get; set; }
        public TipoPrestador TipoPrestador { get; set; }
        public ConfiguracionPrestadorSrvCita ConfiguracionPrestadorSrvCita { get; set; }
        public ICollection<EspecialidadCiudad> EspecialidadCiudad { get; set; }
        public ICollection<OrdenCentroMedico> OrdenCentroMedico { get; set; }
        public ICollection<PrestadorUsuario> PrestadorUsuario { get; set; }
    }
}

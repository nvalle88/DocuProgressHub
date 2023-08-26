using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Preexistencia
    {
        public Preexistencia()
        {
            PreexistenciaDetalle = new HashSet<PreexistenciaDetalle>();
        }

        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public int ContratoNumero { get; set; }
        public int CodigoContrato { get; set; }
        public string CodigoPlan { get; set; }
        public int NumeroPersonaTitular { get; set; }
        public string NombresPersonaTitular { get; set; }
        public string IdentificacionTitular { get; set; }
        public string Region { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string EstadoRegistro { get; set; }
        public string UrlEnvio { get; set; }
        public string IdUrlHash { get; set; }
        public DateTime? FechaEnvioCorreo { get; set; }
        public DateTime? FechaReenvioCorreo { get; set; }
        public DateTime? FechaEnvioArmonix { get; set; }
        public string IngresadoPor { get; set; }
        public string CorreoNotificacion { get; set; }
        public bool? AceptoTerminosCondiciones { get; set; }
        public DateTime? FechaAceptoTerminosCondiciones { get; set; }
        public int? NumeroEmpresa { get; set; }
        public int? NumeroSucursal { get; set; }
        public string UsuarioReenvioCorreo { get; set; }
        public string UsuarioEnvioArmonix { get; set; }

        public ICollection<PreexistenciaDetalle> PreexistenciaDetalle { get; set; }
    }
}

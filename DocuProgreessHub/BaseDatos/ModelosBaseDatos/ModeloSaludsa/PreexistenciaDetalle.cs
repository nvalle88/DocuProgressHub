using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PreexistenciaDetalle
    {
        public int Id { get; set; }
        public int IdPreexistencia { get; set; }
        public int NumeroPersona { get; set; }
        public string NombresPersona { get; set; }
        public string DocumentoIdentificacion { get; set; }
        public string RelacionPersona { get; set; }
        public string CodigoTipoPreexistencia { get; set; }
        public string NombreTipoPreexistencia { get; set; }
        public string CodigoDiagnostico { get; set; }
        public string DescripcionDiagnostico { get; set; }
        public string EsCongenito { get; set; }
        public string PorcentajeDiscapacidad { get; set; }
        public string EstadoDiagnostico { get; set; }
        public DateTime FechaInicioContrato { get; set; }
        public DateTime FechaFinContrato { get; set; }
        public int DiasCarenciaDiagnostico { get; set; }
        public string Observacion { get; set; }
        public DateTime? FechaGestionCliente { get; set; }
        public DateTime? FechaGestionAutomatica { get; set; }
        public string EstadoAceptacion { get; set; }
        public string MotivoRechazo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CabeceraDiagnostico { get; set; }
        public string RiesgoCliente { get; set; }
        public string MensajeErrorArmonix { get; set; }

        public Preexistencia IdPreexistenciaNavigation { get; set; }
    }
}

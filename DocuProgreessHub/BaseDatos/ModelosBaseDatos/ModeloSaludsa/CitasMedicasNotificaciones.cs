using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CitasMedicasNotificaciones
    {
        public long Id { get; set; }
        public string CodigoCitaCentroMedico { get; set; }
        public int CentroMedicoId { get; set; }
        public string CodigoSucursalCentroMedico { get; set; }
        public string CodigoMedicoCentroMedico { get; set; }
        public string NombreMedicoPrestador { get; set; }
        public long CodigoContrato { get; set; }
        public int TitularContratoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public TimeSpan Duracion { get; set; }
        public decimal? Costo { get; set; }
        public int CodigoPlataforma { get; set; }
        public byte EstadoAtencionId { get; set; }
        public string NombreSucursalCentroMedico { get; set; }
        public long NumeroContrato { get; set; }
        public long NumeroPersonaPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string IdHorarioDisponible { get; set; }
        public string CodigoEspecialidad { get; set; }
        public string RegistradoPor { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CodigoAplicacion { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int? CodigoCancelacion { get; set; }
        public string CorreoNotificacion { get; set; }
        public int? IdCiudad { get; set; }
        public string EstadoEnvio { get; set; }
        public string DescripcionEstadoAtencion { get; set; }
        public string DescripcionEspecialidad { get; set; }
        public string NombreCentroMedico { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public DateTime? FechaProceso { get; set; }
        public string MensajeError { get; set; }
        public bool Estado { get; set; }
        public string UrlPago { get; set; }
        public bool? EsOnline { get; set; }
    }
}

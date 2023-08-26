using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class SolicitudCitaMedicoDestacado
    {
        public int Id { get; set; }
        public long NumeroContrato { get; set; }
        public int NumeroPersonaPaciente { get; set; }
        public int NumeroMedicoPrestador { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string TelefonoCelular { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public byte Jornada { get; set; }
        public string Observaciones { get; set; }
        public byte? EstadoSolicitud { get; set; }
        public string MotivoRechazo { get; set; }
        public int? IdCita { get; set; }
        public int CodigoPlataforma { get; set; }
        public DateTime FechaRegistro { get; set; }
        public long CodigoContrato { get; set; }
        public string CodigoEspecialidad { get; set; }
        public int TitularContratoId { get; set; }
        public string RegistradoPor { get; set; }
    }
}

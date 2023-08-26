using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class FormularioHospitalario
    {
        public int Id { get; set; }
        public int CodigoContrato { get; set; }
        public int NumeroContrato { get; set; }
        public string Region { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public int NumeroPersonaTitular { get; set; }
        public string NombresTitular { get; set; }
        public int NumeroPersonaBeneficiario { get; set; }
        public string NombresBeneficiario { get; set; }
        public string CelularBeneficiario { get; set; }
        public string CorreoBeneficiario { get; set; }
        public int CodigoCiudad { get; set; }
        public string NombreCiudad { get; set; }
        public int ConvenioPrestador { get; set; }
        public string NombrePrestador { get; set; }
        public string MedicoTratante { get; set; }
        public string CodigoProcedimiento { get; set; }
        public string NombreProcedimiento { get; set; }
        public string CodigoDiagnostico { get; set; }
        public string NombreDiagnostico { get; set; }
        public DateTime FechaProcedimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? EsPacienteCovid { get; set; }
        public string NombresAcompanante { get; set; }
        public string TelefonoAcompanante { get; set; }
        public string CorreoAcompanante { get; set; }
        public string Observacion { get; set; }
        public bool AceptaTerminosCondiciones { get; set; }
        public int? CodigoEstado { get; set; }
        public int? IdTicketZendesk { get; set; }
        public string UrlTicketZendesk { get; set; }
        public string CanalOrigen { get; set; }
        public bool? EsHospitalizacion { get; set; }
        public bool? EsMaternidad { get; set; }
        public bool? EsCancer { get; set; }
        public string UsuarioCanalOrigen { get; set; }
        public int? NumeroAutorizacionHospitalaria { get; set; }
        public DateTime? FechaAutorizacionHospitalaria { get; set; }
        public int? EstadoAutorizacionHospitalaria { get; set; }
        public string ComentarioEstadoAutorizacionHospitalario { get; set; }
        public decimal? MontoAutorizado { get; set; }
        public int? DiasAutorizados { get; set; }
        public string NombreCajero { get; set; }
        public string CorreoCajero { get; set; }
        public int? NumeroConvenioMedico { get; set; }
        public string TipoSolicitud { get; set; }
        public decimal? ValorProforma { get; set; }
        public string TipoTratamiento { get; set; }
        public string MailAdicional { get; set; }
        public bool? MailClienteEnviado { get; set; }
        public DateTime? FechaEnvioMailCliente { get; set; }
        public bool? MailEnviadoPrestador { get; set; }
        public DateTime? FechaEnvioMailPrestador { get; set; }
        public bool? MailEnviadoAdicional { get; set; }
        public DateTime? FechaEnvioMailAdicional { get; set; }
    }
}

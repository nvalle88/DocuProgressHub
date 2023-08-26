using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class SeguimientoPrestadorSaludsaContigo
    {
        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string Region { get; set; }
        public int ContratoNumero { get; set; }
        public int PersonaNumero { get; set; }
        public string DocumentoIdentificacionBeneficiario { get; set; }
        public string NombresBeneficiario { get; set; }
        public int NumeroSeguimiento { get; set; }
        public DateTime FechaGestion { get; set; }
        public string ResultadoGestion { get; set; }
        public string EstadoGestion { get; set; }
        public int? NumeroDosis { get; set; }
        public string MedicacionEntregada { get; set; }
        public string DiagnosticoSeguimiento { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaProximaEntrega { get; set; }
        public string NumeroFactura { get; set; }
        public decimal? ValorFactura { get; set; }
        public bool? AceptaMedicacion { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool EstadoActivo { get; set; }
        public string TelefonoContacto { get; set; }
        public string CorreoContacto { get; set; }
        public string DireccionBeneficiario { get; set; }
        public string DiagnosticoBeneficiario { get; set; }
        public string MedicacionBeneficiario { get; set; }
        public DateTime? FechaMaxMedicacionBeneficiario { get; set; }
        public string HorarioEntregaBeneficiario { get; set; }
        public string ObservacionBeneficiario { get; set; }
        public bool? EsUltimoRegistro { get; set; }
        public string UsuarioGestion { get; set; }

        public SaludsaContigo SaludsaContigo { get; set; }
    }
}

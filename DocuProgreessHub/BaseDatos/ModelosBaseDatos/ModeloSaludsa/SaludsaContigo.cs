using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class SaludsaContigo
    {
        public SaludsaContigo()
        {
            SeguimientoPrestadorSaludsaContigo = new HashSet<SeguimientoPrestadorSaludsaContigo>();
        }

        public string CodigoProducto { get; set; }
        public string Region { get; set; }
        public int ContratoNumero { get; set; }
        public int PersonaNumero { get; set; }
        public string NumeroDocumentoBeneficiario { get; set; }
        public string NombresBeneficiario { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public bool AceptaBeneficio { get; set; }
        public string EnfermedadDiagnosticada { get; set; }
        public string TiempoDiagnostico { get; set; }
        public string MedicoCabecera { get; set; }
        public string MedicacionRequerida { get; set; }
        public bool? DisponeMedicacion { get; set; }
        public DateTime? FechaMaximaMedicacion { get; set; }
        public string HorarioContacto { get; set; }
        public string TipoBeneficio { get; set; }
        public string ProveedorMedicina { get; set; }
        public string ProveedorMedico { get; set; }
        public string MotivoRechazo { get; set; }
        public string OtrosMotivosRechazo { get; set; }
        public DateTime FechaEnrolamiento { get; set; }
        public string UsuarioEnrolamiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public bool Estado { get; set; }
        public DateTime? FechaEnrolamientoReal { get; set; }
        public string ObservacionEnrolamiento { get; set; }
        public bool? EsNuevoRegistro { get; set; }

        public ICollection<SeguimientoPrestadorSaludsaContigo> SeguimientoPrestadorSaludsaContigo { get; set; }
    }
}

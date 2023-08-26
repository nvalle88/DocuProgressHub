using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoordinaLlamada
    {
        public int Id { get; set; }
        public DateTime FechaProceso { get; set; }
        public int CodigoContrato { get; set; }
        public int NumeroPersonaBeneficiario { get; set; }
        public string NombreBeneficiario { get; set; }
        public string CodigoCiudad { get; set; }
        public string NombreCiudad { get; set; }
        public string Motivo { get; set; }
        public string TelefonoContacto { get; set; }
        public string CelularContacto { get; set; }
        public string CorreoCliente { get; set; }
        public long? NumeroTicketZendesk { get; set; }
        public string Estado { get; set; }
    }
}

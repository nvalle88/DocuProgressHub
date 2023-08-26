using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Queja
    {
        public int Id { get; set; }
        public int IdMotivoRequerimiento { get; set; }
        public DateTime FechaProceso { get; set; }
        public int CodigoContrato { get; set; }
        public int NumeroPersonaTitular { get; set; }
        public int NumeroPersonaBeneficiario { get; set; }
        public string NombreTitular { get; set; }
        public string NombreBeneficiario { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string TelefonoContacto { get; set; }
        public string Observacion { get; set; }
        public long NumeroTicketZendesk { get; set; }
        public string Estado { get; set; }
        public int? Calificacion { get; set; }
        public string CorreoCliente { get; set; }

        public MotivoRequerimiento IdMotivoRequerimientoNavigation { get; set; }
    }
}

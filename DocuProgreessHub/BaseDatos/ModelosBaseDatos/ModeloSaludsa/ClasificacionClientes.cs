using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ClasificacionClientes
    {
        public DateTime FechaCarga { get; set; }
        public string Categorizacion { get; set; }
        public string CodigoProducto { get; set; }
        public string Region { get; set; }
        public string NumeroDocumentoBeneficiario { get; set; }
        public int ContratoNumero { get; set; }
        public int PersonaNumero { get; set; }
        public string NombresBeneficiario { get; set; }
    }
}

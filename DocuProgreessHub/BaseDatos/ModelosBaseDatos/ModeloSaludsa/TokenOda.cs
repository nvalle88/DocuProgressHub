using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class TokenOda
    {
        public int IdTokenOda { get; set; }
        public string TokenNumero { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public DateTime? FechaValidacion { get; set; }
        public string UsuarioValidacion { get; set; }
        public int? NumeroPersonaTitular { get; set; }
        public int? NumeroPersonaBeneficiario { get; set; }
        public string NombreBeneficiario { get; set; }
        public int? CodigoContrato { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string Region { get; set; }
        public string Celular { get; set; }
        public int? NumeroContrato { get; set; }
        public int? CodigoOrdenAtencion { get; set; }
        public string PrestadorNombre { get; set; }
        public int? NumeroConvenio { get; set; }
        public int? IdPrestador { get; set; }
        public string Valor { get; set; }
        public bool? Validado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public int Estado { get; set; }
        public bool? Usado { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime? FechaUso { get; set; }
        public DateTime? FechaRevocacion { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PagoCitaMedica
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public string TransactionReference { get; set; }
        public string Token { get; set; }
        public string CurrencyCode { get; set; }
        public string ApprovalCode { get; set; }
        public string Recap { get; set; }
        public string MaskedCardNumber { get; set; }
        public string ApprovedTransactionAmount { get; set; }
        public string AcquirerBank { get; set; }
        public string Created { get; set; }
        public string TransactionStatus { get; set; }
        public string SyncMode { get; set; }
        public string MerchantId { get; set; }
        public string ProcessorType { get; set; }
        public string TransactionId { get; set; }
        public string ResponseText { get; set; }
        public string CardHolderName { get; set; }
        public string LastFourDigits { get; set; }
        public string BinCard { get; set; }
        public string PaymentBrand { get; set; }
        public string CardType { get; set; }
        public string MerchantName { get; set; }
        public string ProcessorName { get; set; }
        public string ProcessorBankName { get; set; }
        public string IssuingBank { get; set; }
        public string Country { get; set; }
        public int IdCitaSalud { get; set; }
        public string IdCitaCentroMedico { get; set; }
        public string SolicitudJson { get; set; }
        public string RespuestaJson { get; set; }
        public DateTime? FechaProceso { get; set; }
    }
}

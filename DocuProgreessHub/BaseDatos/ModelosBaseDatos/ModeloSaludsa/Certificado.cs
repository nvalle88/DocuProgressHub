using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Certificado
    {
        public Certificado()
        {
            InstruccionEntrega = new HashSet<InstruccionEntrega>();
        }

        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int TipoCertificado { get; set; }
        public bool? EstadoActivo { get; set; }
        public string ContenidoCertificado { get; set; }
        public long CodigoContrato { get; set; }
        public string NumeroDocumentoTitular { get; set; }
        public string TipoDocumentoTitular { get; set; }
        public string NombresTitular { get; set; }
        public string ApellidosTitular { get; set; }
        public string NumeroContrato { get; set; }
        public DateTime? FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public short? NivelCobertura { get; set; }
        public string Empresa { get; set; }
        public decimal? CoberturaMaxima { get; set; }
        public int TipoEntrega { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }

        public ICollection<InstruccionEntrega> InstruccionEntrega { get; set; }
    }
}

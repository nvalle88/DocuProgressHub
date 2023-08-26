using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class DatosReembolso
    {
        public DatosReembolso()
        {
            ArchivosReembolso = new HashSet<ArchivosReembolso>();
            CategoriasReembolso = new HashSet<CategoriasReembolso>();
        }

        public int ReembolsoId { get; set; }
        public string Secuencial { get; set; }
        public int CodigoContrato { get; set; }
        public string TelefonoCelular { get; set; }
        public string CorreoElectronico { get; set; }
        public decimal? ValorPresentado { get; set; }
        public string Diagnostico { get; set; }
        public string NotasAdicionales { get; set; }
        public bool? AceptoTerminos { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int? NumeroPersonaBeneficiario { get; set; }
        public DateTime? FechaExpiracion { get; set; }
        public string QueReembolsar { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string OrigenReembolso { get; set; }
        public bool? EsPacienteOncologico { get; set; }
        public bool? EsMedicinaContinua { get; set; }
        public bool? GastoCovid { get; set; }
        public bool? AplicaShift { get; set; }
        public bool? Maternidad { get; set; }
        public bool? CompletaReembolsoAnterior { get; set; }
        public bool? EsFacturaCompartidaOtroBeneficiario { get; set; }
        public bool? EsReembolsosGastosDireccionamientoDrSalud { get; set; }

        public ICollection<ArchivosReembolso> ArchivosReembolso { get; set; }
        public ICollection<CategoriasReembolso> CategoriasReembolso { get; set; }
    }
}

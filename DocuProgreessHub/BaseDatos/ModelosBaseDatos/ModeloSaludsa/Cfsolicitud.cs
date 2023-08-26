using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cfsolicitud
    {
        public Cfsolicitud()
        {
            Cfdiagnostico = new HashSet<Cfdiagnostico>();
            Cfingreso = new HashSet<Cfingreso>();
        }

        public int Id { get; set; }
        public decimal? ValorCopago { get; set; }
        public decimal? TotalFactura { get; set; }
        public long CodigoContrato { get; set; }
        public int NumeroContrato { get; set; }
        public string Region { get; set; }
        public string Producto { get; set; }
        public string CodigoPlan { get; set; }
        public short VersionPlan { get; set; }
        public int NumeroPersona { get; set; }
        public int NumeroConvenio { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Observacion { get; set; }
        public string CodigoCobertura { get; set; }
        public string NombrePaciente { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public int? Nivel { get; set; }

        public ICollection<Cfdiagnostico> Cfdiagnostico { get; set; }
        public ICollection<Cfingreso> Cfingreso { get; set; }
    }
}

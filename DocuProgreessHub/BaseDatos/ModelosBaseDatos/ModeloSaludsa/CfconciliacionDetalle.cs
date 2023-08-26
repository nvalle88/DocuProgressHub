using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CfconciliacionDetalle
    {
        public int Id { get; set; }
        public int IdConciliacionCredito { get; set; }
        public int IdCredito { get; set; }
        public int IdMedicamento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }
        public string DescripcionError { get; set; }
        public int? CargaMigracionVeris { get; set; }
        public int? SecuencialCargaVeris { get; set; }
        public int? SecuencialRegistroVeris { get; set; }
        public int? NumeroConvenio { get; set; }
        public int? CodigoErrorArmonix { get; set; }

        public CfconciliacionCredito IdConciliacionCreditoNavigation { get; set; }
    }
}

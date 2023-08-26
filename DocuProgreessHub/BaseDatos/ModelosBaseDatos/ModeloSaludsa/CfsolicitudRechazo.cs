using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CfsolicitudRechazo
    {
        public CfsolicitudRechazo()
        {
            CfdiagnosticoRechazo = new HashSet<CfdiagnosticoRechazo>();
            CfmedicamentoRechazo = new HashSet<CfmedicamentoRechazo>();
        }

        public int Id { get; set; }
        public long? CodigoContrato { get; set; }
        public int? NumeroContrato { get; set; }
        public string Region { get; set; }
        public string Producto { get; set; }
        public string CodigoPlan { get; set; }
        public short? VersionPlan { get; set; }
        public int? Nivel { get; set; }
        public int? NumeroPersona { get; set; }
        public string NombrePaciente { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public int NumeroConvenio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Observacion { get; set; }
        public int? IdSolicitud { get; set; }
        public bool? RechazoGeneral { get; set; }
        public string ReglaAplicada { get; set; }

        public ICollection<CfdiagnosticoRechazo> CfdiagnosticoRechazo { get; set; }
        public ICollection<CfmedicamentoRechazo> CfmedicamentoRechazo { get; set; }
    }
}

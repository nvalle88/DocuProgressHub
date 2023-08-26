using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class MotivoRequerimiento
    {
        public MotivoRequerimiento()
        {
            Queja = new HashSet<Queja>();
        }

        public int Id { get; set; }
        public string Motivo { get; set; }
        public int IdTipoRequerimiento { get; set; }
        public string Observacion { get; set; }
        public bool EstadoActivo { get; set; }
        public long IdCampoZendesk { get; set; }
        public string EtiquetaZendesk { get; set; }
        public int Orden { get; set; }

        public TipoRequerimiento IdTipoRequerimientoNavigation { get; set; }
        public ICollection<Queja> Queja { get; set; }
    }
}

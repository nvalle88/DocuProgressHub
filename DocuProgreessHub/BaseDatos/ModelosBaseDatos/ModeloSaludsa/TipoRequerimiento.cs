using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class TipoRequerimiento
    {
        public TipoRequerimiento()
        {
            MotivoRequerimiento = new HashSet<MotivoRequerimiento>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool EstadoActivo { get; set; }
        public long IdCampoZendesk { get; set; }
        public string EtiquetaZendesk { get; set; }
        public int Orden { get; set; }

        public ICollection<MotivoRequerimiento> MotivoRequerimiento { get; set; }
    }
}

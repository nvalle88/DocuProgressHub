using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cl03PersonasAdicional
    {
        public int IdPersona { get; set; }
        public int PersonaNumero { get; set; }
        public bool? ObservadoReembolso { get; set; }
        public string MotivoObsIngreso { get; set; }
        public string MotivoObsSalida { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}

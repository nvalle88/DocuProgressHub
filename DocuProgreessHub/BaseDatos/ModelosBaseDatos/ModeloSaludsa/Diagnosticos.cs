using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Diagnosticos
    {
        public int Id { get; set; }
        public string Cie10 { get; set; }
        public string DiagnosticoPrimario { get; set; }
        public int? Convenio { get; set; }
        public bool? EstadoActivo { get; set; }
    }
}

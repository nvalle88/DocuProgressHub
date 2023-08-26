using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class AutorizacionGesPacientes
    {
        public long Id { get; set; }
        public long CasoId { get; set; }
        public int NumeroAutorizacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long PrestadorCentroMedicoId { get; set; }
        public long PrestadorMedicoId { get; set; }
        public string Usuario { get; set; }

        public Caso Caso { get; set; }
        public PrestadorGesPacientes PrestadorCentroMedico { get; set; }
        public PrestadorGesPacientes PrestadorMedico { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PrestadorGesPacientes
    {
        public PrestadorGesPacientes()
        {
            AutorizacionGesPacientesPrestadorCentroMedico = new HashSet<AutorizacionGesPacientes>();
            AutorizacionGesPacientesPrestadorMedico = new HashSet<AutorizacionGesPacientes>();
        }

        public long Id { get; set; }
        public int NumeroConvenio { get; set; }

        public ICollection<AutorizacionGesPacientes> AutorizacionGesPacientesPrestadorCentroMedico { get; set; }
        public ICollection<AutorizacionGesPacientes> AutorizacionGesPacientesPrestadorMedico { get; set; }
    }
}

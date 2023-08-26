using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CferrorConciliacionMi02CausasNoMigrar
    {
        public int IdCferrorConciliacion { get; set; }
        public int CodigoCausaProgress { get; set; }
        public string Motivo { get; set; }
        public bool NotificarPrestador { get; set; }
        public bool NotificarAuditorSalud { get; set; }
        public string Mensaje { get; set; }
        public bool Estado { get; set; }

        public CferrorConciliacion IdCferrorConciliacionNavigation { get; set; }
    }
}

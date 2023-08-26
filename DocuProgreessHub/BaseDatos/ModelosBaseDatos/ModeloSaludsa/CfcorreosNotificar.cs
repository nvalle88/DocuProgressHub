using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CfcorreosNotificar
    {
        public int Id { get; set; }
        public int NumeroConvenio { get; set; }
        public string NombrePrestador { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public bool EsAuditorSalud { get; set; }
        public bool Activo { get; set; }
    }
}

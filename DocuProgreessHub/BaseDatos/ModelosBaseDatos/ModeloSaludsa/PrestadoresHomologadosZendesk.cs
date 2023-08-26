using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PrestadoresHomologadosZendesk
    {
        public int Id { get; set; }
        public int NumeroConvenio { get; set; }
        public string NombrePrestador { get; set; }
        public string NombreComercialPrestador { get; set; }
        public string NombrePrestadorZendesk { get; set; }
        public int IdCiudad { get; set; }
        public string Region { get; set; }
        public bool Activo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ArchivosReembolso
    {
        public int ArchivoId { get; set; }
        public int ReembolsoId { get; set; }
        public string TipoDocumento { get; set; }
        public string UrlAzureStorage { get; set; }
        public string Metadata { get; set; }

        public DatosReembolso Reembolso { get; set; }
    }
}

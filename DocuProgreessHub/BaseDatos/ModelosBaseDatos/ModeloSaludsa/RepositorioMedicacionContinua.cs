using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class RepositorioMedicacionContinua
    {
        public int Id { get; set; }
        public string CodigoRegion { get; set; }
        public string CodigoProducto { get; set; }
        public int NumeroContrato { get; set; }
        public int NumeroPersona { get; set; }
        public string CodigoDiagnostico { get; set; }
        public int CodigoMedicamento { get; set; }
        public int? CodigoContrato { get; set; }
        public string NumeroSobreMedicacionContinua { get; set; }
        public string Url { get; set; }
        public string NombreArchivo { get; set; }
        public int? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string NombreArchivoOriginal { get; set; }
    }
}

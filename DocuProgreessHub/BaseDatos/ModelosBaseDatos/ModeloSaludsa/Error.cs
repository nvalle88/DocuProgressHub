using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Error
    {
        public int Id { get; set; }
        public int ContratoId { get; set; }
        public int BeneficiarioCodigo { get; set; }
        public string BeneficiarioCedula { get; set; }
        public string BeneficiarioNombre { get; set; }
        public int BeneficiarioEdad { get; set; }
        public string ErrorTipo { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public int ResumenId { get; set; }

        public Resumen Resumen { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Gap
    {
        public int Id { get; set; }
        public int ContratoId { get; set; }
        public string BeneficiarioCedula { get; set; }
        public string BeneficiarioNombre { get; set; }
        public int BeneficiarioEdad { get; set; }
        public float MontoCobertura { get; set; }
        public float Pvp { get; set; }
        public float ValorTarifado { get; set; }
        public string Tipo { get; set; }
        public int ResumenId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public Resumen Resumen { get; set; }
    }
}

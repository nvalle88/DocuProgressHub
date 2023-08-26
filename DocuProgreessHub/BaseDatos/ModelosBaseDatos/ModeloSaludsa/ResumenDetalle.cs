using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ResumenDetalle
    {
        public int Id { get; set; }
        public string CodigoRegionSigmep { get; set; }
        public string CodigoProductoSigmep { get; set; }
        public int? ContratoId { get; set; }
        public DateTime? ContratoFechaDigitacion { get; set; }
        public DateTime? ContratoFechaInicio { get; set; }
        public DateTime? ContratoFechaFin { get; set; }
        public int? TitularCodigo { get; set; }
        public string TitularCedula { get; set; }
        public string TitularNombre { get; set; }
        public string TitularApellido { get; set; }
        public double? ValorPvp { get; set; }
        public int? BeneficiarioCodigo { get; set; }
        public bool? EsTitular { get; set; }
        public string BeneficiarioCedula { get; set; }
        public string BeneficiarioNombre { get; set; }
        public string BeneficiarioApellido { get; set; }
        public DateTime? BeneficiarioFechaNacimiento { get; set; }
        public int? BeneficiarioEdad { get; set; }
        public DateTime? BeneficiarioFechaDigitacion { get; set; }
        public DateTime? BeneficiarioFechaInclusion { get; set; }
        public DateTime? BeneficiarioFechaExclusion { get; set; }
        public int? CodigoRelacionSigmep { get; set; }
        public string CodigoCategoriaSigmep { get; set; }
        public string CodigoServicioSigmep { get; set; }
        public DateTime? ServicioFechaInicio { get; set; }
        public DateTime? ServicioFechaFin { get; set; }
        public double? MontoCobertura { get; set; }
        public double? TarifaCalculada { get; set; }
        public double? Tasa { get; set; }
        public double? ValorCuota { get; set; }
        public int CriterioId { get; set; }
        public int ResumenId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public Resumen Resumen { get; set; }
    }
}

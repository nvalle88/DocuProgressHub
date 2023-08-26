using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Movimiento
    {
        public int Id { get; set; }
        public string CodigoRegionSigmep { get; set; }
        public string CodigoProductoSigmep { get; set; }
        public int ContratoId { get; set; }
        public int MovimientoNumero { get; set; }
        public int MovimientoTransaccion { get; set; }
        public int BeneficiarioCodigo { get; set; }
        public string BeneficiarioCedula { get; set; }
        public string BeneficiarioNombre { get; set; }
        public int BeneficiarioEdad { get; set; }
        public string CodigoServicioSigmep { get; set; }
        public string MovimientoDatoAnterior { get; set; }
        public DateTime MovimientoFecha { get; set; }
        public DateTime MovimientoFechaEfecto { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public int ResumenId { get; set; }

        public Resumen Resumen { get; set; }
    }
}

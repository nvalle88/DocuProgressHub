using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class MasivoMovimiento
    {
        public int Id { get; set; }
        public string CodigoRegionSigmep { get; set; }
        public string CodigoProductoSigmep { get; set; }
        public int ContratoId { get; set; }
        public int MovimientoNumero { get; set; }
        public int MovimientoTransaccion { get; set; }
        public int BeneficiarioCodigo { get; set; }
        public string CodigoServicioSigmep { get; set; }
        public string MovimientoDatoAnterior { get; set; }
        public DateTime MovimientoFecha { get; set; }
        public DateTime MovimientoFechaEfecto { get; set; }
    }
}

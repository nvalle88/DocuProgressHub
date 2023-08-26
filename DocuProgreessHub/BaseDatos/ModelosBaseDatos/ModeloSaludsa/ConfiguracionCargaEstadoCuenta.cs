using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ConfiguracionCargaEstadoCuenta
    {
        public int CodigoBanco { get; set; }
        public bool? TieneCabeceras { get; set; }
        public string FormatoArchivo { get; set; }
        public string SeparadorColumnas { get; set; }
        public string CaracteresAeliminar { get; set; }
        public string SeparadorDecimales { get; set; }
        public string SeparadorMiles { get; set; }
        public int? PosicionFecha { get; set; }
        public int? PosicionDocumento { get; set; }
        public int? PosicionSaldo { get; set; }
        public int? PosicionCodigo { get; set; }
        public int? PosicionConcepto { get; set; }
        public int? PosicionTipo { get; set; }
        public int? PosicionMonto { get; set; }
        public string IdentificadorCredito { get; set; }
    }
}

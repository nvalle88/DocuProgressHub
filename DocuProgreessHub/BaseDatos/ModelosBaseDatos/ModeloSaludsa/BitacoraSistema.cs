using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class BitacoraSistema
    {
        public long IdBitacoraSistema { get; set; }
        public long Identificador { get; set; }
        public DateTime FechaHora { get; set; }
        public short CodigoAplicacion { get; set; }
        public short CodigoPlataforma { get; set; }
        public string DispositivoNavegador { get; set; }
        public string SistemaOperativo { get; set; }
        public string DireccionIp { get; set; }
        public bool EsEntrada { get; set; }
        public long NumeroProceso { get; set; }
        public string Verbo { get; set; }
        public string UriRequimiento { get; set; }
        public string Api { get; set; }
        public string Autorizacion { get; set; }
        public string Cabecera { get; set; }
        public string Parametros { get; set; }
        public string Cuerpo { get; set; }
        public string Metodo { get; set; }
        public string NombreEnsamblado { get; set; }
        public string VersionEnsamblado { get; set; }
        public string Excepcion { get; set; }
    }
}

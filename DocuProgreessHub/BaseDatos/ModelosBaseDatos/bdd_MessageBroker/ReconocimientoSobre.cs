using System;
using System.Collections.Generic;

namespace SmartAdmin.Seed.BaseDatos.ModelosBaseDatos.bdd_MessageBroker
{
    public partial class ReconocimientoSobre
    {
        public int Id { get; set; }
        public int IdSobre { get; set; }
        public DateTime? FechaReconocimiento { get; set; }
        public string RespuestaReconocimiento { get; set; }
        public string FechaEnvioRepositorio { get; set; }
        public string RespuestaRepositorio { get; set; }
        public string FechaEnvioLiquidacion { get; set; }
        public string RespuestaLiquidacion { get; set; }

        public Sobre IdSobreNavigation { get; set; }
    }
}

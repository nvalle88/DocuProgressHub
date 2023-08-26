using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CanalesServicios
    {
        public int Codigo { get; set; }
        public int CodigoServicio { get; set; }
        public int CodigoCanal { get; set; }
        public bool? EsEstrella { get; set; }
    }
}

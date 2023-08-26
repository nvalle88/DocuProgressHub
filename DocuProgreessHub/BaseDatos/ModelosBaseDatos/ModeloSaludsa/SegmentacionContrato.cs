using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class SegmentacionContrato
    {
        public string CodigoProducto { get; set; }
        public string Region { get; set; }
        public int NumeroContrato { get; set; }
        public bool? EstadoActivo { get; set; }
    }
}

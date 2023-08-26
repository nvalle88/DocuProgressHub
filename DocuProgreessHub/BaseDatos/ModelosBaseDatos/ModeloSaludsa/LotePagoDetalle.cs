using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class LotePagoDetalle
    {
        public int LotePagoId { get; set; }
        public int ReclamoId { get; set; }
        public decimal MontoSaludsa { get; set; }
        public bool EstadoPagado { get; set; }

        public LotePago LotePago { get; set; }
    }
}

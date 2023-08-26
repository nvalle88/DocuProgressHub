using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ValoresFee
    {
        public string CodigoProducto { get; set; }
        public int NumeroConvenio { get; set; }
        public bool ValorFee { get; set; }
        public bool EstadoActivo { get; set; }
    }
}

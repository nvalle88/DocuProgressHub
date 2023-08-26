using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cfregla
    {
        public int NumeroConvenio { get; set; }
        public string IdProducto { get; set; }
        public string NombreRegla { get; set; }
        public bool Activo { get; set; }

        public Cfproducto IdProductoNavigation { get; set; }
    }
}

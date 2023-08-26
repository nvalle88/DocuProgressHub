using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CfmedicinaPrestadorProducto
    {
        public string CodigoMedicinaPrestador { get; set; }
        public int NumeroConvenio { get; set; }
        public string CodigoMedicinaSaludsa { get; set; }
        public string IdProducto { get; set; }
        public int PorcientoCobertura { get; set; }
        public bool Activo { get; set; }

        public Cfprestador Cfprestador { get; set; }
        public Cfmedicina CodigoMedicinaSaludsaNavigation { get; set; }
        public Cfproducto IdProductoNavigation { get; set; }
    }
}

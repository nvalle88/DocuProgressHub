using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CredMedNpmedicinaPrestadorProducto
    {
        public string CodigoMedicinaPrestador { get; set; }
        public int NumeroConvenio { get; set; }
        public string CodigoMedicinaSaludsa { get; set; }
        public string IdProducto { get; set; }
        public int PorcientoCobertura { get; set; }
        public bool Activo { get; set; }

        public CredMedNpmedicina CodigoMedicinaSaludsaNavigation { get; set; }
        public CredMedNpprestador CredMedNpprestador { get; set; }
        public CreditoMedNpproducto IdProductoNavigation { get; set; }
    }
}

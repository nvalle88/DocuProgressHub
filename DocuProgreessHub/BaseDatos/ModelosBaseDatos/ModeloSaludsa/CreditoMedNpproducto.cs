using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CreditoMedNpproducto
    {
        public CreditoMedNpproducto()
        {
            CredMedNpmedicinaPrestadorProducto = new HashSet<CredMedNpmedicinaPrestadorProducto>();
        }

        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string IdProducto { get; set; }
        public bool Activo { get; set; }

        public ICollection<CredMedNpmedicinaPrestadorProducto> CredMedNpmedicinaPrestadorProducto { get; set; }
    }
}

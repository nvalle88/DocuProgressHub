using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CredMedNpmedicina
    {
        public CredMedNpmedicina()
        {
            CredMedNpmedicinaPrestadorProducto = new HashSet<CredMedNpmedicinaPrestadorProducto>();
        }

        public string CodigoMedicinaSaludsa { get; set; }
        public string Descripcion { get; set; }
        public string PrincipioActivo { get; set; }
        public string TipoProducto { get; set; }
        public string TipoTratamiento { get; set; }
        public bool EsContinuo { get; set; }
        public bool Activo { get; set; }

        public ICollection<CredMedNpmedicinaPrestadorProducto> CredMedNpmedicinaPrestadorProducto { get; set; }
    }
}

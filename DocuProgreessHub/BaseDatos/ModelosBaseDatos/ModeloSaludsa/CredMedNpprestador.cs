using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CredMedNpprestador
    {
        public CredMedNpprestador()
        {
            CredMedNpmedicinaPrestadorProducto = new HashSet<CredMedNpmedicinaPrestadorProducto>();
        }

        public string CodigoMedicinaPrestador { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public int NumeroConvenio { get; set; }
        public bool Activo { get; set; }

        public ICollection<CredMedNpmedicinaPrestadorProducto> CredMedNpmedicinaPrestadorProducto { get; set; }
    }
}

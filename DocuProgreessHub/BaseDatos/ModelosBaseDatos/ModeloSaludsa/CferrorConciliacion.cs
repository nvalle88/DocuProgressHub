using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CferrorConciliacion
    {
        public CferrorConciliacion()
        {
            CferrorConciliacionMi02CausasNoMigrar = new HashSet<CferrorConciliacionMi02CausasNoMigrar>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool TieneReproceso { get; set; }
        public bool Estado { get; set; }

        public ICollection<CferrorConciliacionMi02CausasNoMigrar> CferrorConciliacionMi02CausasNoMigrar { get; set; }
    }
}

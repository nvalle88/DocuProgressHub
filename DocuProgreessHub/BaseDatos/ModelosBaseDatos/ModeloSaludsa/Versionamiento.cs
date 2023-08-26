using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Versionamiento
    {
        public Versionamiento()
        {
            VersionamientoOnBoarding = new HashSet<VersionamientoOnBoarding>();
        }

        public int Id { get; set; }
        public string Version { get; set; }
        public string Plataforma { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaDespliegue { get; set; }

        public ICollection<VersionamientoOnBoarding> VersionamientoOnBoarding { get; set; }
    }
}

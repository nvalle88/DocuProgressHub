using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Procedimiento
    {
        public Procedimiento()
        {
            CiudadPrestadorProcedimiento = new HashSet<CiudadPrestadorProcedimiento>();
        }

        public int IdProcedimiento { get; set; }
        public string Nombre { get; set; }
        public bool EstadoActivo { get; set; }
        public string CampoBusqueda { get; set; }

        public ICollection<CiudadPrestadorProcedimiento> CiudadPrestadorProcedimiento { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Ciudad1
    {
        public Ciudad1()
        {
            CiudadPrestadorProcedimiento = new HashSet<CiudadPrestadorProcedimiento>();
        }

        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
        public bool EstadoActivo { get; set; }

        public ICollection<CiudadPrestadorProcedimiento> CiudadPrestadorProcedimiento { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Prestador1
    {
        public Prestador1()
        {
            CiudadPrestadorProcedimiento = new HashSet<CiudadPrestadorProcedimiento>();
        }

        public int NumeroConvenio { get; set; }
        public string NombreComercial { get; set; }
        public string Mensaje { get; set; }
        public string Telefono { get; set; }
        public bool EstadoActivo { get; set; }
        public int? OrdenNumero { get; set; }

        public ICollection<CiudadPrestadorProcedimiento> CiudadPrestadorProcedimiento { get; set; }
    }
}

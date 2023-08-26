using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ContabilizacionCitasMedicas
    {
        public int Id { get; set; }
        public DateTime FechaProceso { get; set; }
        public int IdCiudad { get; set; }
        public string NombreCorto { get; set; }
        public string CodigoAlphaEspecialidad { get; set; }
        public DateTime? FechaCita { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string CodigoSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string NombreMedico { get; set; }
        public string NombreCiudad { get; set; }
        public string NombreEspecialidad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string IdentificadorProceso { get; set; }

        public ConfParametrosConsultas ConfParametrosConsultas { get; set; }
    }
}

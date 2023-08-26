using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ConfParametrosConsultas
    {
        public ConfParametrosConsultas()
        {
            ContabilizacionCitasMedicas = new HashSet<ContabilizacionCitasMedicas>();
        }

        public int IdCiudad { get; set; }
        public string NombreCorto { get; set; }
        public string CodigoAlphaEspecialidad { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int DiaInicio { get; set; }
        public int DiasConsulta { get; set; }
        public bool Estado { get; set; }

        public ConfCentrosMedicos NombreCortoNavigation { get; set; }
        public ICollection<ContabilizacionCitasMedicas> ContabilizacionCitasMedicas { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PersonaAdicional
    {
        public int IdPersonaAdicional { get; set; }
        public int PersonaNumero { get; set; }
        public string CanalContacto { get; set; }
        public bool ActualizoDatosPersonales { get; set; }
        public bool ActualizoDatosBancarios { get; set; }
        public DateTime? FechaActualizacionDatosBancarios { get; set; }
        public DateTime? FechaActualizacionDatosPersonales { get; set; }
    }
}

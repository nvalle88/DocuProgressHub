﻿using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class DatosVentaDigital
    {
        public int Id { get; set; }
        public string NumeroDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Genero { get; set; }
        public string FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public DateTime? FechaTransaccion { get; set; }
        public string DatosAdicionales { get; set; }
    }
}

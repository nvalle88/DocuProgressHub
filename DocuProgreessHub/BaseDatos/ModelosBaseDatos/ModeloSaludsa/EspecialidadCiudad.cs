using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class EspecialidadCiudad
    {
        public int Id { get; set; }
        public short EspecialidadId { get; set; }
        public short CiudadId { get; set; }
        public int PrestadorId { get; set; }
        public bool? EstadoActivo { get; set; }

        public Ciudad Ciudad { get; set; }
        public EspecialidadMedica Especialidad { get; set; }
        public Prestador Prestador { get; set; }
    }
}

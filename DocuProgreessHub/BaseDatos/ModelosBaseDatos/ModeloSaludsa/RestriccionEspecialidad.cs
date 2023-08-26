using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class RestriccionEspecialidad
    {
        public byte Id { get; set; }
        public short EspecialidadId { get; set; }
        public bool? Genero { get; set; }
        public byte EdadDesde { get; set; }
        public byte EdadHasta { get; set; }
        public string Descripcion { get; set; }

        public EspecialidadMedica Especialidad { get; set; }
    }
}

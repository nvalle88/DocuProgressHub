using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class SubespecialidadMedica
    {
        public short Id { get; set; }
        public short EspecialidadMedicaId { get; set; }
        public string CodigoAlfa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public EspecialidadMedica EspecialidadMedica { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class EspecialidadMedica
    {
        public EspecialidadMedica()
        {
            EspecialidadCiudad = new HashSet<EspecialidadCiudad>();
            SubespecialidadMedica = new HashSet<SubespecialidadMedica>();
        }

        public short Id { get; set; }
        public string CodigoAlfa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }

        public RestriccionEspecialidad RestriccionEspecialidad { get; set; }
        public ICollection<EspecialidadCiudad> EspecialidadCiudad { get; set; }
        public ICollection<SubespecialidadMedica> SubespecialidadMedica { get; set; }
    }
}

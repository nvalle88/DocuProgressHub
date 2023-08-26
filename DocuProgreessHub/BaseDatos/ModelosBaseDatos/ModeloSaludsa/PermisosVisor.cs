using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PermisosVisor
    {
        public string GrupoDirectorioActivo { get; set; }
        public string UsuarioMfile { get; set; }
        public bool PuedeDescargar { get; set; }
        public bool PuedeVisualizar { get; set; }
    }
}

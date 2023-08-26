using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class RolFuncionalidad
    {
        public Guid Id { get; set; }
        public Guid RolId { get; set; }
        public Guid FuncionalidadId { get; set; }

        public Funcionalidad Funcionalidad { get; set; }
        public Rol Rol { get; set; }
    }
}

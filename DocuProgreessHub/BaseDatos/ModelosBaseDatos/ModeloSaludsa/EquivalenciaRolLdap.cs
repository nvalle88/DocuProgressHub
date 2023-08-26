using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class EquivalenciaRolLdap
    {
        public Guid Id { get; set; }
        public Guid RolId { get; set; }
        public string NombreGrupoLdap { get; set; }

        public Rol Rol { get; set; }
    }
}

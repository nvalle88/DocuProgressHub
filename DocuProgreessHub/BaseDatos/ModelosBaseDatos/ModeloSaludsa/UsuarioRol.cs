using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class UsuarioRol
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid RolId { get; set; }

        public Rol Rol { get; set; }
        public Usuario Usuario { get; set; }
    }
}

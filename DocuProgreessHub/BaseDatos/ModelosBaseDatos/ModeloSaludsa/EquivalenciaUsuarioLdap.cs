using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class EquivalenciaUsuarioLdap
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public string NombreUsuarioLdap { get; set; }

        public Usuario Usuario { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class PrestadorUsuario
    {
        public Guid Id { get; set; }
        public int PrestadorId { get; set; }
        public Guid UsuarioId { get; set; }

        public Prestador Prestador { get; set; }
        public Usuario Usuario { get; set; }
    }
}

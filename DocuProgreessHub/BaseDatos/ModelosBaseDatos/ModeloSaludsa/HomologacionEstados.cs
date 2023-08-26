using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class HomologacionEstados
    {
        public string EstadoZendesk { get; set; }
        public string EstadoCliente { get; set; }
        public string Comentario { get; set; }
        public bool Activo { get; set; }
    }
}

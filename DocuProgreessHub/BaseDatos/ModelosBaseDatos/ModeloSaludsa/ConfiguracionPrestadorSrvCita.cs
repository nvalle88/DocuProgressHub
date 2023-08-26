using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ConfiguracionPrestadorSrvCita
    {
        public int Id { get; set; }
        public int PrestadorId { get; set; }
        public byte TipoServicioId { get; set; }
        public string Urlbase { get; set; }
        public byte TipoAutId { get; set; }
        public string Urlaut { get; set; }
        public string Token { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public bool? EstadoActivo { get; set; }

        public Prestador Prestador { get; set; }
    }
}

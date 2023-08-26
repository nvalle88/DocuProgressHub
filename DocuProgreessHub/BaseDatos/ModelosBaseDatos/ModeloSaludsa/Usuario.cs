using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Usuario
    {
        public Usuario()
        {
            EquivalenciaUsuarioLdap = new HashSet<EquivalenciaUsuarioLdap>();
            LotePago = new HashSet<LotePago>();
            PrestadorUsuario = new HashSet<PrestadorUsuario>();
            UsuarioRol = new HashSet<UsuarioRol>();
        }

        public Guid Id { get; set; }
        public long PersonaId { get; set; }
        public long EntidadRelacionadaId { get; set; }
        public string NombreUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Bloqueado { get; set; }
        public DateTimeOffset? FinBloqueo { get; set; }
        public string Telefono { get; set; }
        public bool EstadoActivo { get; set; }
        public byte[] Contrasena { get; set; }
        public int Incertidumbre { get; set; }
        public bool ForzarCambioContrasena { get; set; }
        public int? IdCiudad { get; set; }

        public Entidad EntidadRelacionada { get; set; }
        public Persona Persona { get; set; }
        public ICollection<EquivalenciaUsuarioLdap> EquivalenciaUsuarioLdap { get; set; }
        public ICollection<LotePago> LotePago { get; set; }
        public ICollection<PrestadorUsuario> PrestadorUsuario { get; set; }
        public ICollection<UsuarioRol> UsuarioRol { get; set; }
    }
}

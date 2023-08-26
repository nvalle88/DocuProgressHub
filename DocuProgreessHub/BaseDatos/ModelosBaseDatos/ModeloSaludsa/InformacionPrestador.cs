using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class InformacionPrestador
    {
        public InformacionPrestador()
        {
            TipoPrestadorCiudadPrestador = new HashSet<TipoPrestadorCiudadPrestador>();
        }

        public int IdInformacionPrestador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Online { get; set; }
        public string UrlBaseServicio { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public bool EstadoActivo { get; set; }
        public byte[] TokenAutenticacion { get; set; }
        public bool? AutenticacionUsuarioContrasena { get; set; }

        public ICollection<TipoPrestadorCiudadPrestador> TipoPrestadorCiudadPrestador { get; set; }
    }
}

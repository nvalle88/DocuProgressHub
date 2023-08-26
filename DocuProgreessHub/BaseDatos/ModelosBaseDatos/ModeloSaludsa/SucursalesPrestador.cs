using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class SucursalesPrestador
    {
        public int? IdTipoPrestadorCiudadPrestador { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Sector { get; set; }
        public string CertificadosPremios { get; set; }
        public string AniosExistencias { get; set; }
        public string Ubicacion { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string TieneParqueo { get; set; }
        public string HorarioAtencion { get; set; }
        public string NumeroContacto { get; set; }
        public int IdSucursalPrestador { get; set; }
        public bool? EstadoActivo { get; set; }

        public TipoPrestadorCiudadPrestador IdTipoPrestadorCiudadPrestadorNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Organizacion
    {
        public long Id { get; set; }
        public long EntidadId { get; set; }
        public short NacionalidadId { get; set; }
        public byte TipoIdentificacionId { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Observacion { get; set; }
        public string ImagenPath { get; set; }
        public string NotaConfirmacionCita { get; set; }
        public decimal? Descuento { get; set; }
        public DateTime? FechaInicioDescuento { get; set; }
        public DateTime? FechaFinDescuento { get; set; }

        public Entidad Entidad { get; set; }
        public Pais Nacionalidad { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }
    }
}

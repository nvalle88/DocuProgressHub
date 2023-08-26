using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CalificacionAplicacion
    {
        public int Id { get; set; }
        public byte CodigoAplicacion { get; set; }
        public byte CodigoPlataforma { get; set; }
        public string Comentario { get; set; }
        public string NumeroDocumento { get; set; }
        public byte Valor { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
    }
}

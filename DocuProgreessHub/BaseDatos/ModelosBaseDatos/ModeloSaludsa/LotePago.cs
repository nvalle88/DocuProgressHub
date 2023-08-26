using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class LotePago
    {
        public LotePago()
        {
            LotePagoDetalle = new HashSet<LotePagoDetalle>();
            LotePagoFacturas = new HashSet<LotePagoFacturas>();
        }

        public int Id { get; set; }
        public DateTime FechaEmision { get; set; }
        public int NumeroConvenioPrestador { get; set; }
        public Guid UsuarioGeneradorId { get; set; }

        public Usuario UsuarioGenerador { get; set; }
        public ICollection<LotePagoDetalle> LotePagoDetalle { get; set; }
        public ICollection<LotePagoFacturas> LotePagoFacturas { get; set; }
    }
}

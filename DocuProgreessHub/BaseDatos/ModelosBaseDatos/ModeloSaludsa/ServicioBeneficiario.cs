using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ServicioBeneficiario
    {
        public int Id { get; set; }
        public int BeneficiarioServicioId { get; set; }
        public int ServicioAdicionalId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public Beneficiario BeneficiarioServicio { get; set; }
        public Servicio ServicioAdicional { get; set; }
    }
}

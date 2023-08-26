using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Poliza = new HashSet<Poliza>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PersonaContacto { get; set; }
        public string CorreoElectronicoContacto { get; set; }
        public DateTime FechaConvenio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }

        public ICollection<Poliza> Poliza { get; set; }
    }
}

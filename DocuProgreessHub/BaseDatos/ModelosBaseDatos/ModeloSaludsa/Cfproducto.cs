using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cfproducto
    {
        public Cfproducto()
        {
            CfmedicinaPrestadorProducto = new HashSet<CfmedicinaPrestadorProducto>();
            Cfregla = new HashSet<Cfregla>();
        }

        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string IdProducto { get; set; }
        public bool EsNuevoPlan { get; set; }
        public bool Activo { get; set; }

        public ICollection<CfmedicinaPrestadorProducto> CfmedicinaPrestadorProducto { get; set; }
        public ICollection<Cfregla> Cfregla { get; set; }
    }
}

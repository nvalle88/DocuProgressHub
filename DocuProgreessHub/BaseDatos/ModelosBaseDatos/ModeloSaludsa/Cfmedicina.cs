using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Cfmedicina
    {
        public Cfmedicina()
        {
            CfmedicinaPrestadorProducto = new HashSet<CfmedicinaPrestadorProducto>();
        }

        public string CodigoMedicinaSaludsa { get; set; }
        public string Descripcion { get; set; }
        public string PrincipioActivo { get; set; }
        public string TipoProducto { get; set; }
        public string TipoTratamiento { get; set; }
        public bool EsContinuo { get; set; }
        public bool Activo { get; set; }
        public string CodigoBeneficio { get; set; }
        public string CodigoBeneficioNuevosPlanes { get; set; }
        public int? CodigoProcedimiento { get; set; }
        public int? CodigoProcedimientoNuevosPlanes { get; set; }

        public ICollection<CfmedicinaPrestadorProducto> CfmedicinaPrestadorProducto { get; set; }
    }
}

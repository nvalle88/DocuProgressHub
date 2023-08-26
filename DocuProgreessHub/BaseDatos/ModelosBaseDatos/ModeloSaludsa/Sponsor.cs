using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Sponsor
    {
        public string NombreSponsor { get; set; }
        public string TipoPlanSponsor { get; set; }
        public string CodigoProductoSaludsa { get; set; }
        public string CodigoPlanSaludsa { get; set; }
        public bool EsPlanFamiliar { get; set; }
        public string NombrePlan { get; set; }
        public string IdPlantillaAgendamiento { get; set; }
    }
}

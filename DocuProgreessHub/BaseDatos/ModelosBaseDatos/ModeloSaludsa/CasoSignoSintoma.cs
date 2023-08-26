using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CasoSignoSintoma
    {
        public long Id { get; set; }
        public long CasoId { get; set; }
        public int SignoSintomaId { get; set; }

        public Caso Caso { get; set; }
        public ItemCatalogo SignoSintoma { get; set; }
    }
}

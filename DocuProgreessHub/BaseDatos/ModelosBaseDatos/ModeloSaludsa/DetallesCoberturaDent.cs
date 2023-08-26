using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class DetallesCoberturaDent
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public int? IdCoberturas { get; set; }

        public CoberturasDent IdCoberturasNavigation { get; set; }
    }
}

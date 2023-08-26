using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturasDent
    {
        public CoberturasDent()
        {
            DetallesCoberturaDent = new HashSet<DetallesCoberturaDent>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public int? IdCoberturaDental { get; set; }

        public CoberturaDental IdCoberturaDentalNavigation { get; set; }
        public ICollection<DetallesCoberturaDent> DetallesCoberturaDent { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CoberturaNacIntTipoCobertura
    {
        public CoberturaNacIntTipoCobertura()
        {
            ListaCoberturasNacInt = new HashSet<ListaCoberturasNacInt>();
        }

        public int Id { get; set; }
        public int? IdCoberturaNacInt { get; set; }
        public int? IdTipoCobertura { get; set; }
        public string SubTipo { get; set; }

        public CoberturaNacInt IdCoberturaNacIntNavigation { get; set; }
        public TipoCoberturaNacInt IdTipoCoberturaNavigation { get; set; }
        public ICollection<ListaCoberturasNacInt> ListaCoberturasNacInt { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class TipoCoberturaNacInt
    {
        public TipoCoberturaNacInt()
        {
            CoberturaNacIntTipoCobertura = new HashSet<CoberturaNacIntTipoCobertura>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        public ICollection<CoberturaNacIntTipoCobertura> CoberturaNacIntTipoCobertura { get; set; }
    }
}

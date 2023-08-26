using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ListaCoberturasNacInt
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public int? IdCoberturaNacIntTipoCobertura { get; set; }
        public string Icono { get; set; }

        public CoberturaNacIntTipoCobertura IdCoberturaNacIntTipoCoberturaNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartAdmin.Seed.BaseDatos.ModelosBaseDatos.bdd_MessageBroker
{
    public partial class EncuestaSobre
    {
        public int Id { get; set; }
        public int IdSobre { get; set; }
        public string Estado { get; set; }
        public string CalificacionEncuesta { get; set; }
        public int? IdTicketZendesk { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Sobre IdSobreNavigation { get; set; }
    }
}

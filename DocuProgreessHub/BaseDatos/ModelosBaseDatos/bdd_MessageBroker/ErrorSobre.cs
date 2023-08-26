using System;
using System.Collections.Generic;

namespace SmartAdmin.Seed.BaseDatos.ModelosBaseDatos.bdd_MessageBroker
{
    public partial class ErrorSobre
    {
        public int Id { get; set; }
        public int IdSobre { get; set; }
        public string ColaPublicacion { get; set; }
        public string MensajeError { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SmartAdmin.Seed.BaseDatos.ModelosBaseDatos.bdd_MessageBroker
{
    public partial class Log
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public string PlantillaMensaje { get; set; }
        public string Severidad { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Excepcion { get; set; }
        public string Propiedades { get; set; }
        public bool? ErrorControlado { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class MensajeError
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string MensajeInterno { get; set; }
        public string MensajeExterno { get; set; }
        public int TotalParametros { get; set; }
    }
}

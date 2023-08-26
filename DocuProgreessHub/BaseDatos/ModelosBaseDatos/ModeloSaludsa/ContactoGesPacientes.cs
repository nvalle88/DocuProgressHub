using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ContactoGesPacientes
    {
        public long Id { get; set; }
        public string PersonaQueLlamo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public long CasoId { get; set; }

        public Caso Caso { get; set; }
    }
}

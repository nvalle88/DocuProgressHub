using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CorreosPrestador
    {
        public int Id { get; set; }
        public int IdPrestador { get; set; }
        public string CorreoPrestador { get; set; }
    }
}

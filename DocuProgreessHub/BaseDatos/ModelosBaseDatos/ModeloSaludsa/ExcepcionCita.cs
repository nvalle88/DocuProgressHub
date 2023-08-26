using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ExcepcionCita
    {
        public long Id { get; set; }
        public long IdCitaOrigen { get; set; }
        public long IdNuevaCita { get; set; }
        public int CodigoExcepcion { get; set; }
        public int MotivoExcepcion { get; set; }
    }
}

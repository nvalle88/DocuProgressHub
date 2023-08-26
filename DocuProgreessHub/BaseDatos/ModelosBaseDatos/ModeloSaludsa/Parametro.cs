using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Parametro
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Mnemonico { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CodigoTipo { get; set; }
        public bool? ValorBit { get; set; }
        public string ValorChar { get; set; }
        public string ValorTexto { get; set; }
        public int? ValorEntero { get; set; }
        public double? ValorDoble { get; set; }
        public bool EstadoActivo { get; set; }
    }
}

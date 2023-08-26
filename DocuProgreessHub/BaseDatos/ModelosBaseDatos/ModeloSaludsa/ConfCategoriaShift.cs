using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ConfCategoriaShift
    {
        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public bool ShiftActivo { get; set; }
        public string Categorias { get; set; }
        public string MensajePremio { get; set; }
        public bool Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Plan { get; set; }
        public int? DiasHabilitados { get; set; }
        public string Nivel { get; set; }
        public string Nombre { get; set; }
    }
}

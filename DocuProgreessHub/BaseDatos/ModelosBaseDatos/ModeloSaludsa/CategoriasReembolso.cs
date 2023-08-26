using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CategoriasReembolso
    {
        public int CategoriaId { get; set; }
        public int ReembolsoId { get; set; }
        public string CodigoCategoria { get; set; }
        public bool EstaCompleto { get; set; }

        public DatosReembolso Reembolso { get; set; }
    }
}

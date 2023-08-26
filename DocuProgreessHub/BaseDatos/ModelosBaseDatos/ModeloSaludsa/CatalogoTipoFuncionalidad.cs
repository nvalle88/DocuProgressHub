using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class CatalogoTipoFuncionalidad
    {
        public int IdTipoFuncionalidad { get; set; }
        public string DescripcionTipoFuncionalidad { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}

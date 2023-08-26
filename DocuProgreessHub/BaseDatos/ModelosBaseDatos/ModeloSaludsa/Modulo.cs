using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Modulo
    {
        public Modulo()
        {
            Funcionalidad = new HashSet<Funcionalidad>();
        }

        public Guid Id { get; set; }
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstadoActivo { get; set; }
        public long? EntidadRelacionadaId { get; set; }

        public ICollection<Funcionalidad> Funcionalidad { get; set; }
    }
}

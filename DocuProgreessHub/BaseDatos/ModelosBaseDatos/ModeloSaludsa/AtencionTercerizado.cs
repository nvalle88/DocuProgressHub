using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class AtencionTercerizado
    {
        public long Id { get; set; }
        public Guid UsuarioId { get; set; }
        public DateTime HoraAtencion { get; set; }
        public string NombreTratante { get; set; }
        public string ProveedorAmbulancia { get; set; }
        public bool SuministraMedicina { get; set; }
        public string MedicinaSuministrada { get; set; }
        public bool TieneReceta { get; set; }
        public bool TieneOrden { get; set; }
        public bool EsInterconsulta { get; set; }
        public string Especialidad { get; set; }
        public long CasoId { get; set; }

        public Caso Caso { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Encuesta
    {
        public long Id { get; set; }
        public DateTime FechaEncuesta { get; set; }
        public bool RequerimientoResuelto { get; set; }
        public int CalificacionAtencion { get; set; }
        public string MotivoCalificacion { get; set; }
        public int CalificacionEstancia { get; set; }
        public string MotivoCalifEstancia { get; set; }
        public int? CalificacionHospitalization { get; set; }
        public string MotivoCalifHospitalization { get; set; }
        public long CasoId { get; set; }

        public Caso Caso { get; set; }
    }
}

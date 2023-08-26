using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class ItemCatalogo
    {
        public ItemCatalogo()
        {
            AtencionHospitalizacionAreaAtencion = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionConceptoCostoEvitado = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionEstadoVisita = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionEvolucionPaciente = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionProblemasQuejas = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionSeveridad = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionTipoAutorizacion = new HashSet<AtencionHospitalizacion>();
            AtencionHospitalizacionTipoTratamiento = new HashSet<AtencionHospitalizacion>();
            CasoAccionCliente = new HashSet<Caso>();
            CasoAccionFinal = new HashSet<Caso>();
            CasoAccionOperador = new HashSet<Caso>();
            CasoEscalaManchester = new HashSet<Caso>();
            CasoSignoSintoma = new HashSet<CasoSignoSintoma>();
        }

        public int Id { get; set; }
        public int CatalogoId { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public bool? EstadoActivo { get; set; }

        public Catalogo Catalogo { get; set; }
        public ICollection<AtencionHospitalizacion> AtencionHospitalizacionAreaAtencion { get; set; }
        public ICollection<AtencionHospitalizacion> AtencionHospitalizacionConceptoCostoEvitado { get; set; }
        public ICollection<AtencionHospitalizacion> AtencionHospitalizacionEstadoVisita { get; set; }
        public ICollection<AtencionHospitalizacion> AtencionHospitalizacionEvolucionPaciente { get; set; }
        public ICollection<AtencionHospitalizacion> AtencionHospitalizacionProblemasQuejas { get; set; }
        public ICollection<AtencionHospitalizacion> AtencionHospitalizacionSeveridad { get; set; }
        public ICollection<AtencionHospitalizacion> AtencionHospitalizacionTipoAutorizacion { get; set; }
        public ICollection<AtencionHospitalizacion> AtencionHospitalizacionTipoTratamiento { get; set; }
        public ICollection<Caso> CasoAccionCliente { get; set; }
        public ICollection<Caso> CasoAccionFinal { get; set; }
        public ICollection<Caso> CasoAccionOperador { get; set; }
        public ICollection<Caso> CasoEscalaManchester { get; set; }
        public ICollection<CasoSignoSintoma> CasoSignoSintoma { get; set; }
    }
}

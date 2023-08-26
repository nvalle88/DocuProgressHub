using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class AtencionHospitalizacion
    {
        public long Id { get; set; }
        public long CasoId { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAccion { get; set; }
        public int? TipoAutorizacionId { get; set; }
        public int? TipoTratamientoId { get; set; }
        public int? AreaAtencionId { get; set; }
        public int SeveridadId { get; set; }
        public bool NoHacerSeguimiento { get; set; }
        public string ObservacionNoHacerSeguimiento { get; set; }
        public bool SospechaAbusoFraude { get; set; }
        public string ObservacionSospechaAbusoFraude { get; set; }
        public int? EvolucionPacienteId { get; set; }
        public int? EstadoVisitaId { get; set; }
        public int? ProblemasQuejasId { get; set; }
        public string ComentariosVisitaPaciente { get; set; }
        public string NombreContactoVisita { get; set; }
        public string TelefonoContactoVisita { get; set; }
        public decimal? MontoCostoEvitado { get; set; }
        public int? ConceptoCostoEvitadoId { get; set; }
        public string ObservacionCostoEvitado { get; set; }
        public bool QuitarCobertura { get; set; }
        public decimal? MontoFinalHospitalizacion { get; set; }
        public string RequerimientosAlta { get; set; }
        public DateTime? FechaPresentacionFacturas { get; set; }

        public ItemCatalogo AreaAtencion { get; set; }
        public Caso Caso { get; set; }
        public ItemCatalogo ConceptoCostoEvitado { get; set; }
        public ItemCatalogo EstadoVisita { get; set; }
        public ItemCatalogo EvolucionPaciente { get; set; }
        public ItemCatalogo ProblemasQuejas { get; set; }
        public ItemCatalogo Severidad { get; set; }
        public ItemCatalogo TipoAutorizacion { get; set; }
        public ItemCatalogo TipoTratamiento { get; set; }
    }
}

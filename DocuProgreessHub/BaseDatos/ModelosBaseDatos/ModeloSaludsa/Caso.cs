using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class Caso
    {
        public Caso()
        {
            AtencionHospitalizacion = new HashSet<AtencionHospitalizacion>();
            AtencionOperador = new HashSet<AtencionOperador>();
            AutorizacionGesPacientes = new HashSet<AutorizacionGesPacientes>();
            CasoSignoSintoma = new HashSet<CasoSignoSintoma>();
            ComentarioInSitu = new HashSet<ComentarioInSitu>();
        }

        public long Id { get; set; }
        public long ContratoId { get; set; }
        public int Beneficiario { get; set; }
        public int? EscalaManchesterId { get; set; }
        public int? AccionClienteId { get; set; }
        public int? AccionOperadorId { get; set; }
        public int? AccionFinalId { get; set; }
        public long? ContactoId { get; set; }
        public string Observaciones { get; set; }
        public bool EstadoActivo { get; set; }
        public bool EsEmergencia { get; set; }
        public string UsuarioCreacionCaso { get; set; }
        public string UsuarioCierreCaso { get; set; }
        public DateTime FechaCreacionCaso { get; set; }
        public DateTime? FechaCierreCaso { get; set; }
        public bool? Aceptado { get; set; }
        public bool AtendidoTercerizado { get; set; }
        public bool RequiereAtencionTercerizado { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int DiasHospitalizacion { get; set; }
        public long? EncuestaId { get; set; }
        public long? AtencionTercerizadoId { get; set; }

        public ItemCatalogo AccionCliente { get; set; }
        public ItemCatalogo AccionFinal { get; set; }
        public ItemCatalogo AccionOperador { get; set; }
        public ContratoGesPacientes Contrato { get; set; }
        public ItemCatalogo EscalaManchester { get; set; }
        public AtencionTercerizado AtencionTercerizado { get; set; }
        public ContactoGesPacientes ContactoGesPacientes { get; set; }
        public Encuesta Encuesta { get; set; }
        public ICollection<AtencionHospitalizacion> AtencionHospitalizacion { get; set; }
        public ICollection<AtencionOperador> AtencionOperador { get; set; }
        public ICollection<AutorizacionGesPacientes> AutorizacionGesPacientes { get; set; }
        public ICollection<CasoSignoSintoma> CasoSignoSintoma { get; set; }
        public ICollection<ComentarioInSitu> ComentarioInSitu { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class InstruccionEntrega
    {
        public int Id { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Ciudad { get; set; }
        public string Barrio { get; set; }
        public string Sector { get; set; }
        public string NumeroDomicilio { get; set; }
        public string CallePrincipal { get; set; }
        public string CalleSecundaria { get; set; }
        public string Referencia { get; set; }
        public TimeSpan? HoraEntrega { get; set; }
        public string EntregaPersonalizada { get; set; }
        public string TelefonoContacto { get; set; }
        public string OficinaEntrega { get; set; }
        public string DireccionOficina { get; set; }
        public string RegionOficina { get; set; }
        public string FuncionarioOficina { get; set; }
        public string DireccionTitularContrato { get; set; }
        public int? IdCertificado { get; set; }

        public Certificado IdCertificadoNavigation { get; set; }
    }
}

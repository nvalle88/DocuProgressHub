using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class OnBoarding
    {
        public OnBoarding()
        {
            VersionamientoOnBoarding = new HashSet<VersionamientoOnBoarding>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public string UrlContenido { get; set; }
        public string TipoContenido { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Orden { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool PrimeraVez { get; set; }
        public string PlataformaHabilitadas { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoPlan { get; set; }
        public string TipoConsulta { get; set; }
        public string EmpresaNumero { get; set; }
        public string OnBoardingVersion { get; set; }

        public ICollection<VersionamientoOnBoarding> VersionamientoOnBoarding { get; set; }
    }
}

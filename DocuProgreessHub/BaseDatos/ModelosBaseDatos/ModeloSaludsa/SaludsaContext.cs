using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class SaludsaContext : DbContext
    {
        public virtual DbSet<AdmCatalogo> AdmCatalogo { get; set; }
        public virtual DbSet<AdmItemCatalogo> AdmItemCatalogo { get; set; }
        public virtual DbSet<AgrupadorCobertura> AgrupadorCobertura { get; set; }
        public virtual DbSet<ArchivosReembolso> ArchivosReembolso { get; set; }
        public virtual DbSet<AtencionesMedicasBi> AtencionesMedicasBi { get; set; }
        public virtual DbSet<AtencionHospitalizacion> AtencionHospitalizacion { get; set; }
        public virtual DbSet<AtencionOperador> AtencionOperador { get; set; }
        public virtual DbSet<AtencionTercerizado> AtencionTercerizado { get; set; }
        public virtual DbSet<AutorizacionGesPacientes> AutorizacionGesPacientes { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Beneficiario> Beneficiario { get; set; }
        public virtual DbSet<BeneficioProducto> BeneficioProducto { get; set; }
        public virtual DbSet<BitacoraSistema> BitacoraSistema { get; set; }
        public virtual DbSet<CalificacionAplicacion> CalificacionAplicacion { get; set; }
        public virtual DbSet<Canales> Canales { get; set; }
        public virtual DbSet<CanalesServicios> CanalesServicios { get; set; }
        public virtual DbSet<Caso> Caso { get; set; }
        public virtual DbSet<CasoSignoSintoma> CasoSignoSintoma { get; set; }
        public virtual DbSet<Catalogo> Catalogo { get; set; }
        public virtual DbSet<CatalogoCategorias> CatalogoCategorias { get; set; }
        public virtual DbSet<CatalogoGeneral> CatalogoGeneral { get; set; }
        public virtual DbSet<CatalogoTipoFuncionalidad> CatalogoTipoFuncionalidad { get; set; }
        public virtual DbSet<CatalogoTipoNoticia> CatalogoTipoNoticia { get; set; }
        public virtual DbSet<CategoriasReembolso> CategoriasReembolso { get; set; }
        public virtual DbSet<Certificado> Certificado { get; set; }
        public virtual DbSet<Cfconciliacion> Cfconciliacion { get; set; }
        public virtual DbSet<CfconciliacionCredito> CfconciliacionCredito { get; set; }
        public virtual DbSet<CfconciliacionDetalle> CfconciliacionDetalle { get; set; }
        public virtual DbSet<CfconciliacionLogs> CfconciliacionLogs { get; set; }
        public virtual DbSet<CfconfReglaControlDespacho> CfconfReglaControlDespacho { get; set; }
        public virtual DbSet<CfcorreosNotificar> CfcorreosNotificar { get; set; }
        public virtual DbSet<Cfdiagnostico> Cfdiagnostico { get; set; }
        public virtual DbSet<CfdiagnosticoRechazo> CfdiagnosticoRechazo { get; set; }
        public virtual DbSet<CferrorConciliacion> CferrorConciliacion { get; set; }
        public virtual DbSet<CferrorConciliacionMi02CausasNoMigrar> CferrorConciliacionMi02CausasNoMigrar { get; set; }
        public virtual DbSet<Cfingreso> Cfingreso { get; set; }
        public virtual DbSet<Cfmedicamento> Cfmedicamento { get; set; }
        public virtual DbSet<CfmedicamentoRechazo> CfmedicamentoRechazo { get; set; }
        public virtual DbSet<Cfmedicina> Cfmedicina { get; set; }
        public virtual DbSet<CfmedicinaPrestadorProducto> CfmedicinaPrestadorProducto { get; set; }
        public virtual DbSet<CfobservacionSolicitud> CfobservacionSolicitud { get; set; }
        public virtual DbSet<Cfprestador> Cfprestador { get; set; }
        public virtual DbSet<Cfproducto> Cfproducto { get; set; }
        public virtual DbSet<Cfregla> Cfregla { get; set; }
        public virtual DbSet<Cfsolicitud> Cfsolicitud { get; set; }
        public virtual DbSet<CfsolicitudRechazo> CfsolicitudRechazo { get; set; }
        public virtual DbSet<CitasMedicasNotificaciones> CitasMedicasNotificaciones { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Ciudad1> Ciudad1 { get; set; }
        public virtual DbSet<CiudadPrestadorProcedimiento> CiudadPrestadorProcedimiento { get; set; }
        public virtual DbSet<Cl03PersonasAdicional> Cl03PersonasAdicional { get; set; }
        public virtual DbSet<ClasificacionClientes> ClasificacionClientes { get; set; }
        public virtual DbSet<Cobertura> Cobertura { get; set; }
        public virtual DbSet<CoberturaBeneficio> CoberturaBeneficio { get; set; }
        public virtual DbSet<CoberturaDental> CoberturaDental { get; set; }
        public virtual DbSet<CoberturaNacInt> CoberturaNacInt { get; set; }
        public virtual DbSet<CoberturaNacIntTipoCobertura> CoberturaNacIntTipoCobertura { get; set; }
        public virtual DbSet<CoberturaProducto> CoberturaProducto { get; set; }
        public virtual DbSet<CoberturasDent> CoberturasDent { get; set; }
        public virtual DbSet<CoberturaSeccion> CoberturaSeccion { get; set; }
        public virtual DbSet<CoberturaSeccion1> CoberturaSeccion1 { get; set; }
        public virtual DbSet<CoberturaSeccionTipo> CoberturaSeccionTipo { get; set; }
        public virtual DbSet<CoberturaSeccionTipoCobertura> CoberturaSeccionTipoCobertura { get; set; }
        public virtual DbSet<CoberturaTipo> CoberturaTipo { get; set; }
        public virtual DbSet<Columna> Columna { get; set; }
        public virtual DbSet<ComentarioInSitu> ComentarioInSitu { get; set; }
        public virtual DbSet<ComoUsarPlanCanalOrigen> ComoUsarPlanCanalOrigen { get; set; }
        public virtual DbSet<ComoUsarPlanGuiaUso> ComoUsarPlanGuiaUso { get; set; }
        public virtual DbSet<ComoUsarPlanProducto> ComoUsarPlanProducto { get; set; }
        public virtual DbSet<ConfCategoriaShift> ConfCategoriaShift { get; set; }
        public virtual DbSet<ConfCentrosMedicos> ConfCentrosMedicos { get; set; }
        public virtual DbSet<ConfCentrosMedicosNotificacion> ConfCentrosMedicosNotificacion { get; set; }
        public virtual DbSet<Configuracion> Configuracion { get; set; }
        public virtual DbSet<ConfiguracionCargaEstadoCuenta> ConfiguracionCargaEstadoCuenta { get; set; }
        public virtual DbSet<ConfiguracionEnvioNotificaciones> ConfiguracionEnvioNotificaciones { get; set; }
        public virtual DbSet<ConfiguracionPantalla> ConfiguracionPantalla { get; set; }
        public virtual DbSet<ConfiguracionPantallaGenerica> ConfiguracionPantallaGenerica { get; set; }
        public virtual DbSet<ConfiguracionPrestadorSrvCita> ConfiguracionPrestadorSrvCita { get; set; }
        public virtual DbSet<ConfParametrosConsultas> ConfParametrosConsultas { get; set; }
        public virtual DbSet<ContabilizacionCitasMedicas> ContabilizacionCitasMedicas { get; set; }
        public virtual DbSet<ContactoGesPacientes> ContactoGesPacientes { get; set; }
        public virtual DbSet<ContenidoVisor> ContenidoVisor { get; set; }
        public virtual DbSet<ContratoGesPacientes> ContratoGesPacientes { get; set; }
        public virtual DbSet<ControlCita> ControlCita { get; set; }
        public virtual DbSet<ControlCitas> ControlCitas { get; set; }
        public virtual DbSet<CoordinaLlamada> CoordinaLlamada { get; set; }
        public virtual DbSet<CorreosPrestador> CorreosPrestador { get; set; }
        public virtual DbSet<CredencialesVisor> CredencialesVisor { get; set; }
        public virtual DbSet<CreditoMedNpproducto> CreditoMedNpproducto { get; set; }
        public virtual DbSet<CredMedNpmedicina> CredMedNpmedicina { get; set; }
        public virtual DbSet<CredMedNpmedicinaPrestadorProducto> CredMedNpmedicinaPrestadorProducto { get; set; }
        public virtual DbSet<CredMedNpprestador> CredMedNpprestador { get; set; }
        public virtual DbSet<Criterio> Criterio { get; set; }
        public virtual DbSet<CriterioValor> CriterioValor { get; set; }
        public virtual DbSet<DatosBeneficiarioScore> DatosBeneficiarioScore { get; set; }
        public virtual DbSet<DatosReembolso> DatosReembolso { get; set; }
        public virtual DbSet<DatosVentaDigital> DatosVentaDigital { get; set; }
        public virtual DbSet<DeducibleProducto> DeducibleProducto { get; set; }
        public virtual DbSet<DeducibleSeccion> DeducibleSeccion { get; set; }
        public virtual DbSet<DetalleConfiguracionEnvioNotificaciones> DetalleConfiguracionEnvioNotificaciones { get; set; }
        public virtual DbSet<DetallesCoberturaDent> DetallesCoberturaDent { get; set; }
        public virtual DbSet<Diagnosticos> Diagnosticos { get; set; }
        public virtual DbSet<EmpresaTercerizada> EmpresaTercerizada { get; set; }
        public virtual DbSet<Encuesta> Encuesta { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<Equivalencia> Equivalencia { get; set; }
        public virtual DbSet<EquivalenciaEntidadPersona> EquivalenciaEntidadPersona { get; set; }
        public virtual DbSet<EquivalenciaRolLdap> EquivalenciaRolLdap { get; set; }
        public virtual DbSet<EquivalenciaUsuarioLdap> EquivalenciaUsuarioLdap { get; set; }
        public virtual DbSet<Error> Error { get; set; }
        public virtual DbSet<EspecialidadCiudad> EspecialidadCiudad { get; set; }
        public virtual DbSet<EspecialidadMedica> EspecialidadMedica { get; set; }
        public virtual DbSet<EstadoAtencion> EstadoAtencion { get; set; }
        public virtual DbSet<EstadoCuentaBancaria> EstadoCuentaBancaria { get; set; }
        public virtual DbSet<ExcepcionCita> ExcepcionCita { get; set; }
        public virtual DbSet<FacturaCitaMedica> FacturaCitaMedica { get; set; }
        public virtual DbSet<FormularioHospitalario> FormularioHospitalario { get; set; }
        public virtual DbSet<Funcionalidad> Funcionalidad { get; set; }
        public virtual DbSet<FuncionarioPrestador> FuncionarioPrestador { get; set; }
        public virtual DbSet<Gap> Gap { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Grupo1> Grupo1 { get; set; }
        public virtual DbSet<Grupo2> Grupo2 { get; set; }
        public virtual DbSet<GrupoNoticias> GrupoNoticias { get; set; }
        public virtual DbSet<GrupoProductoPlan> GrupoProductoPlan { get; set; }
        public virtual DbSet<GrupoProductoPlan1> GrupoProductoPlan1 { get; set; }
        public virtual DbSet<Historial> Historial { get; set; }
        public virtual DbSet<HomologacionEstados> HomologacionEstados { get; set; }
        public virtual DbSet<ImagenOrdenAtencion> ImagenOrdenAtencion { get; set; }
        public virtual DbSet<InclusionExclusionDiaria> InclusionExclusionDiaria { get; set; }
        public virtual DbSet<InformacionPrestador> InformacionPrestador { get; set; }
        public virtual DbSet<InstruccionEntrega> InstruccionEntrega { get; set; }
        public virtual DbSet<ItemCatalogo> ItemCatalogo { get; set; }
        public virtual DbSet<ListaCoberturasNacInt> ListaCoberturasNacInt { get; set; }
        public virtual DbSet<LotePago> LotePago { get; set; }
        public virtual DbSet<LotePagoDetalle> LotePagoDetalle { get; set; }
        public virtual DbSet<LotePagoFacturas> LotePagoFacturas { get; set; }
        public virtual DbSet<MasivoMovimiento> MasivoMovimiento { get; set; }
        public virtual DbSet<MasivoServicioAdicional> MasivoServicioAdicional { get; set; }
        public virtual DbSet<MensajeError> MensajeError { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<MotivoRequerimiento> MotivoRequerimiento { get; set; }
        public virtual DbSet<Movimiento> Movimiento { get; set; }
        public virtual DbSet<Niveles> Niveles { get; set; }
        public virtual DbSet<Noticia> Noticia { get; set; }
        public virtual DbSet<Noticia1> Noticia1 { get; set; }
        public virtual DbSet<Noticia2> Noticia2 { get; set; }
        public virtual DbSet<Notificacion> Notificacion { get; set; }
        public virtual DbSet<NotificacionTerminosCondiciones> NotificacionTerminosCondiciones { get; set; }
        public virtual DbSet<ObservacionCanales> ObservacionCanales { get; set; }
        public virtual DbSet<ObservacionNiveles> ObservacionNiveles { get; set; }
        public virtual DbSet<ObservacionRangos> ObservacionRangos { get; set; }
        public virtual DbSet<ObservacionSalas> ObservacionSalas { get; set; }
        public virtual DbSet<ObservacionSubtipo> ObservacionSubtipo { get; set; }
        public virtual DbSet<ObservacionTipo> ObservacionTipo { get; set; }
        public virtual DbSet<OnBoarding> OnBoarding { get; set; }
        public virtual DbSet<OrdenAtencion> OrdenAtencion { get; set; }
        public virtual DbSet<OrdenCentroMedico> OrdenCentroMedico { get; set; }
        public virtual DbSet<Organizacion> Organizacion { get; set; }
        public virtual DbSet<PagoCitaMedica> PagoCitaMedica { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Parametro> Parametro { get; set; }
        public virtual DbSet<Parametro1> Parametro1 { get; set; }
        public virtual DbSet<ParametroServicioWeb> ParametroServicioWeb { get; set; }
        public virtual DbSet<ParametroServicioWebs> ParametroServicioWebs { get; set; }
        public virtual DbSet<Periodo> Periodo { get; set; }
        public virtual DbSet<PermisosVisor> PermisosVisor { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<PersonaActualizada> PersonaActualizada { get; set; }
        public virtual DbSet<PersonaAdicional> PersonaAdicional { get; set; }
        public virtual DbSet<PlanAgrupador> PlanAgrupador { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }
        public virtual DbSet<Planes1> Planes1 { get; set; }
        public virtual DbSet<Poliza> Poliza { get; set; }
        public virtual DbSet<Preexistencia> Preexistencia { get; set; }
        public virtual DbSet<PreexistenciaDetalle> PreexistenciaDetalle { get; set; }
        public virtual DbSet<Prestador> Prestador { get; set; }
        public virtual DbSet<Prestador1> Prestador1 { get; set; }
        public virtual DbSet<PrestadoresHomologadosZendesk> PrestadoresHomologadosZendesk { get; set; }
        public virtual DbSet<PrestadorGesPacientes> PrestadorGesPacientes { get; set; }
        public virtual DbSet<PrestadorUsuario> PrestadorUsuario { get; set; }
        public virtual DbSet<PresupuestoDirector> PresupuestoDirector { get; set; }
        public virtual DbSet<PresupuestoVendedor> PresupuestoVendedor { get; set; }
        public virtual DbSet<Procedimiento> Procedimiento { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Productos1> Productos1 { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Queja> Queja { get; set; }
        public virtual DbSet<Rangos> Rangos { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegistroEnvioNotificaciones> RegistroEnvioNotificaciones { get; set; }
        public virtual DbSet<RepositorioFormularioHospitalario> RepositorioFormularioHospitalario { get; set; }
        public virtual DbSet<RepositorioMedicacionContinua> RepositorioMedicacionContinua { get; set; }
        public virtual DbSet<RestriccionEspecialidad> RestriccionEspecialidad { get; set; }
        public virtual DbSet<Resumen> Resumen { get; set; }
        public virtual DbSet<ResumenDetalle> ResumenDetalle { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<RolFuncionalidad> RolFuncionalidad { get; set; }
        public virtual DbSet<Salas> Salas { get; set; }
        public virtual DbSet<SaludsaContigo> SaludsaContigo { get; set; }
        public virtual DbSet<SegmentacionContrato> SegmentacionContrato { get; set; }
        public virtual DbSet<SeguimientoPrestadorSaludsaContigo> SeguimientoPrestadorSaludsaContigo { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Servicio1> Servicio1 { get; set; }
        public virtual DbSet<ServicioAdicionalIcono> ServicioAdicionalIcono { get; set; }
        public virtual DbSet<ServicioAdicionalSeccion> ServicioAdicionalSeccion { get; set; }
        public virtual DbSet<ServicioBeneficiario> ServicioBeneficiario { get; set; }
        public virtual DbSet<ServiciosHabilitadosApps> ServiciosHabilitadosApps { get; set; }
        public virtual DbSet<SolicitudCitaMedicoDestacado> SolicitudCitaMedicoDestacado { get; set; }
        public virtual DbSet<Sponsor> Sponsor { get; set; }
        public virtual DbSet<SubespecialidadMedica> SubespecialidadMedica { get; set; }
        public virtual DbSet<Subtipos> Subtipos { get; set; }
        public virtual DbSet<SucursalCiudad> SucursalCiudad { get; set; }
        public virtual DbSet<SucursalesPrestador> SucursalesPrestador { get; set; }
        public virtual DbSet<Tabla> Tabla { get; set; }
        public virtual DbSet<Tematica> Tematica { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<TipoCoberturaNacInt> TipoCoberturaNacInt { get; set; }
        public virtual DbSet<TipoEntidad> TipoEntidad { get; set; }
        public virtual DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }
        public virtual DbSet<TipoPrestador> TipoPrestador { get; set; }
        public virtual DbSet<TipoPrestadorCiudadPrestador> TipoPrestadorCiudadPrestador { get; set; }
        public virtual DbSet<TipoRequerimiento> TipoRequerimiento { get; set; }
        public virtual DbSet<TokenOda> TokenOda { get; set; }
        public virtual DbSet<TotalCitaDisponible> TotalCitaDisponible { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioRol> UsuarioRol { get; set; }
        public virtual DbSet<ValoresFee> ValoresFee { get; set; }
        public virtual DbSet<Versionamiento> Versionamiento { get; set; }
        public virtual DbSet<VersionamientoOnBoarding> VersionamientoOnBoarding { get; set; }

        // Unable to generate entity type for table 'SaludsaContigo.SaludsaContigoRepositorio'. Please see the warning messages.
        // Unable to generate entity type for table 'FormularioHospitalario.ProcedimientoDiagnostico'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sector'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PruebaTrg'. Please see the warning messages.
        // Unable to generate entity type for table 'ProcedimientoGuiaMedica.ProcedimientoTemporal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.auxplanv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.respPara'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CFConciliacionReproceso'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.auxplan'. Please see the warning messages.
        // Unable to generate entity type for table 'GestionContenido.GrupoNoticia'. Please see the warning messages.
        // Unable to generate entity type for table 'CreditoFarmacia.CFPosiblePreexistenciaHallazgo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PruebasPrestadores'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DataLoadTable'. Please see the warning messages.
        // Unable to generate entity type for table 'Catalogo.ServicioCiudad'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CertificadoEjemplo'. Please see the warning messages.
        // Unable to generate entity type for table 'Administracion.ParametroServicioWeb_Prod'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=10.10.24.15;Database=Saludsa;user id=saludsa;password=Sa1ud5a");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdmCatalogo>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("ADM_CATALOGO");

                entity.HasIndex(e => e.CatCodigo)
                    .HasName("IX_ADM_CATALOGO")
                    .IsUnique();

                entity.Property(e => e.CatId).HasColumnName("Cat_Id");

                entity.Property(e => e.CatCodigo)
                    .IsRequired()
                    .HasColumnName("Cat_Codigo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CatDescripcion)
                    .HasColumnName("Cat_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatEstado)
                    .IsRequired()
                    .HasColumnName("Cat_Estado")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CatNombre)
                    .IsRequired()
                    .HasColumnName("Cat_Nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdmItemCatalogo>(entity =>
            {
                entity.HasKey(e => e.ItcId);

                entity.ToTable("ADM_ITEM_CATALOGO");

                entity.HasIndex(e => e.ItcCodigo)
                    .HasName("IX_ADM_ITEM_CATALOGO")
                    .IsUnique();

                entity.Property(e => e.ItcId).HasColumnName("Itc_Id");

                entity.Property(e => e.CatId).HasColumnName("Cat_Id");

                entity.Property(e => e.ItcCodigo)
                    .IsRequired()
                    .HasColumnName("Itc_Codigo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItcDescripcion)
                    .HasColumnName("Itc_Descripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItcEstado)
                    .IsRequired()
                    .HasColumnName("Itc_Estado")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItcNombre)
                    .IsRequired()
                    .HasColumnName("Itc_Nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItcPadre).HasColumnName("Itc_Padre");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.AdmItemCatalogo)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_ADM_CATALOGO_ADM_ITEM_CATALOGO_Cat_Id");
            });

            modelBuilder.Entity<AgrupadorCobertura>(entity =>
            {
                entity.HasKey(e => e.IdAgrupadorCobertura);

                entity.ToTable("AgrupadorCobertura", "GenericoEstructura");

                entity.Property(e => e.TituloPantalla)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchivosReembolso>(entity =>
            {
                entity.HasKey(e => e.ArchivoId);

                entity.ToTable("ArchivosReembolso", "ReembolsoBorrador");

                entity.Property(e => e.Metadata).IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UrlAzureStorage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Reembolso)
                    .WithMany(p => p.ArchivosReembolso)
                    .HasForeignKey(d => d.ReembolsoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DatosReembolso_ArchivoReembolso");
            });

            modelBuilder.Entity<AtencionesMedicasBi>(entity =>
            {
                entity.HasKey(e => e.IdAtencionesMedicasBi);

                entity.ToTable("AtencionesMedicasBI", "ServiciosMedicos");

                entity.Property(e => e.IdAtencionesMedicasBi).HasColumnName("IdAtencionesMedicasBI");

                entity.Property(e => e.Calificacion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CambioCanalDesde)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CambioCanalFecha).HasColumnType("datetime");

                entity.Property(e => e.CambioCanalHasta)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CambioCanalJustificacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Canal)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CanalAcceso)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cie10)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClasificacionSeguimiento)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioUsuario)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCie10)
                    .HasColumnName("Detalle_Cie10")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DiferenciaMinutos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Edad)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Examenes)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Farmacia)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaContestacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacionMensaje).HasColumnType("datetime");

                entity.Property(e => e.FechaMensajeMedico).HasColumnType("datetime");

                entity.Property(e => e.FechaMensajePaciente).HasColumnType("datetime");

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.FechaSegundoMensajeMedico).HasColumnType("datetime");

                entity.Property(e => e.LaboratorioDomicilio)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPersona)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PoseeImagen)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PoseeLaboratorio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PoseeReceta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorFarmacia)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorLaboratorio)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoDemoraMensajeMedico)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoDemoraMensajePaciente)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoDemoraSegundoMensajeMedico)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAtencion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAtencionEfectuadaCovid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPaciente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoResolucion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoResolucionCovid)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Zendesk)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AtencionHospitalizacion>(entity =>
            {
                entity.ToTable("AtencionHospitalizacion", "GestionPacientes");

                entity.Property(e => e.ComentariosVisitaPaciente).HasColumnType("text");

                entity.Property(e => e.FechaAccion).HasColumnType("datetime");

                entity.Property(e => e.FechaPresentacionFacturas).HasColumnType("datetime");

                entity.Property(e => e.NombreContactoVisita)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionCostoEvitado).HasColumnType("text");

                entity.Property(e => e.ObservacionNoHacerSeguimiento).HasColumnType("text");

                entity.Property(e => e.ObservacionSospechaAbusoFraude).HasColumnType("text");

                entity.Property(e => e.RequerimientosAlta).HasColumnType("text");

                entity.Property(e => e.TelefonoContactoVisita)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AreaAtencion)
                    .WithMany(p => p.AtencionHospitalizacionAreaAtencion)
                    .HasForeignKey(d => d.AreaAtencionId)
                    .HasConstraintName("FK_AtencionHospitalizacion_AreaAtencion");

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.AtencionHospitalizacion)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionHospitalizacion_Caso");

                entity.HasOne(d => d.ConceptoCostoEvitado)
                    .WithMany(p => p.AtencionHospitalizacionConceptoCostoEvitado)
                    .HasForeignKey(d => d.ConceptoCostoEvitadoId)
                    .HasConstraintName("FK_AtencionHospitalizacion_ConceptoCostoEvitado");

                entity.HasOne(d => d.EstadoVisita)
                    .WithMany(p => p.AtencionHospitalizacionEstadoVisita)
                    .HasForeignKey(d => d.EstadoVisitaId)
                    .HasConstraintName("FK_AtencionHospitalizacion_EstadoVisita");

                entity.HasOne(d => d.EvolucionPaciente)
                    .WithMany(p => p.AtencionHospitalizacionEvolucionPaciente)
                    .HasForeignKey(d => d.EvolucionPacienteId)
                    .HasConstraintName("FK_AtencionHospitalizacion_EvolucionPaciente");

                entity.HasOne(d => d.ProblemasQuejas)
                    .WithMany(p => p.AtencionHospitalizacionProblemasQuejas)
                    .HasForeignKey(d => d.ProblemasQuejasId)
                    .HasConstraintName("FK_AtencionHospitalizacion_ProblemasQuejas");

                entity.HasOne(d => d.Severidad)
                    .WithMany(p => p.AtencionHospitalizacionSeveridad)
                    .HasForeignKey(d => d.SeveridadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionHospitalizacion_Severidad");

                entity.HasOne(d => d.TipoAutorizacion)
                    .WithMany(p => p.AtencionHospitalizacionTipoAutorizacion)
                    .HasForeignKey(d => d.TipoAutorizacionId)
                    .HasConstraintName("FK_AtencionHospitalizacion_TipoAutorizacion");

                entity.HasOne(d => d.TipoTratamiento)
                    .WithMany(p => p.AtencionHospitalizacionTipoTratamiento)
                    .HasForeignKey(d => d.TipoTratamientoId)
                    .HasConstraintName("FK_AtencionHospitalizacion_TipoTratamiento");
            });

            modelBuilder.Entity<AtencionOperador>(entity =>
            {
                entity.ToTable("AtencionOperador", "GestionPacientes");

                entity.Property(e => e.FechaAccion).HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.AtencionOperador)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionOperador_Caso");
            });

            modelBuilder.Entity<AtencionTercerizado>(entity =>
            {
                entity.HasKey(e => e.CasoId);

                entity.ToTable("AtencionTercerizado", "GestionPacientes");

                entity.Property(e => e.CasoId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Especialidad).HasColumnType("text");

                entity.Property(e => e.HoraAtencion).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MedicinaSuministrada).HasColumnType("text");

                entity.Property(e => e.NombreTratante)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorAmbulancia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithOne(p => p.AtencionTercerizado)
                    .HasForeignKey<AtencionTercerizado>(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionTercerizado_Caso");
            });

            modelBuilder.Entity<AutorizacionGesPacientes>(entity =>
            {
                entity.ToTable("AutorizacionGesPacientes", "GestionPacientes");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.AutorizacionGesPacientes)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Autorizacion_Caso");

                entity.HasOne(d => d.PrestadorCentroMedico)
                    .WithMany(p => p.AutorizacionGesPacientesPrestadorCentroMedico)
                    .HasForeignKey(d => d.PrestadorCentroMedicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Autorizacion_PrestadorCentroMedico");

                entity.HasOne(d => d.PrestadorMedico)
                    .WithMany(p => p.AutorizacionGesPacientesPrestadorMedico)
                    .HasForeignKey(d => d.PrestadorMedicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Autorizacion_PrestadorMedico");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.ToTable("Banco", "GenericoEstructura");

                entity.Property(e => e.Bin)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CantidadMaximaDigitos).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantidadMinimaDigitos).HasDefaultValueSql("((0))");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEntidad)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Beneficiario>(entity =>
            {
                entity.HasIndex(e => e.CategoriaCatalogoId)
                    .HasName("IX_CategoriaCatalogo_Id");

                entity.HasIndex(e => e.RelacionCatalogoId)
                    .HasName("IX_RelacionCatalogo_Id");

                entity.Property(e => e.BeneficiarioFechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.CategoriaCatalogoId).HasColumnName("CategoriaCatalogo_Id");

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaInclusion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.RelacionCatalogoId).HasColumnName("RelacionCatalogo_Id");

                entity.HasOne(d => d.CategoriaCatalogo)
                    .WithMany(p => p.BeneficiarioCategoriaCatalogo)
                    .HasForeignKey(d => d.CategoriaCatalogoId)
                    .HasConstraintName("FK_dbo.Beneficiario_dbo.CatalogoGeneral_CategoriaCatalogo_Id");

                entity.HasOne(d => d.RelacionCatalogo)
                    .WithMany(p => p.BeneficiarioRelacionCatalogo)
                    .HasForeignKey(d => d.RelacionCatalogoId)
                    .HasConstraintName("FK_dbo.Beneficiario_dbo.CatalogoGeneral_RelacionCatalogo_Id");
            });

            modelBuilder.Entity<BeneficioProducto>(entity =>
            {
                entity.HasKey(e => e.IdBeneficioProducto)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("BeneficioProducto", "GenericoEstructura");

                entity.Property(e => e.CodigoBeneficio)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Expresion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BitacoraSistema>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraSistema);

                entity.Property(e => e.Api)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Autorizacion)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Cabecera)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Cuerpo).IsUnicode(false);

                entity.Property(e => e.DireccionIp)
                    .HasColumnName("DireccionIP")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DispositivoNavegador)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Excepcion).IsUnicode(false);

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.Metodo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEnsamblado)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Parametros)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaOperativo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UriRequimiento)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Verbo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VersionEnsamblado)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CalificacionAplicacion>(entity =>
            {
                entity.ToTable("CalificacionAplicacion", "Calificacion");

                entity.HasIndex(e => new { e.CodigoAplicacion, e.CodigoPlataforma, e.FechaHoraRegistro, e.NumeroDocumento, e.Valor })
                    .HasName("IdxCalificacionAplicacion01")
                    .IsUnique();

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraRegistro).HasColumnType("datetime");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Canales>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(255);
            });

            modelBuilder.Entity<CanalesServicios>(entity =>
            {
                entity.HasKey(e => e.Codigo);
            });

            modelBuilder.Entity<Caso>(entity =>
            {
                entity.ToTable("Caso", "GestionPacientes");

                entity.Property(e => e.DiasHospitalizacion).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaCierreCaso).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacionCaso).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.UsuarioCierreCaso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacionCaso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccionCliente)
                    .WithMany(p => p.CasoAccionCliente)
                    .HasForeignKey(d => d.AccionClienteId)
                    .HasConstraintName("FK_Caso_AccionCliente");

                entity.HasOne(d => d.AccionFinal)
                    .WithMany(p => p.CasoAccionFinal)
                    .HasForeignKey(d => d.AccionFinalId)
                    .HasConstraintName("FK_Caso_AccionFinal");

                entity.HasOne(d => d.AccionOperador)
                    .WithMany(p => p.CasoAccionOperador)
                    .HasForeignKey(d => d.AccionOperadorId)
                    .HasConstraintName("FK_Caso_AccionOperador");

                entity.HasOne(d => d.Contrato)
                    .WithMany(p => p.Caso)
                    .HasForeignKey(d => d.ContratoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Caso_Contrato");

                entity.HasOne(d => d.EscalaManchester)
                    .WithMany(p => p.CasoEscalaManchester)
                    .HasForeignKey(d => d.EscalaManchesterId)
                    .HasConstraintName("FK_Caso_EscalaManchester");
            });

            modelBuilder.Entity<CasoSignoSintoma>(entity =>
            {
                entity.ToTable("CasoSignoSintoma", "GestionPacientes");

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.CasoSignoSintoma)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CasoSignoSintoma_Caso");

                entity.HasOne(d => d.SignoSintoma)
                    .WithMany(p => p.CasoSignoSintoma)
                    .HasForeignKey(d => d.SignoSintomaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CasoSignoSintoma_SignoSintoma");
            });

            modelBuilder.Entity<Catalogo>(entity =>
            {
                entity.ToTable("Catalogo", "Configuracion");

                entity.HasIndex(e => e.Codigo)
                    .HasName("AK_Codigo_Catalogo")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.CatalogoPadre)
                    .WithMany(p => p.InverseCatalogoPadre)
                    .HasForeignKey(d => d.CatalogoPadreId)
                    .HasConstraintName("FK_Catalogo_Catalogo");
            });

            modelBuilder.Entity<CatalogoCategorias>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("CatalogoCategorias", "Noticias");

                entity.Property(e => e.DescripcionCategoria)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<CatalogoGeneral>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_Codigo")
                    .IsUnique();

                entity.HasIndex(e => e.PadreId)
                    .HasName("IX_PadreId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo).HasColumnType("char(10)");

                entity.Property(e => e.CodigoSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Padre)
                    .WithMany(p => p.InversePadre)
                    .HasForeignKey(d => d.PadreId)
                    .HasConstraintName("FK_dbo.CatalogoGeneral_dbo.CatalogoGeneral_PadreId");
            });

            modelBuilder.Entity<CatalogoTipoFuncionalidad>(entity =>
            {
                entity.HasKey(e => e.IdTipoFuncionalidad);

                entity.ToTable("CatalogoTipoFuncionalidad", "Noticias");

                entity.Property(e => e.DescripcionTipoFuncionalidad)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<CatalogoTipoNoticia>(entity =>
            {
                entity.HasKey(e => e.IdTipoNoticia);

                entity.ToTable("CatalogoTipoNoticia", "Noticias");

                entity.Property(e => e.DescripcionTipoNoticia)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<CategoriasReembolso>(entity =>
            {
                entity.HasKey(e => e.CategoriaId);

                entity.ToTable("CategoriasReembolso", "ReembolsoBorrador");

                entity.Property(e => e.CodigoCategoria)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Reembolso)
                    .WithMany(p => p.CategoriasReembolso)
                    .HasForeignKey(d => d.ReembolsoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoriasReembolso_DatosReembolso");
            });

            modelBuilder.Entity<Certificado>(entity =>
            {
                entity.ToTable("Certificado", "Certificado");

                entity.Property(e => e.ApellidosTitular)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContenidoCertificado)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoActivo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.NombresTitular)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoTitular)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumentoTitular)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cfconciliacion>(entity =>
            {
                entity.HasKey(e => e.IdConciliacion);

                entity.ToTable("CFConciliacion", "CreditoFarmacia");

                entity.Property(e => e.CorreosNotificacion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CfconciliacionCredito>(entity =>
            {
                entity.ToTable("CFConciliacionCredito", "CreditoFarmacia");

                entity.Property(e => e.AutorizacionSri)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveAcceso)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdConciliacionNavigation)
                    .WithMany(p => p.CfconciliacionCredito)
                    .HasForeignKey(d => d.IdConciliacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CFConciliacionCredito_CFConciliacion");
            });

            modelBuilder.Entity<CfconciliacionDetalle>(entity =>
            {
                entity.ToTable("CFConciliacionDetalle", "CreditoFarmacia");

                entity.Property(e => e.DescripcionError)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdConciliacionCreditoNavigation)
                    .WithMany(p => p.CfconciliacionDetalle)
                    .HasForeignKey(d => d.IdConciliacionCredito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CFConciliacionDetalle_CFConciliacionCredito");
            });

            modelBuilder.Entity<CfconciliacionLogs>(entity =>
            {
                entity.ToTable("CFConciliacionLogs", "CreditoFarmacia");

                entity.Property(e => e.DatosEnvio).IsUnicode(false);

                entity.Property(e => e.DatosRespuesta).IsUnicode(false);

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.FechaRespuesta).HasColumnType("datetime");

                entity.Property(e => e.Proceso)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubProceso)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CfconfReglaControlDespacho>(entity =>
            {
                entity.HasKey(e => e.TipoTratamiendo);

                entity.ToTable("CFConfReglaControlDespacho", "CreditoFarmacia");

                entity.Property(e => e.TipoTratamiendo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<CfcorreosNotificar>(entity =>
            {
                entity.ToTable("CFCorreosNotificar", "CreditoFarmacia");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePrestador)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cfdiagnostico>(entity =>
            {
                entity.ToTable("CFDiagnostico", "CreditoFarmacia");

                entity.Property(e => e.CodigoDiagnostico)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDiagnostico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.Cfdiagnostico)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiagnosticoSolicitud");
            });

            modelBuilder.Entity<CfdiagnosticoRechazo>(entity =>
            {
                entity.ToTable("CFDiagnosticoRechazo", "CreditoFarmacia");

                entity.Property(e => e.CodigoDiagnostico)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDiagnostico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReglaAplicada)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.CfdiagnosticoRechazo)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CFDiagnosticoRechazo_CFSolicitudRechazo");
            });

            modelBuilder.Entity<CferrorConciliacion>(entity =>
            {
                entity.ToTable("CFErrorConciliacion", "CreditoFarmacia");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CferrorConciliacionMi02CausasNoMigrar>(entity =>
            {
                entity.HasKey(e => new { e.IdCferrorConciliacion, e.CodigoCausaProgress });

                entity.ToTable("CFErrorConciliacionMi02CausasNoMigrar", "CreditoFarmacia");

                entity.Property(e => e.IdCferrorConciliacion).HasColumnName("IdCFErrorConciliacion");

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCferrorConciliacionNavigation)
                    .WithMany(p => p.CferrorConciliacionMi02CausasNoMigrar)
                    .HasForeignKey(d => d.IdCferrorConciliacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CFErrorConciliacionMi02CausasNoMigrar_CFErrorConciliacion");
            });

            modelBuilder.Entity<Cfingreso>(entity =>
            {
                entity.ToTable("CFIngreso", "CreditoFarmacia");

                entity.Property(e => e.CodigoIngreso)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataSolicitudIngresoCredito).HasMaxLength(4000);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaConciliacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.Cfingreso)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IngresoSolicitud");
            });

            modelBuilder.Entity<Cfmedicamento>(entity =>
            {
                entity.ToTable("CFMedicamento", "CreditoFarmacia");

                entity.Property(e => e.CodigoBeneficio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProducto)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PrincipioActivo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<CfmedicamentoRechazo>(entity =>
            {
                entity.ToTable("CFMedicamentoRechazo", "CreditoFarmacia");

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProducto)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PrincipioActivo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReglaAplicada)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.CfmedicamentoRechazo)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CFMedicamentoRechazo_CFSolicitudRechazo");
            });

            modelBuilder.Entity<Cfmedicina>(entity =>
            {
                entity.HasKey(e => e.CodigoMedicinaSaludsa);

                entity.ToTable("CFMedicina", "CreditoFarmacia");

                entity.Property(e => e.CodigoMedicinaSaludsa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoBeneficio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBeneficioNuevosPlanes)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PrincipioActivo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTratamiento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CfmedicinaPrestadorProducto>(entity =>
            {
                entity.HasKey(e => new { e.CodigoMedicinaPrestador, e.NumeroConvenio, e.CodigoMedicinaSaludsa, e.IdProducto });

                entity.ToTable("CFMedicinaPrestadorProducto", "CreditoFarmacia");

                entity.Property(e => e.CodigoMedicinaPrestador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMedicinaSaludsa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoMedicinaSaludsaNavigation)
                    .WithMany(p => p.CfmedicinaPrestadorProducto)
                    .HasForeignKey(d => d.CodigoMedicinaSaludsa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditoFarmacia_MedicinaPrestadorProducto_CreditoFarmacia_Medicina");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CfmedicinaPrestadorProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditoFarmacia_MedicinaPrestadorProducto_CreditoFarmacia_Producto");

                entity.HasOne(d => d.Cfprestador)
                    .WithMany(p => p.CfmedicinaPrestadorProducto)
                    .HasForeignKey(d => new { d.CodigoMedicinaPrestador, d.NumeroConvenio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditoFarmacia_MedicinaPrestadorProducto_CreditoFarmacia_Prestador");
            });

            modelBuilder.Entity<CfobservacionSolicitud>(entity =>
            {
                entity.ToTable("CFObservacionSolicitud", "CreditoFarmacia");

                entity.Property(e => e.EstadoConciliacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSolicitud)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaObservacion).HasColumnType("datetime");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Peticion).HasColumnType("text");

                entity.Property(e => e.Respuesta)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cfprestador>(entity =>
            {
                entity.HasKey(e => new { e.CodigoMedicinaPrestador, e.NumeroConvenio });

                entity.ToTable("CFPrestador", "CreditoFarmacia");

                entity.Property(e => e.CodigoMedicinaPrestador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cfproducto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("CFProducto", "CreditoFarmacia");

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cfregla>(entity =>
            {
                entity.HasKey(e => new { e.NumeroConvenio, e.IdProducto, e.NombreRegla });

                entity.ToTable("CFRegla", "CreditoFarmacia");

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreRegla)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Cfregla)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditoFarmacia_Regla");
            });

            modelBuilder.Entity<Cfsolicitud>(entity =>
            {
                entity.ToTable("CFSolicitud", "CreditoFarmacia");

                entity.Property(e => e.CodigoCobertura)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.NombrePaciente)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFactura).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ValorCopago).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<CfsolicitudRechazo>(entity =>
            {
                entity.ToTable("CFSolicitudRechazo", "CreditoFarmacia");

                entity.Property(e => e.CodigoPlan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.NombrePaciente)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReglaAplicada)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CitasMedicasNotificaciones>(entity =>
            {
                entity.ToTable("CitasMedicasNotificaciones", "ServiciosMedicos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CodigoCitaCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEspecialidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMedicoCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSucursalCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoNotificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.DescripcionEspecialidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionEstadoAtencion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.EsOnline).HasColumnName("esOnline");

                entity.Property(e => e.EstadoEnvio)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdHorarioDisponible)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Latitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.MensajeError).HasMaxLength(1000);

                entity.Property(e => e.NombreCentroMedico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMedicoPrestador)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePaciente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSucursalCentroMedico)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegistradoPor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UrlPago)
                    .HasColumnName("urlPago")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.ToTable("Ciudad", "Catalogo");

                entity.HasIndex(e => new { e.PaisId, e.RegionId, e.ProvinciaId })
                    .HasName("IdxCiudad01");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ciudad_Pais");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ciudad_Provincia");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Ciudad)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ciudad_Region");
            });

            modelBuilder.Entity<Ciudad1>(entity =>
            {
                entity.HasKey(e => e.IdCiudad);

                entity.ToTable("Ciudad", "ProcedimientoGuiaMedica");

                entity.HasIndex(e => e.IdCiudad)
                    .HasName("NombreCiudadUnico")
                    .IsUnique();

                entity.Property(e => e.IdCiudad).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CiudadPrestadorProcedimiento>(entity =>
            {
                entity.HasKey(e => new { e.IdCiudad, e.NumeroConvenio, e.IdProcedimiento });

                entity.ToTable("CiudadPrestadorProcedimiento", "ProcedimientoGuiaMedica");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.CiudadPrestadorProcedimiento)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CiudadPrestadorProcedimiento_Ciudad");

                entity.HasOne(d => d.IdProcedimientoNavigation)
                    .WithMany(p => p.CiudadPrestadorProcedimiento)
                    .HasForeignKey(d => d.IdProcedimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CiudadPrestadorProcedimiento_Procedimiento");

                entity.HasOne(d => d.NumeroConvenioNavigation)
                    .WithMany(p => p.CiudadPrestadorProcedimiento)
                    .HasForeignKey(d => d.NumeroConvenio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CiudadPrestadorProcedimiento_Prestador");
            });

            modelBuilder.Entity<Cl03PersonasAdicional>(entity =>
            {
                entity.HasKey(e => e.PersonaNumero);

                entity.Property(e => e.PersonaNumero).ValueGeneratedNever();

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdPersona).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ClasificacionClientes>(entity =>
            {
                entity.HasKey(e => new { e.FechaCarga, e.CodigoProducto, e.Region, e.NumeroDocumentoBeneficiario, e.ContratoNumero, e.PersonaNumero });

                entity.ToTable("ClasificacionClientes", "SaludsaContigo");

                entity.Property(e => e.FechaCarga).HasColumnType("date");

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoBeneficiario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Categorizacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NombresBeneficiario)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cobertura>(entity =>
            {
                entity.HasIndex(e => e.PolizaId)
                    .HasName("IX_PolizaId");

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Poliza)
                    .WithMany(p => p.Cobertura)
                    .HasForeignKey(d => d.PolizaId)
                    .HasConstraintName("FK_dbo.Cobertura_dbo.Poliza_PolizaId");
            });

            modelBuilder.Entity<CoberturaBeneficio>(entity =>
            {
                entity.HasKey(e => e.IdCoberturaBeneficio)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("CoberturaBeneficio", "GenericoEstructura");

                entity.HasIndex(e => new { e.IdCoberturaSeccion, e.CodigoBeneficio, e.Orden, e.TipoCobertura })
                    .HasName("IX_Beneficio")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.CodigoBeneficio)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Expresion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCoberturaSeccionNavigation)
                    .WithMany(p => p.CoberturaBeneficio)
                    .HasForeignKey(d => d.IdCoberturaSeccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoberturaSeccion_REF_CoberturaBeneficio");
            });

            modelBuilder.Entity<CoberturaDental>(entity =>
            {
                entity.ToTable("CoberturaDental", "CoberturasXPR");

                entity.Property(e => e.CodigoPlan)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TextoDetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoberturaNacInt>(entity =>
            {
                entity.ToTable("CoberturaNacInt", "CoberturasXPR");

                entity.Property(e => e.CodigoPlan)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenCobertura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TextoDetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoberturaNacIntTipoCobertura>(entity =>
            {
                entity.ToTable("CoberturaNacIntTipoCobertura", "CoberturasXPR");

                entity.Property(e => e.SubTipo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCoberturaNacIntNavigation)
                    .WithMany(p => p.CoberturaNacIntTipoCobertura)
                    .HasForeignKey(d => d.IdCoberturaNacInt)
                    .HasConstraintName("FK_CoberturaNacIntTipoCobertura_CoberturaNacInt");

                entity.HasOne(d => d.IdTipoCoberturaNavigation)
                    .WithMany(p => p.CoberturaNacIntTipoCobertura)
                    .HasForeignKey(d => d.IdTipoCobertura)
                    .HasConstraintName("FK_CoberturaNacIntTipoCobertura_TipoCobertura");
            });

            modelBuilder.Entity<CoberturaProducto>(entity =>
            {
                entity.HasKey(e => e.IdCoberturaProducto)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("CoberturaProducto", "GenericoEstructura");

                entity.Property(e => e.CodigoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Experesion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TextoDetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoberturasDent>(entity =>
            {
                entity.ToTable("CoberturasDent", "CoberturasXPR");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCoberturaDentalNavigation)
                    .WithMany(p => p.CoberturasDent)
                    .HasForeignKey(d => d.IdCoberturaDental)
                    .HasConstraintName("FK_CoberturasDent_CoberturaDental");
            });

            modelBuilder.Entity<CoberturaSeccion>(entity =>
            {
                entity.HasKey(e => e.IdCoberturaSeccion);

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TextoDetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoberturaSeccion1>(entity =>
            {
                entity.HasKey(e => e.IdCoberturaSeccion)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("CoberturaSeccion", "GenericoEstructura");

                entity.HasIndex(e => new { e.IdPlanAgrupador, e.CodigoCobertura, e.Orden })
                    .HasName("IX_Cobertura")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.CodigoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Experesion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TextoDetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgrupadorCoberturaNavigation)
                    .WithMany(p => p.CoberturaSeccion1)
                    .HasForeignKey(d => d.IdAgrupadorCobertura)
                    .HasConstraintName("FK_AgrupadorCobertura_REF_CoberturaSeccion");

                entity.HasOne(d => d.IdPlanAgrupadorNavigation)
                    .WithMany(p => p.CoberturaSeccion1)
                    .HasForeignKey(d => d.IdPlanAgrupador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanAgrupador_REF_CoberturaSeccion");
            });

            modelBuilder.Entity<CoberturaSeccionTipo>(entity =>
            {
                entity.HasKey(e => e.IdCoberturaSeccionTipo);

                entity.Property(e => e.Icono)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCoberturaSeccionNavigation)
                    .WithMany(p => p.CoberturaSeccionTipo)
                    .HasForeignKey(d => d.IdCoberturaSeccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoberturaSeccionTipo_CoberturaSeccion");

                entity.HasOne(d => d.IdCoberturaTipoNavigation)
                    .WithMany(p => p.CoberturaSeccionTipo)
                    .HasForeignKey(d => d.IdCoberturaTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoberturaSeccionTipo_CoberturaTipo");
            });

            modelBuilder.Entity<CoberturaSeccionTipoCobertura>(entity =>
            {
                entity.HasKey(e => e.IdCoberturaSeccionTipoCobertura);

                entity.Property(e => e.CodigoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCoberturaSeccionTipoNavigation)
                    .WithMany(p => p.CoberturaSeccionTipoCobertura)
                    .HasForeignKey(d => d.IdCoberturaSeccionTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoberturaSeccionTipoCobertura_CoberturaSeccionTipo");
            });

            modelBuilder.Entity<CoberturaTipo>(entity =>
            {
                entity.HasKey(e => e.IdCoberturaTipo);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Columna>(entity =>
            {
                entity.HasKey(e => e.IdColumna);

                entity.ToTable("Columna", "GenericoEstructura");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreColumna)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePropiedad)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDato)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTablaNavigation)
                    .WithMany(p => p.Columna)
                    .HasForeignKey(d => d.IdTabla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tabla_REF_Columna");
            });

            modelBuilder.Entity<ComentarioInSitu>(entity =>
            {
                entity.ToTable("ComentarioInSitu", "GestionPacientes");

                entity.Property(e => e.Comentario).HasColumnType("text");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithMany(p => p.ComentarioInSitu)
                    .HasForeignKey(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComentarioInSitu_CasoId");
            });

            modelBuilder.Entity<ComoUsarPlanCanalOrigen>(entity =>
            {
                entity.ToTable("ComoUsarPlanCanalOrigen", "AdministracionApp");

                entity.HasIndex(e => e.CanalOrigen)
                    .HasName("IX_ComoUsarPlanCanalOrigen")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CanalOrigen)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComoUsarPlanGuiaUso>(entity =>
            {
                entity.HasKey(e => new { e.IdComoUsarPlanCanalOrigen, e.IdComoUsarPlanProducto });

                entity.ToTable("ComoUsarPlanGuiaUso", "AdministracionApp");

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UrlIcono)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.ComoUsarPlanCanalOrigen)
                    .WithMany(p => p.ComoUsarPlanGuiaUso)
                    .HasForeignKey(d => d.IdComoUsarPlanCanalOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComoUsarPlanGuiaUso_ComoUsarPlanCanalOrigen1");

                entity.HasOne(d => d.ComoUsarPlanProducto)
                    .WithMany(p => p.ComoUsarPlanGuiaUso)
                    .HasForeignKey(d => d.IdComoUsarPlanProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComoUsarPlanGuiaUso_ComoUsarPlanProducto1");
            });

            modelBuilder.Entity<ComoUsarPlanProducto>(entity =>
            {
                entity.ToTable("ComoUsarPlanProducto", "AdministracionApp");

                entity.HasIndex(e => new { e.CodigoProducto, e.CodigoPlan })
                    .HasName("IX_ComoUsarPlanProducto")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfCategoriaShift>(entity =>
            {
                entity.ToTable("ConfCategoriaShift", "ReembolsoBorrador");

                entity.Property(e => e.Categorias)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan).IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.MensajePremio)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plan)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfCentrosMedicos>(entity =>
            {
                entity.HasKey(e => e.NombreCorto);

                entity.ToTable("ConfCentrosMedicos", "ContabilizacionCitas");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ConfCentrosMedicosNotificacion>(entity =>
            {
                entity.HasKey(e => new { e.CodigoNotificacion, e.NombreCorto });

                entity.ToTable("ConfCentrosMedicosNotificacion", "ContabilizacionCitas");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoNotificacionNavigation)
                    .WithMany(p => p.ConfCentrosMedicosNotificacion)
                    .HasForeignKey(d => d.CodigoNotificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConfCentrosMedicosNotificacion_Notificacion");

                entity.HasOne(d => d.NombreCortoNavigation)
                    .WithMany(p => p.ConfCentrosMedicosNotificacion)
                    .HasForeignKey(d => d.NombreCorto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConfCentrosMedicosNotificacion_ConfCentrosMedicos");
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_Codigo")
                    .IsUnique();

                entity.Property(e => e.Codigo).HasColumnType("char(10)");

                entity.Property(e => e.CodigoAgrupador).HasColumnType("char(10)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Valor)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracionCargaEstadoCuenta>(entity =>
            {
                entity.HasKey(e => e.CodigoBanco);

                entity.Property(e => e.CodigoBanco).ValueGeneratedNever();

                entity.Property(e => e.CaracteresAeliminar)
                    .HasColumnName("CaracteresAEliminar")
                    .HasMaxLength(150);

                entity.Property(e => e.FormatoArchivo).HasMaxLength(10);

                entity.Property(e => e.IdentificadorCredito).HasMaxLength(15);

                entity.Property(e => e.SeparadorColumnas).HasMaxLength(5);

                entity.Property(e => e.SeparadorDecimales).HasMaxLength(1);

                entity.Property(e => e.SeparadorMiles).HasMaxLength(1);
            });

            modelBuilder.Entity<ConfiguracionEnvioNotificaciones>(entity =>
            {
                entity.ToTable("ConfiguracionEnvioNotificaciones", "ServiciosMedicos");

                entity.Property(e => e.CentroMedicoIdExc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CentroMedicoIdInc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionNotificacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NivelReferencia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCortoCm)
                    .HasColumnName("NombreCortoCM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCita).HasColumnType("char(1)");
            });

            modelBuilder.Entity<ConfiguracionPantalla>(entity =>
            {
                entity.ToTable("ConfiguracionPantalla", "AdministracionApp");

                entity.HasIndex(e => new { e.CodigoProducto, e.CodigoPlan })
                    .HasName("IX_ConfiguracionPantalla")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataInformacion)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracionPantallaGenerica>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.CodigoPlan, e.Funcionalidad, e.Personalizacion });

                entity.ToTable("ConfiguracionPantallaGenerica", "AdministracionApp");

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Funcionalidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Personalizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlanExcepsion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracionPrestadorSrvCita>(entity =>
            {
                entity.ToTable("ConfiguracionPrestadorSrvCita", "ServiciosMedicos");

                entity.HasIndex(e => e.PrestadorId)
                    .HasName("ConfiguracionPrestadorSrvCita01")
                    .IsUnique();

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EstadoActivo).HasDefaultValueSql("('1')");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Urlaut)
                    .IsRequired()
                    .HasColumnName("URLAut")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Urlbase)
                    .IsRequired()
                    .HasColumnName("URLBase")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.Prestador)
                    .WithOne(p => p.ConfiguracionPrestadorSrvCita)
                    .HasForeignKey<ConfiguracionPrestadorSrvCita>(d => d.PrestadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConfiguracionPrestadorSrvCita_Prestador");
            });

            modelBuilder.Entity<ConfParametrosConsultas>(entity =>
            {
                entity.HasKey(e => new { e.IdCiudad, e.NombreCorto, e.CodigoAlphaEspecialidad });

                entity.ToTable("ConfParametrosConsultas", "ContabilizacionCitas");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAlphaEspecialidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.NombreCortoNavigation)
                    .WithMany(p => p.ConfParametrosConsultas)
                    .HasForeignKey(d => d.NombreCorto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConfParametrosConsultas_ConfCentrosMedicos");
            });

            modelBuilder.Entity<ContabilizacionCitasMedicas>(entity =>
            {
                entity.ToTable("ContabilizacionCitasMedicas", "ContabilizacionCitas");

                entity.Property(e => e.CodigoAlphaEspecialidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSucursal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCita).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.HoraFin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoraInicio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificadorProceso)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCiudad)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEspecialidad)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMedico)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSucursal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConfParametrosConsultas)
                    .WithMany(p => p.ContabilizacionCitasMedicas)
                    .HasForeignKey(d => new { d.IdCiudad, d.NombreCorto, d.CodigoAlphaEspecialidad })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ContabilizacionC__770C69D1");
            });

            modelBuilder.Entity<ContactoGesPacientes>(entity =>
            {
                entity.HasKey(e => e.CasoId);

                entity.ToTable("ContactoGesPacientes", "GestionPacientes");

                entity.Property(e => e.CasoId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PersonaQueLlamo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caso)
                    .WithOne(p => p.ContactoGesPacientes)
                    .HasForeignKey<ContactoGesPacientes>(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contacto_Caso");
            });

            modelBuilder.Entity<ContenidoVisor>(entity =>
            {
                entity.HasKey(e => e.NombreContenido);

                entity.ToTable("ContenidoVisor", "Mfiles");

                entity.Property(e => e.NombreContenido)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoAplicacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContratoGesPacientes>(entity =>
            {
                entity.ToTable("ContratoGesPacientes", "GestionPacientes");

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlCita>(entity =>
            {
                entity.ToTable("ControlCita", "ServiciosMedicos");

                entity.HasIndex(e => new { e.TitularContratoId, e.PacienteId, e.EstadoAtencionId })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.Property(e => e.CantidadIntentosAnulacion).HasDefaultValueSql("((3))");

                entity.Property(e => e.CodigoAplicacion).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoCitaCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEspecialidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoMedicoCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSucursalCentroMedico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoNotificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCiudad).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdHorarioDisponible)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Latitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.NombreMedicoPrestador)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePaciente)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreSucursalCentroMedico)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumeroContrato).HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroPersonaPaciente).HasDefaultValueSql("((0))");

                entity.Property(e => e.PagoEstado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PagoFechaCitaEliminada).HasColumnType("datetime");

                entity.Property(e => e.PagoFechaLimite).HasColumnType("datetime");

                entity.Property(e => e.PagoFechaParaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.RegistradoPor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UrlPago)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ValorDescuento).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ValorDescuentoTexto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValorTotalConDescuentoTexto)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlCitas>(entity =>
            {
                entity.Property(e => e.CodigoCitaCentroMedico).IsUnicode(false);

                entity.Property(e => e.CodigoEspecialidad).IsUnicode(false);

                entity.Property(e => e.CodigoMedicoCentroMedico).IsUnicode(false);

                entity.Property(e => e.CodigoSucursalCentroMedico).IsUnicode(false);

                entity.Property(e => e.CorreoNotificacion).IsUnicode(false);

                entity.Property(e => e.Costo).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdHorarioDisponible).IsUnicode(false);

                entity.Property(e => e.Latitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.NombreMedicoPrestador).IsUnicode(false);

                entity.Property(e => e.NombrePaciente).IsUnicode(false);

                entity.Property(e => e.NombreSucursalCentroMedico).IsUnicode(false);

                entity.Property(e => e.RegistradoPor).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<CoordinaLlamada>(entity =>
            {
                entity.ToTable("CoordinaLlamada", "Telemedicina");

                entity.Property(e => e.CelularContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCiudad)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NombreBeneficiario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCiudad)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorreosPrestador>(entity =>
            {
                entity.ToTable("CorreosPrestador", "Liquidaciones");

                entity.Property(e => e.CorreoPrestador)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CredencialesVisor>(entity =>
            {
                entity.HasKey(e => e.Usuario);

                entity.ToTable("CredencialesVisor", "Mfiles");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Contrasenia)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CreditoMedNpproducto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("CreditoMedNPProducto", "MedicinaNuevosProductos");

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CredMedNpmedicina>(entity =>
            {
                entity.HasKey(e => e.CodigoMedicinaSaludsa);

                entity.ToTable("CredMedNPMedicina", "MedicinaNuevosProductos");

                entity.Property(e => e.CodigoMedicinaSaludsa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PrincipioActivo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTratamiento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CredMedNpmedicinaPrestadorProducto>(entity =>
            {
                entity.HasKey(e => new { e.CodigoMedicinaPrestador, e.NumeroConvenio, e.CodigoMedicinaSaludsa, e.IdProducto });

                entity.ToTable("CredMedNPMedicinaPrestadorProducto", "MedicinaNuevosProductos");

                entity.Property(e => e.CodigoMedicinaPrestador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMedicinaSaludsa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoMedicinaSaludsaNavigation)
                    .WithMany(p => p.CredMedNpmedicinaPrestadorProducto)
                    .HasForeignKey(d => d.CodigoMedicinaSaludsa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CredMedNPMedicinaPrestadorProducto_CredMedNPMedicina");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CredMedNpmedicinaPrestadorProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CredMedNPMedicinaPrestadorProducto_CreditoMedNPProducto");

                entity.HasOne(d => d.CredMedNpprestador)
                    .WithMany(p => p.CredMedNpmedicinaPrestadorProducto)
                    .HasForeignKey(d => new { d.CodigoMedicinaPrestador, d.NumeroConvenio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CredMedNPMedicinaPrestadorProducto_CredMedNPPrestador");
            });

            modelBuilder.Entity<CredMedNpprestador>(entity =>
            {
                entity.HasKey(e => new { e.CodigoMedicinaPrestador, e.NumeroConvenio });

                entity.ToTable("CredMedNPPrestador", "MedicinaNuevosProductos");

                entity.Property(e => e.CodigoMedicinaPrestador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Criterio>(entity =>
            {
                entity.HasIndex(e => e.CatalogoEsTitularId)
                    .HasName("IX_CatalogoEsTitularId");

                entity.HasIndex(e => e.CatalogoGeneroId)
                    .HasName("IX_CatalogoGeneroId");

                entity.HasIndex(e => e.CatalogoProductoId)
                    .HasName("IX_CatalogoProductoId");

                entity.HasIndex(e => e.CatalogoRegionId)
                    .HasName("IX_CatalogoRegionId");

                entity.HasIndex(e => e.CatalogoRelacionId)
                    .HasName("IX_CatalogoRelacionId");

                entity.HasIndex(e => e.PolizaId)
                    .HasName("IX_PolizaId");

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.CatalogoEsTitular)
                    .WithMany(p => p.CriterioCatalogoEsTitular)
                    .HasForeignKey(d => d.CatalogoEsTitularId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoEsTitularId");

                entity.HasOne(d => d.CatalogoGenero)
                    .WithMany(p => p.CriterioCatalogoGenero)
                    .HasForeignKey(d => d.CatalogoGeneroId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoGeneroId");

                entity.HasOne(d => d.CatalogoProducto)
                    .WithMany(p => p.CriterioCatalogoProducto)
                    .HasForeignKey(d => d.CatalogoProductoId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoProductoId");

                entity.HasOne(d => d.CatalogoRegion)
                    .WithMany(p => p.CriterioCatalogoRegion)
                    .HasForeignKey(d => d.CatalogoRegionId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoRegionId");

                entity.HasOne(d => d.CatalogoRelacion)
                    .WithMany(p => p.CriterioCatalogoRelacion)
                    .HasForeignKey(d => d.CatalogoRelacionId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.CatalogoGeneral_CatalogoRelacionId");

                entity.HasOne(d => d.Poliza)
                    .WithMany(p => p.Criterio)
                    .HasForeignKey(d => d.PolizaId)
                    .HasConstraintName("FK_dbo.Criterio_dbo.Poliza_PolizaId");
            });

            modelBuilder.Entity<CriterioValor>(entity =>
            {
                entity.HasIndex(e => e.CriterioId)
                    .HasName("IX_CriterioId");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Criterio)
                    .WithMany(p => p.CriterioValor)
                    .HasForeignKey(d => d.CriterioId)
                    .HasConstraintName("FK_dbo.CriterioValor_dbo.Criterio_CriterioId");
            });

            modelBuilder.Entity<DatosBeneficiarioScore>(entity =>
            {
                entity.ToTable("DatosBeneficiarioScore", "Score");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaTransaccion).HasColumnType("datetime");

                entity.Property(e => e.Genero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Score).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosReembolso>(entity =>
            {
                entity.HasKey(e => e.ReembolsoId);

                entity.ToTable("DatosReembolso", "ReembolsoBorrador");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaExpiracion).HasColumnType("datetime");

                entity.Property(e => e.NotasAdicionales)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenReembolso)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QueReembolsar)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Secuencial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosVentaDigital>(entity =>
            {
                entity.ToTable("DatosVentaDigital", "VentaDigital");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DatosAdicionales).HasColumnType("text");

                entity.Property(e => e.FechaNacimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaTransaccion).HasColumnType("datetime");

                entity.Property(e => e.Genero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeducibleProducto>(entity =>
            {
                entity.HasKey(e => e.IdDeducibleProducto)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DeducibleProducto", "GenericoEstructura");

                entity.Property(e => e.CodigoDeducible)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Expresion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TextoDetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeducibleSeccion>(entity =>
            {
                entity.HasKey(e => e.IdDeducibleSeccion)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DeducibleSeccion", "GenericoEstructura");

                entity.Property(e => e.CodigoDeducible)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Expresion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TextoDetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobertura)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPlanAgrupadorNavigation)
                    .WithMany(p => p.DeducibleSeccion)
                    .HasForeignKey(d => d.IdPlanAgrupador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanAgrupador_REF_DeducibleSeccion");
            });

            modelBuilder.Entity<DetalleConfiguracionEnvioNotificaciones>(entity =>
            {
                entity.ToTable("DetalleConfiguracionEnvioNotificaciones", "ServiciosMedicos");

                entity.Property(e => e.AsuntoPersonalizado)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMensaje)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstadosEntidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoraEnvio)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HoraFin)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HoraInicio)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartamentoMensaje)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdEnvioMensaje)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlantillaCorreoElectronico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoEnvioMensaje)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoEnvioMensaje)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEnvio).HasColumnType("char(1)");

                entity.HasOne(d => d.IdConfiguracionEnvioNotificacionesNavigation)
                    .WithMany(p => p.DetalleConfiguracionEnvioNotificaciones)
                    .HasForeignKey(d => d.IdConfiguracionEnvioNotificaciones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_ConfiguracionEnvioNotificaciones");
            });

            modelBuilder.Entity<DetallesCoberturaDent>(entity =>
            {
                entity.ToTable("DetallesCoberturaDent", "CoberturasXPR");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCoberturasNavigation)
                    .WithMany(p => p.DetallesCoberturaDent)
                    .HasForeignKey(d => d.IdCoberturas)
                    .HasConstraintName("FK_DetallesCoberturaDent_CoberturasDent");
            });

            modelBuilder.Entity<Diagnosticos>(entity =>
            {
                entity.ToTable("Diagnosticos", "Digital");

                entity.Property(e => e.Cie10)
                    .HasColumnName("CIE10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoPrimario)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpresaTercerizada>(entity =>
            {
                entity.ToTable("EmpresaTercerizada", "Seguridad");

                entity.HasIndex(e => e.Codigo)
                    .HasName("AK_EmpresaTercerizada_Codigo")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Encuesta>(entity =>
            {
                entity.HasKey(e => e.CasoId);

                entity.ToTable("Encuesta", "GestionPacientes");

                entity.Property(e => e.CasoId).ValueGeneratedNever();

                entity.Property(e => e.FechaEncuesta).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MotivoCalifEstancia).HasColumnType("text");

                entity.Property(e => e.MotivoCalifHospitalization).HasColumnType("text");

                entity.Property(e => e.MotivoCalificacion).HasColumnType("text");

                entity.HasOne(d => d.Caso)
                    .WithOne(p => p.Encuesta)
                    .HasForeignKey<Encuesta>(d => d.CasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encuesta_Caso");
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.ToTable("Entidad", "Entidad");

                entity.HasIndex(e => e.TipoEntidadId)
                    .HasName("IdxEntidad01");

                entity.HasOne(d => d.TipoEntidad)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.TipoEntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Entidad_TipoEntidad");
            });

            modelBuilder.Entity<Equivalencia>(entity =>
            {
                entity.ToTable("Equivalencia", "Homologacion");

                entity.HasIndex(e => new { e.EntidadId, e.TematicaId, e.CodigoExterno })
                    .HasName("IdxEquivalencia01")
                    .IsUnique();

                entity.HasIndex(e => new { e.EntidadId, e.TematicaId, e.CodigoHomologado })
                    .HasName("IdxEquivalencia02");

                entity.Property(e => e.CodigoAlfaHomologado)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoExterno)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoHomologado).HasDefaultValueSql("((-1))");

                entity.Property(e => e.DescripcionExterna)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DescripcionHomologada)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Entidad)
                    .WithMany(p => p.Equivalencia)
                    .HasForeignKey(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equivalencia_Entidad");

                entity.HasOne(d => d.Tematica)
                    .WithMany(p => p.Equivalencia)
                    .HasForeignKey(d => d.TematicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equivalencia_Tematica");
            });

            modelBuilder.Entity<EquivalenciaEntidadPersona>(entity =>
            {
                entity.ToTable("EquivalenciaEntidadPersona", "Homologacion");

                entity.HasIndex(e => new { e.EntidadId, e.CodigoExterno })
                    .HasName("IdxEquivalenciaEntidadPersona01")
                    .IsUnique();

                entity.HasIndex(e => new { e.EntidadId, e.PersonaId })
                    .HasName("IdxEquivalenciaEntidadPersona02")
                    .IsUnique();

                entity.Property(e => e.CodigoExterno)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entidad)
                    .WithMany(p => p.EquivalenciaEntidadPersona)
                    .HasForeignKey(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquivalenciaEntidadPersona_Entidad");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.EquivalenciaEntidadPersona)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquivalenciaEntidadPersona_Persona");
            });

            modelBuilder.Entity<EquivalenciaRolLdap>(entity =>
            {
                entity.ToTable("EquivalenciaRolLDAP", "Seguridad");

                entity.HasIndex(e => new { e.RolId, e.NombreGrupoLdap })
                    .HasName("IdxEquivalenciaRolLDAP01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NombreGrupoLdap)
                    .IsRequired()
                    .HasColumnName("NombreGrupoLDAP")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.EquivalenciaRolLdap)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquivalenciaRolLDAP_Rol");
            });

            modelBuilder.Entity<EquivalenciaUsuarioLdap>(entity =>
            {
                entity.ToTable("EquivalenciaUsuarioLDAP", "Seguridad");

                entity.HasIndex(e => new { e.UsuarioId, e.NombreUsuarioLdap })
                    .HasName("IdxEquivalenciaUsuarioLDAP01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NombreUsuarioLdap)
                    .IsRequired()
                    .HasColumnName("NombreUsuarioLDAP")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.EquivalenciaUsuarioLdap)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquivalenciaUsuarioLDAP_Usuario");
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.HasIndex(e => e.ErrorTipo)
                    .HasName("IX_ErrorTipo");

                entity.HasIndex(e => e.ResumenId)
                    .HasName("IX_ResumenId");

                entity.HasIndex(e => e.Tipo)
                    .HasName("IX_Tipo");

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorTipo).HasColumnType("char(3)");

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.Tipo).HasColumnType("char(3)");

                entity.HasOne(d => d.Resumen)
                    .WithMany(p => p.Error)
                    .HasForeignKey(d => d.ResumenId)
                    .HasConstraintName("FK_dbo.Error_dbo.Resumen_ResumenId");
            });

            modelBuilder.Entity<EspecialidadCiudad>(entity =>
            {
                entity.ToTable("EspecialidadCiudad", "Catalogo");

                entity.HasIndex(e => new { e.CiudadId, e.EspecialidadId, e.PrestadorId })
                    .HasName("IX_EspecialidadCiudad")
                    .IsUnique();

                entity.Property(e => e.EstadoActivo).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.EspecialidadCiudad)
                    .HasForeignKey(d => d.CiudadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadCiudad_Ciudad");

                entity.HasOne(d => d.Especialidad)
                    .WithMany(p => p.EspecialidadCiudad)
                    .HasForeignKey(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadCiudad_Especialidad");

                entity.HasOne(d => d.Prestador)
                    .WithMany(p => p.EspecialidadCiudad)
                    .HasForeignKey(d => d.PrestadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadCiudad_Prestador");
            });

            modelBuilder.Entity<EspecialidadMedica>(entity =>
            {
                entity.ToTable("EspecialidadMedica", "Catalogo");

                entity.HasIndex(e => e.CodigoAlfa)
                    .HasName("IdxEspecialidadMedica01")
                    .IsUnique();

                entity.Property(e => e.CodigoAlfa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoAtencion>(entity =>
            {
                entity.ToTable("EstadoAtencion", "ServiciosMedicos");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoCuentaBancaria>(entity =>
            {
                entity.HasKey(e => new { e.CodigoBanco, e.Fecha, e.Documento, e.Saldo });

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Documento).HasMaxLength(50);

                entity.Property(e => e.Saldo).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Codigo).HasMaxLength(50);

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Monto).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Tipo).HasMaxLength(2);
            });

            modelBuilder.Entity<ExcepcionCita>(entity =>
            {
                entity.ToTable("ExcepcionCita", "ServiciosMedicos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CodigoExcepcion).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCitaOrigen).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdNuevaCita).HasDefaultValueSql("((0))");

                entity.Property(e => e.MotivoExcepcion).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FacturaCitaMedica>(entity =>
            {
                entity.ToTable("FacturaCitaMedica", "ServiciosMedicos");

                entity.Property(e => e.ApellidosCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Caja)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCompania)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoFormaPago)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleError).HasColumnType("text");

                entity.Property(e => e.DireccionCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCabeceraFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaCrearClienteFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaDetalleFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaDetallePago).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminarFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaFactura).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistroFactura).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificacionCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MarcaTarjeta)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombresCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaPago)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RespuestaRegistraFactura).HasColumnType("text");

                entity.Property(e => e.TelefonoCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacionCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoOrganizacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTarjeta)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormularioHospitalario>(entity =>
            {
                entity.ToTable("FormularioHospitalario", "FormularioHospitalario");

                entity.Property(e => e.CanalOrigen)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CelularBeneficiario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDiagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProcedimiento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioEstadoAutorizacionHospitalario)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoAcompanante)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoBeneficiario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoCajero).HasMaxLength(200);

                entity.Property(e => e.FechaAutorizacionHospitalaria).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvioMailAdicional).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvioMailCliente).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvioMailPrestador).HasColumnType("datetime");

                entity.Property(e => e.FechaProcedimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.MailAdicional)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MedicoTratante)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.MontoAutorizado).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NombreCajero).HasMaxLength(200);

                entity.Property(e => e.NombreCiudad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDiagnostico)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePrestador)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProcedimiento)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombresAcompanante)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombresBeneficiario)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombresTitular)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoAcompanante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSolicitud)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTratamiento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UrlTicketZendesk)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCanalOrigen)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Funcionalidad>(entity =>
            {
                entity.ToTable("Funcionalidad", "Seguridad");

                entity.HasIndex(e => new { e.ProductoId, e.ModuloId, e.Codigo })
                    .HasName("IdxFuncionalidad01")
                    .IsUnique();

                entity.HasIndex(e => new { e.ProductoId, e.ModuloId, e.RutaBase, e.RutaSecundaria, e.RutaAdicional })
                    .HasName("IdxFuncionalidad02");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RutaAdicional)
                    .HasMaxLength(265)
                    .IsUnicode(false);

                entity.Property(e => e.RutaBase)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RutaSecundaria)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Modulo)
                    .WithMany(p => p.Funcionalidad)
                    .HasForeignKey(d => d.ModuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Funcionalidad_Modulo");
            });

            modelBuilder.Entity<FuncionarioPrestador>(entity =>
            {
                entity.ToTable("FuncionarioPrestador", "GestionPacientes");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gap>(entity =>
            {
                entity.HasIndex(e => e.BeneficiarioCedula)
                    .HasName("IX_BeneficiarioCedula");

                entity.HasIndex(e => e.ResumenId)
                    .HasName("IX_ResumenId");

                entity.HasIndex(e => e.Tipo)
                    .HasName("IX_Tipo");

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Tipo).HasColumnType("char(3)");

                entity.HasOne(d => d.Resumen)
                    .WithMany(p => p.GapNavigation)
                    .HasForeignKey(d => d.ResumenId)
                    .HasConstraintName("FK_dbo.Gap_dbo.Resumen_ResumenId");
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("Grupo", "GestionContenido");

                entity.Property(e => e.IdGrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaDesactivacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grupo1>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("Grupo");

                entity.Property(e => e.IdGrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreación).HasColumnType("datetime");

                entity.Property(e => e.FechaDesactivacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grupo2>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("Grupo", "Noticias");

                entity.Property(e => e.IdGrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaDesactivacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrupoNoticias>(entity =>
            {
                entity.HasKey(e => e.IdGrupoNoticias);

                entity.ToTable("GrupoNoticias", "Noticias");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdGrupo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.GrupoNoticias)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoNoticias_Grupo");

                entity.HasOne(d => d.IdNoticiaNavigation)
                    .WithMany(p => p.GrupoNoticias)
                    .HasForeignKey(d => d.IdNoticia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoNoticias_Noticia");
            });

            modelBuilder.Entity<GrupoProductoPlan>(entity =>
            {
                entity.HasKey(e => e.IdGrupoProductoPlan);

                entity.ToTable("GrupoProductoPlan", "Noticias");

                entity.Property(e => e.IdGrupoProductoPlan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaDesactivacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdGrupo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.GrupoProductoPlan)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoProductoPlan_Grupo");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.GrupoProductoPlan)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoProductoPlan_Planes");
            });

            modelBuilder.Entity<GrupoProductoPlan1>(entity =>
            {
                entity.HasKey(e => e.IdGrupoProductoPlan);

                entity.ToTable("GrupoProductoPlan", "GestionContenido");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaDesactivacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdGrupo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlan)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.IdProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.GrupoProductoPlan1)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoProductoPlan_Productos");
            });

            modelBuilder.Entity<HomologacionEstados>(entity =>
            {
                entity.HasKey(e => new { e.EstadoZendesk, e.EstadoCliente });

                entity.ToTable("HomologacionEstados", "Quejas");

                entity.Property(e => e.EstadoZendesk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImagenOrdenAtencion>(entity =>
            {
                entity.HasKey(e => e.CodigoImagen);

                entity.ToTable("ImagenOrdenAtencion", "Liquidaciones");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoOrdenAtencionNavigation)
                    .WithMany(p => p.ImagenOrdenAtencion)
                    .HasForeignKey(d => d.CodigoOrdenAtencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ImagenOrd__Codig__778AC167");
            });

            modelBuilder.Entity<InclusionExclusionDiaria>(entity =>
            {
                entity.ToTable("InclusionExclusionDiaria", "SincronizacionPrestador");

                entity.HasIndex(e => e.Fecha)
                    .HasName("IdxInclusionExclusionDiaria02");

                entity.HasIndex(e => e.MensajeError)
                    .HasName("IdxInclusionExclusionDiaria03");

                entity.HasIndex(e => new { e.NumeroConvenio, e.NumeroPersona, e.InclusionExclusion, e.Reintento, e.CodigoMovimiento })
                    .HasName("IdxInclusionExclusionDiaria01")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvioPrestador).HasColumnType("datetime");

                entity.Property(e => e.FechaProcesada).HasColumnType("datetime");

                entity.Property(e => e.InclusionExclusion)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MensajeError)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reintento).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InformacionPrestador>(entity =>
            {
                entity.HasKey(e => e.IdInformacionPrestador);

                entity.ToTable("InformacionPrestador", "Digital");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TokenAutenticacion).HasMaxLength(500);

                entity.Property(e => e.UrlBaseServicio)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstruccionEntrega>(entity =>
            {
                entity.ToTable("InstruccionEntrega", "Certificado");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CallePrincipal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CalleSecundaria)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Canton)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionOficina)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionTitularContrato).HasColumnType("text");

                entity.Property(e => e.EntregaPersonalizada)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FuncionarioOficina)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDomicilio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OficinaEntrega)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionOficina)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoContacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCertificadoNavigation)
                    .WithMany(p => p.InstruccionEntrega)
                    .HasForeignKey(d => d.IdCertificado)
                    .HasConstraintName("FK_InstruccionEntrega_Certificado");
            });

            modelBuilder.Entity<ItemCatalogo>(entity =>
            {
                entity.ToTable("ItemCatalogo", "Configuracion");

                entity.HasIndex(e => e.Codigo)
                    .HasName("AK_Codigo_ItemCatalogo")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catalogo)
                    .WithMany(p => p.ItemCatalogo)
                    .HasForeignKey(d => d.CatalogoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemCatalogo_Catalogo");
            });

            modelBuilder.Entity<ListaCoberturasNacInt>(entity =>
            {
                entity.ToTable("ListaCoberturasNacInt", "CoberturasXPR");

                entity.Property(e => e.Icono)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCoberturaNacIntTipoCoberturaNavigation)
                    .WithMany(p => p.ListaCoberturasNacInt)
                    .HasForeignKey(d => d.IdCoberturaNacIntTipoCobertura)
                    .HasConstraintName("FK_ListaCoberturasNacInt_CoberturaNacIntTipoCobertura");
            });

            modelBuilder.Entity<LotePago>(entity =>
            {
                entity.ToTable("LotePago", "Liquidaciones");

                entity.HasIndex(e => new { e.Id, e.FechaEmision, e.NumeroConvenioPrestador, e.UsuarioGeneradorId })
                    .HasName("IdxLotePago01");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.HasOne(d => d.UsuarioGenerador)
                    .WithMany(p => p.LotePago)
                    .HasForeignKey(d => d.UsuarioGeneradorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LotePago_UsuarioGenerador");
            });

            modelBuilder.Entity<LotePagoDetalle>(entity =>
            {
                entity.HasKey(e => new { e.LotePagoId, e.ReclamoId });

                entity.ToTable("LotePagoDetalle", "Liquidaciones");

                entity.HasIndex(e => new { e.LotePagoId, e.ReclamoId, e.EstadoPagado })
                    .HasName("IdxLotePagoDetalle01");

                entity.Property(e => e.MontoSaludsa).HasColumnType("money");

                entity.HasOne(d => d.LotePago)
                    .WithMany(p => p.LotePagoDetalle)
                    .HasForeignKey(d => d.LotePagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LotePagoDetalle_LotePago");
            });

            modelBuilder.Entity<LotePagoFacturas>(entity =>
            {
                entity.HasKey(e => e.ImagenFacturaId);

                entity.ToTable("LotePagoFacturas", "Liquidaciones");

                entity.Property(e => e.ClaveAccesoFactura)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvioFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivoRide)
                    .IsRequired()
                    .HasColumnName("NombreArchivoRIDE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoXml)
                    .IsRequired()
                    .HasColumnName("NombreArchivoXML")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreOriginalArchivoRide)
                    .HasColumnName("NombreOriginalArchivoRIDE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreOriginalArchivoXml)
                    .HasColumnName("NombreOriginalArchivoXML")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TicketZendesk)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UrlArchivoRide)
                    .IsRequired()
                    .HasColumnName("UrlArchivoRIDE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlArchivoXml)
                    .IsRequired()
                    .HasColumnName("UrlArchivoXML")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.LotePago)
                    .WithMany(p => p.LotePagoFacturas)
                    .HasForeignKey(d => d.LotePagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Factura__LotePago__Id778AC168");
            });

            modelBuilder.Entity<MasivoMovimiento>(entity =>
            {
                entity.Property(e => e.CodigoProductoSigmep)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegionSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoServicioSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MovimientoDatoAnterior)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.MovimientoFecha).HasColumnType("datetime");

                entity.Property(e => e.MovimientoFechaEfecto).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasivoServicioAdicional>(entity =>
            {
                entity.Property(e => e.BeneficiarioApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioFechaDigitacion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaExclusion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaInclusion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioPasaporte)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoGeneroSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProductoSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegionSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoServicioSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContratoFechaDigitacion).HasColumnType("datetime");

                entity.Property(e => e.ContratoFechaFin).HasColumnType("datetime");

                entity.Property(e => e.ContratoFechaInicio).HasColumnType("datetime");

                entity.Property(e => e.ServicioFechaFin).HasColumnType("datetime");

                entity.Property(e => e.ServicioFechaInicio).HasColumnType("datetime");

                entity.Property(e => e.TitularApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TitularCedula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitularNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TitularPasaporte)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MensajeError>(entity =>
            {
                entity.ToTable("MensajeError", "Administracion");

                entity.HasIndex(e => e.Codigo)
                    .HasName("UX_MensajeError")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MensajeExterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MensajeInterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalParametros).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.ToTable("Modulo", "Seguridad");

                entity.HasIndex(e => new { e.EntidadRelacionadaId, e.Nombre })
                    .HasName("IdxModulo01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MotivoRequerimiento>(entity =>
            {
                entity.ToTable("MotivoRequerimiento", "Quejas");

                entity.HasIndex(e => new { e.Motivo, e.IdTipoRequerimiento })
                    .HasName("DetalleRequerimientoUnico")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EtiquetaZendesk)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoRequerimientoNavigation)
                    .WithMany(p => p.MotivoRequerimiento)
                    .HasForeignKey(d => d.IdTipoRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleRequerimiento_TipoRequerimiento");
            });

            modelBuilder.Entity<Movimiento>(entity =>
            {
                entity.HasIndex(e => e.ResumenId)
                    .HasName("IX_ResumenId");

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProductoSigmep)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegionSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoServicioSigmep)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.MovimientoDatoAnterior)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.MovimientoFecha).HasColumnType("datetime");

                entity.Property(e => e.MovimientoFechaEfecto).HasColumnType("datetime");

                entity.Property(e => e.Tipo).HasColumnType("char(3)");

                entity.HasOne(d => d.Resumen)
                    .WithMany(p => p.Movimiento)
                    .HasForeignKey(d => d.ResumenId)
                    .HasConstraintName("FK_dbo.Movimiento_dbo.Resumen_ResumenId");
            });

            modelBuilder.Entity<Niveles>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.CodigoNivelesNavigation)
                    .WithMany(p => p.InverseCodigoNivelesNavigation)
                    .HasForeignKey(d => d.CodigoNiveles)
                    .HasConstraintName("FK_Niveles_CodigoNiveles_Niveles_Codigo");
            });

            modelBuilder.Entity<Noticia>(entity =>
            {
                entity.HasKey(e => e.IdNoticia);

                entity.ToTable("Noticia", "Noticias");

                entity.Property(e => e.CuerpoNoticia)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.EtiquetaNoticia)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaPublicadoFin).HasColumnType("datetime");

                entity.Property(e => e.FechaPublicadoInicio).HasColumnType("datetime");

                entity.Property(e => e.SubtituloNoticia)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TituloNoticia)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UrlImagen)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistrador)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Noticia)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Noticia_CatalogoCategorias");
            });

            modelBuilder.Entity<Noticia1>(entity =>
            {
                entity.ToTable("Noticia");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Etiquetas)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFinPublicacion).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioPublicacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ImagenUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Subtitulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Noticia2>(entity =>
            {
                entity.ToTable("Noticia", "GestionContenido");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Contenido)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.EstadoActivo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Etiquetas)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Funcionalidad)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Subtitulo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TipoLayout)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UrlImagen)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(30);
            });

            modelBuilder.Entity<Notificacion>(entity =>
            {
                entity.HasKey(e => e.CodigoNotificacion);

                entity.ToTable("Notificacion", "ContabilizacionCitas");

                entity.Property(e => e.CodigoNotificacion).ValueGeneratedNever();

                entity.Property(e => e.CorreoNotificacion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotificacionTerminosCondiciones>(entity =>
            {
                entity.ToTable("NotificacionTerminosCondiciones", "Administracion");

                entity.Property(e => e.DireccionIp)
                    .IsRequired()
                    .HasColumnType("nchar(15)");

                entity.Property(e => e.DispositivoNavegador)
                    .IsRequired()
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.FechaNotificacion).HasColumnType("datetime");

                entity.Property(e => e.SistemaOperativo)
                    .IsRequired()
                    .HasColumnType("nchar(50)");
            });

            modelBuilder.Entity<ObservacionCanales>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoCanalesNavigation)
                    .WithMany(p => p.ObservacionCanales)
                    .HasForeignKey(d => d.CodigoCanales)
                    .HasConstraintName("FK_ObservacionCanales_CodigoCanales_Canales_Codigo");
            });

            modelBuilder.Entity<ObservacionNiveles>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoNivelesNavigation)
                    .WithMany(p => p.ObservacionNiveles)
                    .HasForeignKey(d => d.CodigoNiveles)
                    .HasConstraintName("FK_ObservacionNiveles_CodigoNiveles_Niveles_Codigo");
            });

            modelBuilder.Entity<ObservacionRangos>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoRangosNavigation)
                    .WithMany(p => p.ObservacionRangos)
                    .HasForeignKey(d => d.CodigoRangos)
                    .HasConstraintName("FK_ObservacionRangos_CodigoRangos_Rangos_Codigo");
            });

            modelBuilder.Entity<ObservacionSalas>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoSalasNavigation)
                    .WithMany(p => p.ObservacionSalas)
                    .HasForeignKey(d => d.CodigoSalas)
                    .HasConstraintName("FK_ObservacionSalas_CodigoSalas_Salas_Codigo");
            });

            modelBuilder.Entity<ObservacionSubtipo>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoSubtipoNavigation)
                    .WithMany(p => p.ObservacionSubtipo)
                    .HasForeignKey(d => d.CodigoSubtipo)
                    .HasConstraintName("FK_ObservacionSubtipo_CodigoSubtipo_Subtipos_Codigo");
            });

            modelBuilder.Entity<ObservacionTipo>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.Property(e => e.IdObservacion).HasColumnName("idObservacion");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Usuario).HasMaxLength(255);

                entity.HasOne(d => d.CodigoTipoNavigation)
                    .WithMany(p => p.ObservacionTipo)
                    .HasForeignKey(d => d.CodigoTipo)
                    .HasConstraintName("FK_ObservacionTipo_CodigoTipo_Tipo_Codigo");
            });

            modelBuilder.Entity<OnBoarding>(entity =>
            {
                entity.ToTable("OnBoarding", "AdministracionApp");

                entity.Property(e => e.CodigoPlan)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cuerpo)
                    .IsRequired()
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.EmpresaNumero)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.OnBoardingVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlataformaHabilitadas)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoConsulta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoContenido)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UrlContenido)
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenAtencion>(entity =>
            {
                entity.HasKey(e => e.CodigoOrdenAtencion);

                entity.ToTable("OrdenAtencion", "Liquidaciones");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoCliente)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoPrestador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoSolicitud)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoCie10)
                    .HasColumnName("DiagnosticoCIE10")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCaducidad).HasColumnType("datetime");

                entity.Property(e => e.FechaDecision).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaServicio).HasColumnType("datetime");

                entity.Property(e => e.MedicoTratante)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MedicoTratanteRuc)
                    .HasColumnName("MedicoTratanteRUC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreBeneficiario)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSucursal)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombresTitular)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacionBeneficiario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacionTitular)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeCobertura)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorNombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorRuc)
                    .HasColumnName("PrestadorRUC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoOrdenAtencion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSolicitud)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAprobador)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenCentroMedico>(entity =>
            {
                entity.ToTable("OrdenCentroMedico", "ServiciosMedicos");

                entity.HasIndex(e => new { e.IdCiudad, e.IdPrestador, e.Orden })
                    .HasName("Unique_OrdenCentroMedico")
                    .IsUnique();

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.OrdenCentroMedico)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenCentroMedico_Ciudad");

                entity.HasOne(d => d.IdPrestadorNavigation)
                    .WithMany(p => p.OrdenCentroMedico)
                    .HasForeignKey(d => d.IdPrestador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenCentroMedico_Prestador");
            });

            modelBuilder.Entity<Organizacion>(entity =>
            {
                entity.ToTable("Organizacion", "Entidad");

                entity.HasIndex(e => e.EntidadId)
                    .HasName("IdxOrganizacion01")
                    .IsUnique();

                entity.HasIndex(e => e.Nombre)
                    .HasName("IdxOrganizacion03");

                entity.HasIndex(e => new { e.NacionalidadId, e.TipoIdentificacionId, e.Identificacion })
                    .HasName("IdxOrganizacion02")
                    .IsUnique();

                entity.Property(e => e.Descuento).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FechaFinDescuento).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioDescuento).HasColumnType("datetime");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ImagenPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NotaConfirmacionCita)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Organizacion)
                    .HasForeignKey<Organizacion>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizacion_Entidad");

                entity.HasOne(d => d.Nacionalidad)
                    .WithMany(p => p.Organizacion)
                    .HasForeignKey(d => d.NacionalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizacion_Nacionalidad");

                entity.HasOne(d => d.TipoIdentificacion)
                    .WithMany(p => p.Organizacion)
                    .HasForeignKey(d => d.TipoIdentificacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organizacion_TipoIdentificacion");
            });

            modelBuilder.Entity<PagoCitaMedica>(entity =>
            {
                entity.ToTable("PagoCitaMedica", "ServiciosMedicos");

                entity.HasIndex(e => e.Created)
                    .HasName("IX_PagoCitaMedica")
                    .IsUnique();

                entity.Property(e => e.AcquirerBank)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedTransactionAmount)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BinCard)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.IdCitaCentroMedico)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IssuingBank)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastFourDigits)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MaskedCardNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentBrand)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessorBankName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessorName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessorType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Recap)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RespuestaJson).HasColumnType("text");

                entity.Property(e => e.SolicitudJson).HasColumnType("text");

                entity.Property(e => e.SyncMode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TicketNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionReference)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionStatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.ToTable("Pais", "Catalogo");

                entity.HasIndex(e => e.NombreComunPais)
                    .HasName("IdxPais02");

                entity.HasIndex(e => new { e.CodigoIsoalfa2, e.CodigoIsoalfa3, e.CodigoIsonumerico, e.CodigoTelefonico })
                    .HasName("IdxPais01")
                    .IsUnique();

                entity.Property(e => e.CodigoIsoalfa2)
                    .IsRequired()
                    .HasColumnName("CodigoISOAlfa2")
                    .HasColumnType("char(2)");

                entity.Property(e => e.CodigoIsoalfa3)
                    .IsRequired()
                    .HasColumnName("CodigoISOAlfa3")
                    .HasColumnType("char(3)");

                entity.Property(e => e.CodigoIsonumerico).HasColumnName("CodigoISONumerico");

                entity.Property(e => e.CodigoTelefonico)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreComunPais)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NombreIdioma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreIsopais)
                    .IsRequired()
                    .HasColumnName("NombreISOPais")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NombreNacionalidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.ToTable("Parametro", "Administracion");

                entity.HasIndex(e => new { e.ProductoId, e.Mnemonico })
                    .HasName("IdxParametro01")
                    .IsUnique();

                entity.Property(e => e.CodigoTipo)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mnemonico)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ValorChar).HasColumnType("char(1)");

                entity.Property(e => e.ValorTexto)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Parametro1>(entity =>
            {
                entity.ToTable("Parametro", "ContabilizacionCitas");

                entity.HasIndex(e => new { e.CodigoCiudadHomologado, e.NumeroConvenio, e.SucursalCodigoExterno, e.CodigoAlfaEspecialidad, e.EstadoActivo })
                    .HasName("IdxParametro01")
                    .IsUnique();

                entity.Property(e => e.CodigoAlfaEspecialidad)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.SucursalCodigoExterno)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParametroServicioWeb>(entity =>
            {
                entity.HasKey(e => e.IdParametroServicioWeb);

                entity.ToTable("ParametroServicioWeb", "Administracion");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Servicio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParametroServicioWebs>(entity =>
            {
                entity.HasKey(e => e.IdParametroServicioWeb);
            });

            modelBuilder.Entity<Periodo>(entity =>
            {
                entity.HasIndex(e => e.PolizaId)
                    .HasName("IX_PolizaId");

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.PeriodoEstado).HasColumnType("char(3)");

                entity.HasOne(d => d.Poliza)
                    .WithMany(p => p.Periodo)
                    .HasForeignKey(d => d.PolizaId)
                    .HasConstraintName("FK_dbo.Periodo_dbo.Poliza_PolizaId");
            });

            modelBuilder.Entity<PermisosVisor>(entity =>
            {
                entity.HasKey(e => e.GrupoDirectorioActivo);

                entity.ToTable("PermisosVisor", "Mfiles");

                entity.Property(e => e.GrupoDirectorioActivo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.UsuarioMfile)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona", "Entidad");

                entity.HasIndex(e => e.EntidadId)
                    .HasName("IdxPersona01")
                    .IsUnique();

                entity.HasIndex(e => new { e.PrimerApellido, e.PrimerNombre })
                    .HasName("IdxPersona03");

                entity.HasIndex(e => new { e.NacionalidadId, e.TipoIdentificacion, e.Identificacion })
                    .HasName("IdxPersona02")
                    .IsUnique();

                entity.Property(e => e.EstadoActivo).HasDefaultValueSql("('True')");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPersona).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SegundoNombre)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelefonoMovil)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacion)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('C')");

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Persona)
                    .HasForeignKey<Persona>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_Entidad");

                entity.HasOne(d => d.Nacionalidad)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.NacionalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_Nacionalidad");
            });

            modelBuilder.Entity<PersonaActualizada>(entity =>
            {
                entity.HasKey(e => e.NumeroPersona);

                entity.ToTable("PersonaActualizada", "Entidad");

                entity.Property(e => e.NumeroPersona).ValueGeneratedNever();

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<PersonaAdicional>(entity =>
            {
                entity.HasKey(e => e.IdPersonaAdicional)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("PersonaAdicional", "Cl03");

                entity.HasIndex(e => e.PersonaNumero)
                    .HasName("IX_PersonaAdicional")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.CanalContacto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacionDatosBancarios).HasColumnType("datetime");

                entity.Property(e => e.FechaActualizacionDatosPersonales).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlanAgrupador>(entity =>
            {
                entity.HasKey(e => e.IdPlanAgrupador)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("PlanAgrupador", "GenericoEstructura");

                entity.HasIndex(e => new { e.Region, e.CodigoProducto, e.CodigoPlan, e.VersionPlan })
                    .HasName("IX_Plan")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Expresion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Planes>(entity =>
            {
                entity.HasKey(e => e.IdPlan);

                entity.ToTable("Planes", "Noticias");

                entity.Property(e => e.IdPlan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescripcionPlan)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePlan)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planes_Productos");
            });

            modelBuilder.Entity<Planes1>(entity =>
            {
                entity.HasKey(e => e.IdPlan);

                entity.ToTable("Planes", "GestionContenido");

                entity.Property(e => e.IdPlan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescripcionPlan)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePlan)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Planes1)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planes_Productos");
            });

            modelBuilder.Entity<Poliza>(entity =>
            {
                entity.HasIndex(e => e.NumeroPoliza)
                    .HasName("IX_NumeroPoliza")
                    .IsUnique();

                entity.HasIndex(e => e.ProveedorId)
                    .HasName("IX_ProveedorId");

                entity.HasIndex(e => e.ServicioCatalogoId)
                    .HasName("IX_ServicioCatalogoId");

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NumeroPoliza)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Version).IsRequired();

                entity.Property(e => e.VersionFecha).HasColumnType("datetime");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Poliza)
                    .HasForeignKey(d => d.ProveedorId)
                    .HasConstraintName("FK_dbo.Poliza_dbo.Proveedor_ProveedorId");

                entity.HasOne(d => d.ServicioCatalogo)
                    .WithMany(p => p.Poliza)
                    .HasForeignKey(d => d.ServicioCatalogoId)
                    .HasConstraintName("FK_dbo.Poliza_dbo.Servicio_ServicioCatalogoId");
            });

            modelBuilder.Entity<Preexistencia>(entity =>
            {
                entity.ToTable("Preexistencia", "Preexistencias");

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoNotificacion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoRegistro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAceptoTerminosCondiciones).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvioArmonix).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvioCorreo).HasColumnType("datetime");

                entity.Property(e => e.FechaReenvioCorreo).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.IdUrlHash)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificacionTitular)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IngresadoPor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombresPersonaTitular)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlEnvio)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioEnvioArmonix)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioReenvioCorreo)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreexistenciaDetalle>(entity =>
            {
                entity.ToTable("PreexistenciaDetalle", "Preexistencias");

                entity.Property(e => e.CabeceraDiagnostico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDiagnostico)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTipoPreexistencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDiagnostico)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoIdentificacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EsCongenito)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoAceptacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoDiagnostico)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinContrato).HasColumnType("datetime");

                entity.Property(e => e.FechaGestionAutomatica).HasColumnType("datetime");

                entity.Property(e => e.FechaGestionCliente).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioContrato).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.MensajeErrorArmonix).HasColumnType("text");

                entity.Property(e => e.MotivoRechazo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTipoPreexistencia)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombresPersona)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeDiscapacidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelacionPersona)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiesgoCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPreexistenciaNavigation)
                    .WithMany(p => p.PreexistenciaDetalle)
                    .HasForeignKey(d => d.IdPreexistencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreexistenciaDetalle_Preexistencia");
            });

            modelBuilder.Entity<Prestador>(entity =>
            {
                entity.ToTable("Prestador", "Prestador");

                entity.HasIndex(e => new { e.TipoPrestadorId, e.EntidadId })
                    .HasName("IdxPrestador01")
                    .IsUnique();

                entity.Property(e => e.EmiteOdaPortalPrestadores).HasDefaultValueSql("((1))");

                entity.Property(e => e.EstadoActivo).HasDefaultValueSql("('1')");

                entity.Property(e => e.NumeroConvenio).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Entidad)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestador_Entidad");

                entity.HasOne(d => d.TipoPrestador)
                    .WithMany(p => p.Prestador)
                    .HasForeignKey(d => d.TipoPrestadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestador_TipoPrestador");
            });

            modelBuilder.Entity<Prestador1>(entity =>
            {
                entity.HasKey(e => e.NumeroConvenio);

                entity.ToTable("Prestador", "ProcedimientoGuiaMedica");

                entity.Property(e => e.NumeroConvenio).ValueGeneratedNever();

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreComercial)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrestadoresHomologadosZendesk>(entity =>
            {
                entity.ToTable("PrestadoresHomologadosZendesk", "FormularioHospitalario");

                entity.HasIndex(e => e.NumeroConvenio)
                    .HasName("IX_PrestadoresHomologadosZendesk");

                entity.Property(e => e.NombreComercialPrestador)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePrestador)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePrestadorZendesk)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrestadorGesPacientes>(entity =>
            {
                entity.ToTable("PrestadorGesPacientes", "GestionPacientes");
            });

            modelBuilder.Entity<PrestadorUsuario>(entity =>
            {
                entity.ToTable("PrestadorUsuario", "Prestador");

                entity.HasIndex(e => new { e.PrestadorId, e.UsuarioId })
                    .HasName("IdxPrestadorUsuario01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Prestador)
                    .WithMany(p => p.PrestadorUsuario)
                    .HasForeignKey(d => d.PrestadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorUsuario_Prestador");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.PrestadorUsuario)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorUsuario_Usuario");
            });

            modelBuilder.Entity<PresupuestoDirector>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.CodigoProducto).HasMaxLength(255);

                entity.HasOne(d => d.CodigoSalaNavigation)
                    .WithMany(p => p.PresupuestoDirector)
                    .HasForeignKey(d => d.CodigoSala)
                    .HasConstraintName("FK_PresupuestoDirector_CodigoSala_Salas_Codigo");
            });

            modelBuilder.Entity<PresupuestoVendedor>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.HasOne(d => d.CodigoRangoNavigation)
                    .WithMany(p => p.PresupuestoVendedor)
                    .HasForeignKey(d => d.CodigoRango)
                    .HasConstraintName("FK_PresupuestoVendedor_CodigoRango_Rangos_Codigo");
            });

            modelBuilder.Entity<Procedimiento>(entity =>
            {
                entity.HasKey(e => e.IdProcedimiento);

                entity.ToTable("Procedimiento", "ProcedimientoGuiaMedica");

                entity.HasIndex(e => e.IdProcedimiento)
                    .HasName("NombreProcedimientoUnico")
                    .IsUnique();

                entity.Property(e => e.IdProcedimiento).ValueGeneratedNever();

                entity.Property(e => e.CampoBusqueda)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("Productos", "Noticias");

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescripcionProducto)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Productos1>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("Productos", "GestionContenido");

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescripcionProducto)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                    .HasName("IX_Nombre")
                    .IsUnique();

                entity.Property(e => e.CorreoElectronicoContacto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaConvenio).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaContacto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.ToTable("Provincia", "Catalogo");

                entity.HasIndex(e => e.PaisId)
                    .HasName("IdxProvincia01");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Provincia_Pais");
            });

            modelBuilder.Entity<Queja>(entity =>
            {
                entity.ToTable("Queja", "Quejas");

                entity.Property(e => e.CodigoPlan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.NombreBeneficiario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTitular)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoContacto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMotivoRequerimientoNavigation)
                    .WithMany(p => p.Queja)
                    .HasForeignKey(d => d.IdMotivoRequerimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Motivo_Requerimiento");
            });

            modelBuilder.Entity<Rangos>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.CodigoCanalesNavigation)
                    .WithMany(p => p.Rangos)
                    .HasForeignKey(d => d.CodigoCanales)
                    .HasConstraintName("FK_Rangos_CodigoCanales_Canales_Codigo");

                entity.HasOne(d => d.CodigoSubtipoNavigation)
                    .WithMany(p => p.Rangos)
                    .HasForeignKey(d => d.CodigoSubtipo)
                    .HasConstraintName("FK_Rangos_CodigoSubtipo_Subtipos_Codigo");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region", "Catalogo");

                entity.HasIndex(e => e.PaisId)
                    .HasName("IdxRegion01");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Region_Pais");
            });

            modelBuilder.Entity<RegistroEnvioNotificaciones>(entity =>
            {
                entity.ToTable("RegistroEnvioNotificaciones", "ServiciosMedicos");

                entity.Property(e => e.EstadoProceso)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.Property(e => e.MensajeError).HasMaxLength(1000);
            });

            modelBuilder.Entity<RepositorioFormularioHospitalario>(entity =>
            {
                entity.ToTable("RepositorioFormularioHospitalario", "FormularioHospitalario");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegion)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdFormularioHospitalarioZendesk)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoOriginal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RepositorioMedicacionContinua>(entity =>
            {
                entity.ToTable("RepositorioMedicacionContinua", "Liquidaciones");

                entity.Property(e => e.CodigoDiagnostico)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegion)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoOriginal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSobreMedicacionContinua)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RestriccionEspecialidad>(entity =>
            {
                entity.ToTable("RestriccionEspecialidad", "Catalogo");

                entity.HasIndex(e => e.EspecialidadId)
                    .HasName("IX_RestriccionEspecialidad")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EdadDesde).HasDefaultValueSql("((0))");

                entity.Property(e => e.EdadHasta).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Especialidad)
                    .WithOne(p => p.RestriccionEspecialidad)
                    .HasForeignKey<RestriccionEspecialidad>(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RestriccionEspecialidad_RestriccionEspecialidad");
            });

            modelBuilder.Entity<Resumen>(entity =>
            {
                entity.HasIndex(e => e.CatalogoEstadoId)
                    .HasName("IX_CatalogoEstadoId");

                entity.HasIndex(e => e.PeriodoId)
                    .HasName("IX_PeriodoId");

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaGeneracion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Gap).HasColumnName("GAP");

                entity.HasOne(d => d.CatalogoEstado)
                    .WithMany(p => p.Resumen)
                    .HasForeignKey(d => d.CatalogoEstadoId)
                    .HasConstraintName("FK_dbo.Resumen_dbo.CatalogoGeneral_CatalogoEstadoId");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.Resumen)
                    .HasForeignKey(d => d.PeriodoId)
                    .HasConstraintName("FK_dbo.Resumen_dbo.Periodo_PeriodoId");
            });

            modelBuilder.Entity<ResumenDetalle>(entity =>
            {
                entity.HasIndex(e => e.BeneficiarioCedula)
                    .HasName("IX_BeneficiarioCedula");

                entity.HasIndex(e => e.ContratoId)
                    .HasName("IX_ContratoId");

                entity.HasIndex(e => e.ResumenId)
                    .HasName("IX_ResumenId");

                entity.HasIndex(e => e.TitularCedula)
                    .HasName("IX_TitularCedula");

                entity.Property(e => e.BeneficiarioApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioFechaDigitacion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaExclusion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaInclusion).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioFechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.BeneficiarioNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCategoriaSigmep)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProductoSigmep)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoRegionSigmep)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoServicioSigmep)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContratoFechaDigitacion).HasColumnType("datetime");

                entity.Property(e => e.ContratoFechaFin).HasColumnType("datetime");

                entity.Property(e => e.ContratoFechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ServicioFechaFin).HasColumnType("datetime");

                entity.Property(e => e.ServicioFechaInicio).HasColumnType("datetime");

                entity.Property(e => e.TitularApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TitularCedula)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TitularNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Resumen)
                    .WithMany(p => p.ResumenDetalle)
                    .HasForeignKey(d => d.ResumenId)
                    .HasConstraintName("FK_dbo.ResumenDetalle_dbo.Resumen_ResumenId");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol", "Seguridad");

                entity.HasIndex(e => new { e.ProductoId, e.EstadoActivo })
                    .HasName("IdxRol02");

                entity.HasIndex(e => new { e.ProductoId, e.Nombre })
                    .HasName("IdxRol01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolFuncionalidad>(entity =>
            {
                entity.ToTable("RolFuncionalidad", "Seguridad");

                entity.HasIndex(e => new { e.RolId, e.FuncionalidadId })
                    .HasName("IdxRolFuncionalidad01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Funcionalidad)
                    .WithMany(p => p.RolFuncionalidad)
                    .HasForeignKey(d => d.FuncionalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolFuncionalidad_Funcionalidad");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolFuncionalidad)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolFuncionalidad_Rol");
            });

            modelBuilder.Entity<Salas>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Abreviacion).HasMaxLength(255);

                entity.Property(e => e.CodigoProducto).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.CodigoCanalesNavigation)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.CodigoCanales)
                    .HasConstraintName("FK_Salas_CodigoCanales_Canales_Codigo");
            });

            modelBuilder.Entity<SaludsaContigo>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.Region, e.ContratoNumero, e.PersonaNumero });

                entity.ToTable("SaludsaContigo", "SaludsaContigo");

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.EnfermedadDiagnosticada)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEnrolamiento).HasColumnType("date");

                entity.Property(e => e.FechaEnrolamientoReal).HasColumnType("date");

                entity.Property(e => e.FechaMaximaMedicacion).HasColumnType("date");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.HorarioContacto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MedicacionRequerida)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MedicoCabecera)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoRechazo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NombresBeneficiario)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoBeneficiario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionEnrolamiento)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.OtrosMotivosRechazo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorMedicina)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorMedico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoDiagnostico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TipoBeneficio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioEnrolamiento)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SegmentacionContrato>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.Region, e.NumeroContrato, e.EstadoActivo });

                entity.ToTable("SegmentacionContrato", "Atribucion");

                entity.Property(e => e.CodigoProducto).HasMaxLength(10);

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.EstadoActivo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SeguimientoPrestadorSaludsaContigo>(entity =>
            {
                entity.ToTable("SeguimientoPrestadorSaludsaContigo", "SaludsaContigo");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoContacto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoBeneficiario)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoSeguimiento)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionBeneficiario)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoIdentificacionBeneficiario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoGestion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEntrega).HasColumnType("date");

                entity.Property(e => e.FechaGestion).HasColumnType("date");

                entity.Property(e => e.FechaMaxMedicacionBeneficiario).HasColumnType("date");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaProximaEntrega).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.HorarioEntregaBeneficiario)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MedicacionBeneficiario)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MedicacionEntregada)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.NombresBeneficiario)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionBeneficiario)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResultadoGestion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoContacto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioGestion)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SaludsaContigo)
                    .WithMany(p => p.SeguimientoPrestadorSaludsaContigo)
                    .HasForeignKey(d => new { d.CodigoProducto, d.Region, d.ContratoNumero, d.PersonaNumero })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeguimientoPrestadorSaludsaContigo_SaludsaContigo");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Servicio1>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.ToTable("Servicio", "Catalogo");

                entity.HasIndex(e => e.CodigoServicio)
                    .HasName("IX_Servicio")
                    .IsUnique();

                entity.Property(e => e.CodigoServicio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EstadoActivo).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreServicio)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ServicioAdicionalIcono>(entity =>
            {
                entity.HasKey(e => e.IdServiciosAdicionalIcono)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ServicioAdicionalIcono", "GenericoEstructura");

                entity.Property(e => e.CodigoServicio)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionServicio)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServicioAdicionalSeccion>(entity =>
            {
                entity.HasKey(e => e.IdServiciosAdicionalesSeccion)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ServicioAdicionalSeccion", "GenericoEstructura");

                entity.HasIndex(e => new { e.CodigoServicio, e.Orden })
                    .HasName("IX_ServicioAdicional")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.CodigoServicio)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Expresion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TextoDetalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TituloPantalla)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UrlPdf)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServicioBeneficiario>(entity =>
            {
                entity.HasIndex(e => e.BeneficiarioServicioId)
                    .HasName("IX_BeneficiarioServicioId");

                entity.HasIndex(e => e.ServicioAdicionalId)
                    .HasName("IX_ServicioAdicionalId");

                entity.Property(e => e.Estado).HasColumnType("char(3)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.BeneficiarioServicio)
                    .WithMany(p => p.ServicioBeneficiario)
                    .HasForeignKey(d => d.BeneficiarioServicioId)
                    .HasConstraintName("FK_dbo.ServicioBeneficiario_dbo.Beneficiario_BeneficiarioServicioId");

                entity.HasOne(d => d.ServicioAdicional)
                    .WithMany(p => p.ServicioBeneficiario)
                    .HasForeignKey(d => d.ServicioAdicionalId)
                    .HasConstraintName("FK_dbo.ServicioBeneficiario_dbo.Servicio_ServicioAdicionalId");
            });

            modelBuilder.Entity<ServiciosHabilitadosApps>(entity =>
            {
                entity.HasKey(e => new { e.IdProducto, e.IdPlan, e.Servicio });

                entity.ToTable("ServiciosHabilitadosApps", "SaludsaContigo");

                entity.Property(e => e.IdProducto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlan)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Servicio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFinServicio).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioServicio).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<SolicitudCitaMedicoDestacado>(entity =>
            {
                entity.ToTable("SolicitudCitaMedicoDestacado", "ServiciosMedicos");

                entity.Property(e => e.CodigoContrato).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoEspecialidad)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoPlataforma).HasDefaultValueSql("((3))");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSolicitud).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.MotivoRechazo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RegistradoPor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TitularContratoId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sponsor>(entity =>
            {
                entity.HasKey(e => new { e.NombreSponsor, e.TipoPlanSponsor });

                entity.ToTable("Sponsor", "Sponsors");

                entity.Property(e => e.NombreSponsor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPlanSponsor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlanSaludsa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProductoSaludsa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlantillaAgendamiento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePlan)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubespecialidadMedica>(entity =>
            {
                entity.ToTable("SubespecialidadMedica", "Catalogo");

                entity.HasIndex(e => e.CodigoAlfa)
                    .HasName("IdxSubespecialidadMedica02")
                    .IsUnique();

                entity.HasIndex(e => new { e.EspecialidadMedicaId, e.CodigoAlfa })
                    .HasName("IdxSubespecialidadMedica01")
                    .IsUnique();

                entity.Property(e => e.CodigoAlfa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.EspecialidadMedica)
                    .WithMany(p => p.SubespecialidadMedica)
                    .HasForeignKey(d => d.EspecialidadMedicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubespecialidadMedica_EspecialidadMedica");
            });

            modelBuilder.Entity<Subtipos>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<SucursalCiudad>(entity =>
            {
                entity.HasKey(e => new { e.IdCiudad, e.CodigoCentroMedico, e.CodigoSucursal });

                entity.ToTable("SucursalCiudad", "Homologacion");

                entity.Property(e => e.CodigoSucursal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SucursalesPrestador>(entity =>
            {
                entity.HasKey(e => e.IdSucursalPrestador);

                entity.ToTable("SucursalesPrestador", "Digital");

                entity.Property(e => e.AniosExistencias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertificadosPremios)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HorarioAtencion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Latitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Longitud).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContacto)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TieneParqueo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoPrestadorCiudadPrestadorNavigation)
                    .WithMany(p => p.SucursalesPrestador)
                    .HasForeignKey(d => d.IdTipoPrestadorCiudadPrestador)
                    .HasConstraintName("FK_SucursalesPrestador_TipoPrestadorCiudadPrestador");
            });

            modelBuilder.Entity<Tabla>(entity =>
            {
                entity.HasKey(e => e.IdTabla);

                entity.ToTable("Tabla", "GenericoEstructura");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tematica>(entity =>
            {
                entity.ToTable("Tematica", "Homologacion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(127)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.CodigoNivelNavigation)
                    .WithMany(p => p.Tipo)
                    .HasForeignKey(d => d.CodigoNivel)
                    .HasConstraintName("FK_Tipo_CodigoNivel_Niveles_Codigo");
            });

            modelBuilder.Entity<TipoCoberturaNacInt>(entity =>
            {
                entity.ToTable("TipoCoberturaNacInt", "CoberturasXPR");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEntidad>(entity =>
            {
                entity.ToTable("TipoEntidad", "Entidad");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("IdxTipoEntidad01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoIdentificacion>(entity =>
            {
                entity.ToTable("TipoIdentificacion", "Entidad");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("IdxTipoIdentificacion01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CodigoAlfa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPrestador>(entity =>
            {
                entity.ToTable("TipoPrestador", "Prestador");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("IdxTipoPrestador01")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPrestadorCiudadPrestador>(entity =>
            {
                entity.ToTable("TipoPrestadorCiudadPrestador", "Digital");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.TipoPrestadorCiudadPrestador)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoPrestadorCiudadPrestador_Ciudad");

                entity.HasOne(d => d.IdInformacionPrestadorNavigation)
                    .WithMany(p => p.TipoPrestadorCiudadPrestador)
                    .HasForeignKey(d => d.IdInformacionPrestador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoPrestadorCiudadPrestador_InformacionPrestador");

                entity.HasOne(d => d.IdTipoPrestadorNavigation)
                    .WithMany(p => p.TipoPrestadorCiudadPrestador)
                    .HasForeignKey(d => d.IdTipoPrestador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoPrestadorCiudadPrestador_TipoPrestador");
            });

            modelBuilder.Entity<TipoRequerimiento>(entity =>
            {
                entity.ToTable("TipoRequerimiento", "Quejas");

                entity.HasIndex(e => e.Id)
                    .HasName("NombreRequerimientoUnico")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EtiquetaZendesk)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TokenOda>(entity =>
            {
                entity.HasKey(e => e.IdTokenOda);

                entity.ToTable("TokenOda", "Seguridad");

                entity.Property(e => e.Celular)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPlan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCaducidad).HasColumnType("datetime");

                entity.Property(e => e.FechaGeneracion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaRevocacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUso).HasColumnType("datetime");

                entity.Property(e => e.FechaValidacion).HasColumnType("datetime");

                entity.Property(e => e.NombreBeneficiario)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorNombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TokenNumero)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistro)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioValidacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TotalCitaDisponible>(entity =>
            {
                entity.ToTable("TotalCitaDisponible", "ContabilizacionCitas");

                entity.Property(e => e.FechaDisponibilidad).HasColumnType("datetime");

                entity.Property(e => e.FechaProceso).HasColumnType("datetime");

                entity.HasOne(d => d.Parametro)
                    .WithMany(p => p.TotalCitaDisponible)
                    .HasForeignKey(d => d.ParametroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TotalCitaDisponible_Parametro");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario", "Seguridad");

                entity.HasIndex(e => new { e.EntidadRelacionadaId, e.NombreUsuario })
                    .HasName("IdxUsuario01")
                    .IsUnique();

                entity.HasIndex(e => new { e.EntidadRelacionadaId, e.NombreUsuario, e.EstadoActivo, e.Bloqueado, e.FinBloqueo })
                    .HasName("IdxUsuario02");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EntidadRelacionada)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.EntidadRelacionadaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_EntidadRelacionada");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Persona");
            });

            modelBuilder.Entity<UsuarioRol>(entity =>
            {
                entity.ToTable("UsuarioRol", "Seguridad");

                entity.HasIndex(e => new { e.UsuarioId, e.RolId })
                    .HasName("IdxUsuarioRol01")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.UsuarioRol)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioRol_Rol");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioRol)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioRol_Usuario");
            });

            modelBuilder.Entity<ValoresFee>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProducto, e.NumeroConvenio });

                entity.ToTable("ValoresFee", "CreditoFarmacia");

                entity.Property(e => e.CodigoProducto)
                    .HasColumnName("codigoProducto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroConvenio).HasColumnName("numeroConvenio");

                entity.Property(e => e.ValorFee).HasColumnName("valorFee");
            });

            modelBuilder.Entity<Versionamiento>(entity =>
            {
                entity.ToTable("Versionamiento", "AdministracionApp");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDespliegue).HasColumnType("datetime");

                entity.Property(e => e.Plataforma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VersionamientoOnBoarding>(entity =>
            {
                entity.HasKey(e => new { e.IdVersionamiento, e.IdOnBoarding });

                entity.ToTable("VersionamientoOnBoarding", "AdministracionApp");

                entity.HasOne(d => d.IdOnBoardingNavigation)
                    .WithMany(p => p.VersionamientoOnBoarding)
                    .HasForeignKey(d => d.IdOnBoarding)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKOnBoardingVersionamiento");

                entity.HasOne(d => d.IdVersionamientoNavigation)
                    .WithMany(p => p.VersionamientoOnBoarding)
                    .HasForeignKey(d => d.IdVersionamiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKVersionamientoOnBoarding");
            });
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Productos.Models;

public partial class GuatemalaDigitalContext : DbContext
{
    public GuatemalaDigitalContext()
    {
    }

    public GuatemalaDigitalContext(DbContextOptions<GuatemalaDigitalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdministracionDocumento> AdministracionDocumentos { get; set; }

    public virtual DbSet<AdministracionDocumentoTarjetum> AdministracionDocumentoTarjeta { get; set; }

    public virtual DbSet<Alertum> Alerta { get; set; }

    public virtual DbSet<Anuncio> Anuncios { get; set; }

    public virtual DbSet<AnuncioAprobacion> AnuncioAprobacions { get; set; }

    public virtual DbSet<AnuncioExterno> AnuncioExternos { get; set; }

    public virtual DbSet<AnuncioRestringido> AnuncioRestringidos { get; set; }

    public virtual DbSet<AplicacionExterna> AplicacionExternas { get; set; }

    public virtual DbSet<AplicacionPlaza> AplicacionPlazas { get; set; }

    public virtual DbSet<Arancel> Arancels { get; set; }

    public virtual DbSet<Archivo> Archivos { get; set; }

    public virtual DbSet<ArchivoEstablecimiento> ArchivoEstablecimientos { get; set; }

    public virtual DbSet<ArchivoMenu> ArchivoMenus { get; set; }

    public virtual DbSet<ArchivoPaquete> ArchivoPaquetes { get; set; }

    public virtual DbSet<ArchivoReembolso> ArchivoReembolsos { get; set; }

    public virtual DbSet<ArchivoTarea> ArchivoTareas { get; set; }

    public virtual DbSet<Asueto> Asuetos { get; set; }

    public virtual DbSet<Atraso> Atrasos { get; set; }

    public virtual DbSet<Atributo> Atributos { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<BienOservicio> BienOservicios { get; set; }

    public virtual DbSet<Bitacora> Bitacoras { get; set; }

    public virtual DbSet<BitacoraGestionFactura> BitacoraGestionFacturas { get; set; }

    public virtual DbSet<BitacoraManifiesto> BitacoraManifiestos { get; set; }

    public virtual DbSet<BitacoraMembresium> BitacoraMembresia { get; set; }

    public virtual DbSet<BitacoraPorcentajeCod> BitacoraPorcentajeCods { get; set; }

    public virtual DbSet<BitacoraProceso> BitacoraProcesos { get; set; }

    public virtual DbSet<BitacoraRegimenProveedor> BitacoraRegimenProveedors { get; set; }

    public virtual DbSet<BitacoraServicioCaby> BitacoraServicioCabies { get; set; }

    public virtual DbSet<BusquedaPagina> BusquedaPaginas { get; set; }

    public virtual DbSet<Busquedum> Busqueda { get; set; }

    public virtual DbSet<Caby> Cabies { get; set; }

    public virtual DbSet<Caja> Cajas { get; set; }

    public virtual DbSet<CampaniaExterna> CampaniaExternas { get; set; }

    public virtual DbSet<Candidato> Candidatos { get; set; }

    public virtual DbSet<Carpetum> Carpeta { get; set; }

    public virtual DbSet<CategoriaMensaje> CategoriaMensajes { get; set; }

    public virtual DbSet<CategoriaNoAutomatizable> CategoriaNoAutomatizables { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<CierreContable> CierreContables { get; set; }

    public virtual DbSet<CierreDeCaja> CierreDeCajas { get; set; }

    public virtual DbSet<ClaseCuentaContable> ClaseCuentaContables { get; set; }

    public virtual DbSet<ClaseDeGasto> ClaseDeGastos { get; set; }

    public virtual DbSet<ClaseDocumento> ClaseDocumentos { get; set; }

    public virtual DbSet<ClaseTipoAplicacionExterna> ClaseTipoAplicacionExternas { get; set; }

    public virtual DbSet<Click> Clicks { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Cobro> Cobros { get; set; }

    public virtual DbSet<CobroReembolso> CobroReembolsos { get; set; }

    public virtual DbSet<CodigoCanjeable> CodigoCanjeables { get; set; }

    public virtual DbSet<CodigoProducto> CodigoProductos { get; set; }

    public virtual DbSet<CombustibleGasto> CombustibleGastos { get; set; }

    public virtual DbSet<ConceptoNotaContable> ConceptoNotaContables { get; set; }

    public virtual DbSet<ConciliacionBancarium> ConciliacionBancaria { get; set; }

    public virtual DbSet<ContenidoAdicional> ContenidoAdicionals { get; set; }

    public virtual DbSet<ContenidoDinamico> ContenidoDinamicos { get; set; }

    public virtual DbSet<ContraCargo> ContraCargos { get; set; }

    public virtual DbSet<CorreoNotificacionGarantium> CorreoNotificacionGarantia { get; set; }

    public virtual DbSet<CorreoPersonalizado> CorreoPersonalizados { get; set; }

    public virtual DbSet<CorreoRebotado> CorreoRebotados { get; set; }

    public virtual DbSet<CorridaProceso> CorridaProcesos { get; set; }

    public virtual DbSet<CuentaContable> CuentaContables { get; set; }

    public virtual DbSet<CuentaContableNivel> CuentaContableNivels { get; set; }

    public virtual DbSet<CuentaContableSaldo> CuentaContableSaldos { get; set; }

    public virtual DbSet<CuentaDeCompra> CuentaDeCompras { get; set; }

    public virtual DbSet<Cuentum> Cuenta { get; set; }

    public virtual DbSet<CuotaTarjetum> CuotaTarjeta { get; set; }

    public virtual DbSet<DefinicionEscaner> DefinicionEscaners { get; set; }

    public virtual DbSet<DefinicionEscanerDetalle> DefinicionEscanerDetalles { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DepartamentoEmpresa> DepartamentoEmpresas { get; set; }

    public virtual DbSet<Deposito> Depositos { get; set; }

    public virtual DbSet<DepositoEmpresaEntrega> DepositoEmpresaEntregas { get; set; }

    public virtual DbSet<DetalleConciliacionBancarium> DetalleConciliacionBancaria { get; set; }

    public virtual DbSet<DetalleVentaServicio> DetalleVentaServicios { get; set; }

    public virtual DbSet<DireccionImportador> DireccionImportadors { get; set; }

    public virtual DbSet<DireccionIpcliente> DireccionIpclientes { get; set; }

    public virtual DbSet<DirectorioContacto> DirectorioContactos { get; set; }

    public virtual DbSet<DirectorioEmpresa> DirectorioEmpresas { get; set; }

    public virtual DbSet<Dispositivo> Dispositivos { get; set; }

    public virtual DbSet<ElementoRobot> ElementoRobots { get; set; }

    public virtual DbSet<Embarque> Embarques { get; set; }

    public virtual DbSet<Empaque> Empaques { get; set; }

    public virtual DbSet<EmpaqueDeRegalo> EmpaqueDeRegalos { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<EmpresaDeEntrega> EmpresaDeEntregas { get; set; }

    public virtual DbSet<EmpresaEntregaBitacora> EmpresaEntregaBitacoras { get; set; }

    public virtual DbSet<Entradum> Entrada { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<ErrorApi> ErrorApis { get; set; }

    public virtual DbSet<EscenarioContable> EscenarioContables { get; set; }

    public virtual DbSet<EscenarioContableCuentaContable> EscenarioContableCuentaContables { get; set; }

    public virtual DbSet<Establecimiento> Establecimientos { get; set; }

    public virtual DbSet<EstadoAnuncio> EstadoAnuncios { get; set; }

    public virtual DbSet<EstadoAnuncioAprobacion> EstadoAnuncioAprobacions { get; set; }

    public virtual DbSet<EstadoAplicacionPlaza> EstadoAplicacionPlazas { get; set; }

    public virtual DbSet<EstadoCampaniaExterna> EstadoCampaniaExternas { get; set; }

    public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }

    public virtual DbSet<EstadoContraCargo> EstadoContraCargos { get; set; }

    public virtual DbSet<EstadoDeAnuncio> EstadoDeAnuncios { get; set; }

    public virtual DbSet<EstadoDeVentum> EstadoDeVenta { get; set; }

    public virtual DbSet<EstadoDepositoEmpresaEntrega> EstadoDepositoEmpresaEntregas { get; set; }

    public virtual DbSet<EstadoEntrega> EstadoEntregas { get; set; }

    public virtual DbSet<EstadoEntregaEmpresaDeEntrega> EstadoEntregaEmpresaDeEntregas { get; set; }

    public virtual DbSet<EstadoEntregaFactura> EstadoEntregaFacturas { get; set; }

    public virtual DbSet<EstadoFactura> EstadoFacturas { get; set; }

    public virtual DbSet<EstadoGarantium> EstadoGarantia { get; set; }

    public virtual DbSet<EstadoGuiaReclamadum> EstadoGuiaReclamada { get; set; }

    public virtual DbSet<EstadoNotaContable> EstadoNotaContables { get; set; }

    public virtual DbSet<EstadoPaquete> EstadoPaquetes { get; set; }

    public virtual DbSet<EstadoPaqueteReclamado> EstadoPaqueteReclamados { get; set; }

    public virtual DbSet<EstadoPedido> EstadoPedidos { get; set; }

    public virtual DbSet<EstadoPreguntum> EstadoPregunta { get; set; }

    public virtual DbSet<EstadoProducto> EstadoProductos { get; set; }

    public virtual DbSet<EstadoPromocion> EstadoPromocions { get; set; }

    public virtual DbSet<EstadoRevision> EstadoRevisions { get; set; }

    public virtual DbSet<EstadoTransferencium> EstadoTransferencia { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturaCreditoFiscal> FacturaCreditoFiscals { get; set; }

    public virtual DbSet<FacturaDepositoEmpresaEntrega> FacturaDepositoEmpresaEntregas { get; set; }

    public virtual DbSet<FacturaDetalle> FacturaDetalles { get; set; }

    public virtual DbSet<FormaDeEnvio> FormaDeEnvios { get; set; }

    public virtual DbSet<FormaDePago> FormaDePagos { get; set; }

    public virtual DbSet<Garantium> Garantia { get; set; }

    public virtual DbSet<Gasto> Gastos { get; set; }

    public virtual DbSet<GastoDetalle> GastoDetalles { get; set; }

    public virtual DbSet<GestionCorreoExencion> GestionCorreoExencions { get; set; }

    public virtual DbSet<GradoUniversitario> GradoUniversitarios { get; set; }

    public virtual DbSet<GuiaEliminadum> GuiaEliminada { get; set; }

    public virtual DbSet<GuiaReclamadum> GuiaReclamada { get; set; }

    public virtual DbSet<HistoricoPagoVentum> HistoricoPagoVenta { get; set; }

    public virtual DbSet<HistoricoVale> HistoricoVales { get; set; }

    public virtual DbSet<ImagenContraCargo> ImagenContraCargos { get; set; }

    public virtual DbSet<ImagenDeposito> ImagenDepositos { get; set; }

    public virtual DbSet<ImagenGarantium> ImagenGarantia { get; set; }

    public virtual DbSet<ImagenGasto> ImagenGastos { get; set; }

    public virtual DbSet<ImagenGuiaReclamadum> ImagenGuiaReclamada { get; set; }

    public virtual DbSet<ImagenPaqueteReclamadum> ImagenPaqueteReclamada { get; set; }

    public virtual DbSet<ImagenPolizaDeImportacion> ImagenPolizaDeImportacions { get; set; }

    public virtual DbSet<ImagenTema> ImagenTemas { get; set; }

    public virtual DbSet<Importador> Importadors { get; set; }

    public virtual DbSet<IncidenciaVentum> IncidenciaVenta { get; set; }

    public virtual DbSet<IndiceDeBusquedum> IndiceDeBusqueda { get; set; }

    public virtual DbSet<IntentoDeEntrega> IntentoDeEntregas { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<InventarioDiario> InventarioDiarios { get; set; }

    public virtual DbSet<Ipexterna> Ipexternas { get; set; }

    public virtual DbSet<Ippai> Ippais { get; set; }

    public virtual DbSet<LibroContable> LibroContables { get; set; }

    public virtual DbSet<LlamadaKeepa> LlamadaKeepas { get; set; }

    public virtual DbSet<Localidad> Localidads { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<MedioAplicacionPlaza> MedioAplicacionPlazas { get; set; }

    public virtual DbSet<MedioDesuscripcion> MedioDesuscripcions { get; set; }

    public virtual DbSet<MedioSuscripcion> MedioSuscripcions { get; set; }

    public virtual DbSet<Membresium> Membresia { get; set; }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    public virtual DbSet<ModificacionDeInventario> ModificacionDeInventarios { get; set; }

    public virtual DbSet<Monedum> Moneda { get; set; }

    public virtual DbSet<MotivoReclamo> MotivoReclamos { get; set; }

    public virtual DbSet<MotivoRetorno> MotivoRetornos { get; set; }

    public virtual DbSet<MotivoRetornoEmpresaDeEntrega> MotivoRetornoEmpresaDeEntregas { get; set; }

    public virtual DbSet<Movimiento> Movimientos { get; set; }

    public virtual DbSet<MovimientoEstadoGarantium> MovimientoEstadoGarantia { get; set; }

    public virtual DbSet<MovimientoGarantium> MovimientoGarantia { get; set; }

    public virtual DbSet<MovimientoMembresium> MovimientoMembresia { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<MunicipioEmpresaDeEntrega> MunicipioEmpresaDeEntregas { get; set; }

    public virtual DbSet<NoEnviarCorreo> NoEnviarCorreos { get; set; }

    public virtual DbSet<NotaContable> NotaContables { get; set; }

    public virtual DbSet<Notificacion> Notificacions { get; set; }

    public virtual DbSet<ObservacionesComun> ObservacionesComuns { get; set; }

    public virtual DbSet<OrdenDeCompra> OrdenDeCompras { get; set; }

    public virtual DbSet<Pagina> Paginas { get; set; }

    public virtual DbSet<PalabraNegativaProducto> PalabraNegativaProductos { get; set; }

    public virtual DbSet<Paquete> Paquetes { get; set; }

    public virtual DbSet<PaqueteReclamado> PaqueteReclamados { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<ParametroPorcentajeImpuesto> ParametroPorcentajeImpuestos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Penalizacion> Penalizacions { get; set; }

    public virtual DbSet<PerfilDeImpresion> PerfilDeImpresions { get; set; }

    public virtual DbSet<PlantillaCorreo> PlantillaCorreos { get; set; }

    public virtual DbSet<PlataformaAnuncioExterno> PlataformaAnuncioExternos { get; set; }

    public virtual DbSet<Plaza> Plazas { get; set; }

    public virtual DbSet<PolizaContable> PolizaContables { get; set; }

    public virtual DbSet<PolizaContableBitacora> PolizaContableBitacoras { get; set; }

    public virtual DbSet<PolizaContableCuentaContable> PolizaContableCuentaContables { get; set; }

    public virtual DbSet<PolizaDeImportacion> PolizaDeImportacions { get; set; }

    public virtual DbSet<PorcentajeImpuesto> PorcentajeImpuestos { get; set; }

    public virtual DbSet<PorcentajeRetencionExencion> PorcentajeRetencionExencions { get; set; }

    public virtual DbSet<PrecioBitacora> PrecioBitacoras { get; set; }

    public virtual DbSet<Preguntum> Pregunta { get; set; }

    public virtual DbSet<Prioridad> Prioridads { get; set; }

    public virtual DbSet<Proceso> Procesos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoCaby> ProductoCabies { get; set; }

    public virtual DbSet<ProductoCombinado> ProductoCombinados { get; set; }

    public virtual DbSet<ProductoElementoRobot> ProductoElementoRobots { get; set; }

    public virtual DbSet<ProductoFacebook> ProductoFacebooks { get; set; }

    public virtual DbSet<ProductoHistorico> ProductoHistoricos { get; set; }

    public virtual DbSet<ProductoNoVigente> ProductoNoVigentes { get; set; }

    public virtual DbSet<ProductoServicio> ProductoServicios { get; set; }

    public virtual DbSet<Promocion> Promocions { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<RazonAnulacionVentum> RazonAnulacionVenta { get; set; }

    public virtual DbSet<RedCrediticium> RedCrediticia { get; set; }

    public virtual DbSet<Regiman> Regimen { get; set; }

    public virtual DbSet<RegimenFactura> RegimenFacturas { get; set; }

    public virtual DbSet<Resena> Resenas { get; set; }

    public virtual DbSet<Resolucion> Resolucions { get; set; }

    public virtual DbSet<RespuestaComun> RespuestaComuns { get; set; }

    public virtual DbSet<RevisionProducto> RevisionProductos { get; set; }

    public virtual DbSet<Seccion> Seccions { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<SolicitudContrasena> SolicitudContrasenas { get; set; }

    public virtual DbSet<SolicitudDocumentoTarjetum> SolicitudDocumentoTarjeta { get; set; }

    public virtual DbSet<Subseccion> Subseccions { get; set; }

    public virtual DbSet<Sugerencium> Sugerencia { get; set; }

    public virtual DbSet<Suscripcion> Suscripcions { get; set; }

    public virtual DbSet<Tarea> Tareas { get; set; }

    public virtual DbSet<TareaUsuario> TareaUsuarios { get; set; }

    public virtual DbSet<TasaDeCambio> TasaDeCambios { get; set; }

    public virtual DbSet<Tema> Temas { get; set; }

    public virtual DbSet<Temp> Temps { get; set; }

    public virtual DbSet<TempCobro> TempCobros { get; set; }

    public virtual DbSet<TipoAplicacionExterna> TipoAplicacionExternas { get; set; }

    public virtual DbSet<TipoCombustible> TipoCombustibles { get; set; }

    public virtual DbSet<TipoContenidoDinamico> TipoContenidoDinamicos { get; set; }

    public virtual DbSet<TipoContrato> TipoContratos { get; set; }

    public virtual DbSet<TipoCuentum> TipoCuenta { get; set; }

    public virtual DbSet<TipoDatoTest> TipoDatoTests { get; set; }

    public virtual DbSet<TipoDeAnuncio> TipoDeAnuncios { get; set; }

    public virtual DbSet<TipoDeGasto> TipoDeGastos { get; set; }

    public virtual DbSet<TipoDeTarjetum> TipoDeTarjeta { get; set; }

    public virtual DbSet<TipoDispositivo> TipoDispositivos { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoError> TipoErrors { get; set; }

    public virtual DbSet<TipoEscenarioContable> TipoEscenarioContables { get; set; }

    public virtual DbSet<TipoGarantium> TipoGarantia { get; set; }

    public virtual DbSet<TipoGuium> TipoGuia { get; set; }

    public virtual DbSet<TipoHistorico> TipoHistoricos { get; set; }

    public virtual DbSet<TipoIngreso> TipoIngresos { get; set; }

    public virtual DbSet<TipoJornadum> TipoJornada { get; set; }

    public virtual DbSet<TipoLicenciaVacacione> TipoLicenciaVacaciones { get; set; }

    public virtual DbSet<TipoMovimiento> TipoMovimientos { get; set; }

    public virtual DbSet<TipoPreguntum> TipoPregunta { get; set; }

    public virtual DbSet<TipoPromocion> TipoPromocions { get; set; }

    public virtual DbSet<TipoReclamoPaquete> TipoReclamoPaquetes { get; set; }

    public virtual DbSet<TipoRegimenFacturacion> TipoRegimenFacturacions { get; set; }

    public virtual DbSet<TipoTransaccion> TipoTransaccions { get; set; }

    public virtual DbSet<TmpCargareembolso> TmpCargareembolsos { get; set; }

    public virtual DbSet<TmpCategoriaEliminadum> TmpCategoriaEliminada { get; set; }

    public virtual DbSet<TmpDepositoEmpresaEntrega> TmpDepositoEmpresaEntregas { get; set; }

    public virtual DbSet<TmpPedido> TmpPedidos { get; set; }

    public virtual DbSet<TmpPedidoEstablecimiento> TmpPedidoEstablecimientos { get; set; }

    public virtual DbSet<TmpPromo> TmpPromos { get; set; }

    public virtual DbSet<TmpReembolso> TmpReembolsos { get; set; }

    public virtual DbSet<Traduccione> Traducciones { get; set; }

    public virtual DbSet<Transaccion> Transaccions { get; set; }

    public virtual DbSet<UbicacionBodega> UbicacionBodegas { get; set; }

    public virtual DbSet<UbicacionDespacho> UbicacionDespachos { get; set; }

    public virtual DbSet<UbicacionTemporalDespacho> UbicacionTemporalDespachos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioAplicacionExterna> UsuarioAplicacionExternas { get; set; }

    public virtual DbSet<UsuarioAplicacionExternaCuentum> UsuarioAplicacionExternaCuenta { get; set; }

    public virtual DbSet<UsuarioAplicacionExternaUsuario> UsuarioAplicacionExternaUsuarios { get; set; }

    public virtual DbSet<VInventarioDispositivo> VInventarioDispositivos { get; set; }

    public virtual DbSet<Vacacion> Vacacions { get; set; }

    public virtual DbSet<Vale> Vales { get; set; }

    public virtual DbSet<ValorAtributo> ValorAtributos { get; set; }

    public virtual DbSet<VentaCaby> VentaCabies { get; set; }

    public virtual DbSet<VentaPedido> VentaPedidos { get; set; }

    public virtual DbSet<VentaPedidoInventario> VentaPedidoInventarios { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    public virtual DbSet<VerificacionEmbarque> VerificacionEmbarques { get; set; }

    public virtual DbSet<VerificacionEmpaque> VerificacionEmpaques { get; set; }

    public virtual DbSet<VerificacionInventario> VerificacionInventarios { get; set; }

    public virtual DbSet<VerificacionInventarioUbicacion> VerificacionInventarioUbicacions { get; set; }

    public virtual DbSet<VwSalidaDispositivo> VwSalidaDispositivos { get; set; }

    public virtual DbSet<VwServicioPagoEfectivo> VwServicioPagoEfectivos { get; set; }

    public virtual DbSet<Webhook> Webhooks { get; set; }

    public virtual DbSet<ZonaRoja> ZonaRojas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdministracionDocumento>(entity =>
        {
            entity.HasKey(e => e.CodigoAdministracionDocumento);

            entity.ToTable("AdministracionDocumento");

            entity.Property(e => e.CodigoAdministracionDocumento).ValueGeneratedNever();
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEliminacion).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoArchivoNavigation).WithMany(p => p.AdministracionDocumentos)
                .HasForeignKey(d => d.CodigoArchivo)
                .HasConstraintName("FK_Archivo_AdministracionDocumento_CodigoArchivo");

            entity.HasOne(d => d.CodigoTipoDocumentoNavigation).WithMany(p => p.AdministracionDocumentos)
                .HasForeignKey(d => d.CodigoTipoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoDoucmento_AdministracionDocumento_CodigoTipoDocumento");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.AdministracionDocumentoCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_AdministracionDocumento_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioDocumentoNavigation).WithMany(p => p.AdministracionDocumentoCodigoUsuarioDocumentoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_AdministracionDocumento_CodigoUsuario");

            entity.HasOne(d => d.CodigoUsuarioEliminacionNavigation).WithMany(p => p.AdministracionDocumentoCodigoUsuarioEliminacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEliminacion)
                .HasConstraintName("FK_Usuario_AdministracionDocumento_CodigoUsuarioEliminacion");
        });

        modelBuilder.Entity<AdministracionDocumentoTarjetum>(entity =>
        {
            entity.HasNoKey();

            entity.HasOne(d => d.CodigoArchivoNavigation).WithMany()
                .HasForeignKey(d => d.CodigoArchivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AdministracionDocumentoTarjeta_Archivo");

            entity.HasOne(d => d.CodigoSolicitudDocumentoTarjetaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoSolicitudDocumentoTarjeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AdministracionDocumentoTarjeta_SolicitudDocumentoTarjeta");
        });

        modelBuilder.Entity<Alertum>(entity =>
        {
            entity.HasKey(e => e.CodigoAlerta).HasName("PK_Alerta_CodigoAlerta");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.AlertumCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .HasConstraintName("FK_Alerta_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.AlertumCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_Alerta_CodigoUsuarioModificacion");

            entity.HasOne(d => d.CodigoWebhookNavigation).WithMany(p => p.Alerta)
                .HasForeignKey(d => d.CodigoWebhook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Alerta_CodigoWebhook");
        });

        modelBuilder.Entity<Anuncio>(entity =>
        {
            entity.HasKey(e => e.CodigoAnuncio).HasName("PK__Anuncio");

            entity.ToTable("Anuncio");

            entity.Property(e => e.Aprobado).HasDefaultValue(false);
            entity.Property(e => e.CorreoCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cpc).HasColumnName("CPC");
            entity.Property(e => e.Encabezado)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.Enlace)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EnlaceVisible)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.FechaCambioEstado)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacionAnuncio).HasColumnType("datetime");
            entity.Property(e => e.Imagen)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Linea1)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.Linea2)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Paginas)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoClienteNavigation).WithMany(p => p.Anuncios)
                .HasForeignKey(d => d.CodigoCliente)
                .HasConstraintName("FK_Anuncio_Cliente");

            entity.HasOne(d => d.CodigoEstadoDeAnuncioNavigation).WithMany(p => p.Anuncios)
                .HasForeignKey(d => d.CodigoEstadoDeAnuncio)
                .HasConstraintName("FK_Anuncio_EstadoDeAnuncio");

            entity.HasOne(d => d.CodigoTipoDeAnuncioNavigation).WithMany(p => p.Anuncios)
                .HasForeignKey(d => d.CodigoTipoDeAnuncio)
                .HasConstraintName("FK__Anuncio__CodigoTipoDeAnuncio");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.Anuncios)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_Anuncio_Usuario");

            entity.HasMany(d => d.PaginasNavigation).WithMany(p => p.Anuncios)
                .UsingEntity<Dictionary<string, object>>(
                    "AnuncioPagina",
                    r => r.HasOne<Pagina>().WithMany()
                        .HasForeignKey("Pagina")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AnuncioPagina__Pagina"),
                    l => l.HasOne<Anuncio>().WithMany()
                        .HasForeignKey("Anuncio")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AnuncioPagina__Anuncio"),
                    j =>
                    {
                        j.HasKey("Anuncio", "Pagina").HasName("PK__AnuncioPagina");
                        j.ToTable("AnuncioPagina");
                    });
        });

        modelBuilder.Entity<AnuncioAprobacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AnuncioAprobacion");

            entity.HasIndex(e => e.CodigoAnuncio, "IDX_CodigoAnuncio");

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnuncioExterno>(entity =>
        {
            entity.HasKey(e => new { e.CodigoProducto, e.CodigoPlataformaAnuncioExterno }).HasName("PK__AnuncioE__3944C7D60D7522A2");

            entity.ToTable("AnuncioExterno");

            entity.Property(e => e.FechaCreacionAnuncio).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEliminacionAnuncio).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacionAnuncio).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoPlataformaAnuncioExternoNavigation).WithMany(p => p.AnuncioExternos)
                .HasForeignKey(d => d.CodigoPlataformaAnuncioExterno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnuncioExterno_CodigoPlataformaAnuncioExterno");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.AnuncioExternos)
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnuncioExterno_CodigoProducto");
        });

        modelBuilder.Entity<AnuncioRestringido>(entity =>
        {
            entity.HasKey(e => e.CodigoAnuncioRestringido).HasName("PK__AnuncioR__F85452AC041093DD");

            entity.ToTable("AnuncioRestringido");

            entity.Property(e => e.Palabra)
                .HasMaxLength(700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AplicacionExterna>(entity =>
        {
            entity.HasKey(e => e.CodigoAplicacionExterna);

            entity.ToTable("AplicacionExterna");

            entity.HasIndex(e => e.CodigoTipoAplicacionExterna, "IDX_AplicacionExterna_CodigoTipoAplicacionExterna").HasFillFactor(100);

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoTipoAplicacionExternaNavigation).WithMany(p => p.AplicacionExternas)
                .HasForeignKey(d => d.CodigoTipoAplicacionExterna)
                .HasConstraintName("FK_AplicacionExterna_TipoAplicacionExterna");
        });

        modelBuilder.Entity<AplicacionPlaza>(entity =>
        {
            entity.HasKey(e => e.CodigoAplicacionPlaza).HasName("PK_AplicacionPlaza_CodigoAplicacionPlaza");

            entity.ToTable("AplicacionPlaza");

            entity.HasIndex(e => e.CodigoEstadoAplicacionPlaza, "IDX_AplicacionPlaza_CodigoEstadoAplicacionPlaza_CodigoPlazaFechaAplicacionPlaza");

            entity.Property(e => e.CodigoEstadoAplicacionPlaza).HasDefaultValue(1);
            entity.Property(e => e.FechaAplicacionPlaza).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaAprobacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEntrevistaJefatura).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEnvioPruebaPsicometrica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaInicioLabores).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaPruebaPsicometrica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaPruebaTecnica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRechazo).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistroConfirmaAsistencia).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistroConfirmacionEntrevistaJefatura).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistroDocumentoPruebaTecnica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistroEntrevistaJefatura).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistroPruebaTecnica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistroReferencia).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistroResultadoPruebaPsicometrica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistroResultadoPruebaTecnica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistroRevisionCvJefatura).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaResultadoEntrevistaJefatura).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaSolicitudReferencia).HasColumnType("smalldatetime");
            entity.Property(e => e.InformePsicometrico)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PretensionSalarial).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PruebaTecnica)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReferenciaLaboral)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoCandidatoNavigation).WithMany(p => p.AplicacionPlazas)
                .HasForeignKey(d => d.CodigoCandidato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionPlaza_CodigoCandidato");

            entity.HasOne(d => d.CodigoEstadoAplicacionPlazaNavigation).WithMany(p => p.AplicacionPlazas)
                .HasForeignKey(d => d.CodigoEstadoAplicacionPlaza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AplicacionPlaza_CodigoEstadoAplicacionPlaza");

            entity.HasOne(d => d.CodigoMedioAplicacionPlazaNavigation).WithMany(p => p.AplicacionPlazas)
                .HasForeignKey(d => d.CodigoMedioAplicacionPlaza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedioAplicacionPlaza_CodigoMedioAplicacionPlaza");

            entity.HasOne(d => d.CodigoPlazaNavigation).WithMany(p => p.AplicacionPlazas)
                .HasForeignKey(d => d.CodigoPlaza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionPlaza_CodigoPlaza");

            entity.HasOne(d => d.CodigoUsuarioAprobacionNavigation).WithMany(p => p.AplicacionPlazaCodigoUsuarioAprobacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioAprobacion)
                .HasConstraintName("FK_Usuario_CodigoUsuarioAprobacion");

            entity.HasOne(d => d.CodigoUsuarioRechazoNavigation).WithMany(p => p.AplicacionPlazaCodigoUsuarioRechazoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioRechazo)
                .HasConstraintName("FK_Usuario_CodigoUsuarioRechazo");
        });

        modelBuilder.Entity<Arancel>(entity =>
        {
            entity.HasKey(e => e.CodigoArancel).HasName("PK__Arancel");

            entity.ToTable("Arancel");
        });

        modelBuilder.Entity<Archivo>(entity =>
        {
            entity.HasKey(e => e.CodigoArchivo);

            entity.ToTable("Archivo");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.FechaArchivo).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Ruta).HasMaxLength(500);

            entity.HasOne(d => d.CodigoCarpetaNavigation).WithMany(p => p.Archivos)
                .HasForeignKey(d => d.CodigoCarpeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Archivo_Carpeta");

            entity.HasOne(d => d.CodigoUsuarioArchivoNavigation).WithMany(p => p.Archivos)
                .HasForeignKey(d => d.CodigoUsuarioArchivo)
                .HasConstraintName("FK_CodigoUsuarioArchivo");
        });

        modelBuilder.Entity<ArchivoEstablecimiento>(entity =>
        {
            entity.HasKey(e => e.CodigoArchivoEstablecimiento).HasName("PK_ArchivoEstablecimiento_CodigoArchivoEstablecimiento");

            entity.ToTable("ArchivoEstablecimiento");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ruta)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoEstablecimientoNavigation).WithMany(p => p.ArchivoEstablecimientos)
                .HasForeignKey(d => d.CodigoEstablecimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArchivoEstablecimiento_CodigoEstablecimiento");
        });

        modelBuilder.Entity<ArchivoMenu>(entity =>
        {
            entity.HasKey(e => e.CodigoArchivoMenu).HasName("PK__ArchivoMenu");

            entity.ToTable("ArchivoMenu");

            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ArchivoPaquete>(entity =>
        {
            entity.HasKey(e => e.CodigoArchivoPaquete).HasName("PK_ArchivoPaquete_CodigoArchivoPaquete");

            entity.ToTable("ArchivoPaquete");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaUsuarioElimina).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioRegistro).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ruta)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoPaqueteNavigation).WithMany(p => p.ArchivoPaquetes)
                .HasForeignKey(d => d.CodigoPaquete)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArchivoPaquete_CodigoPaquete");

            entity.HasOne(d => d.CodigoUsuarioEliminaNavigation).WithMany(p => p.ArchivoPaqueteCodigoUsuarioEliminaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioElimina)
                .HasConstraintName("FK_ArchivoPaquete_CodigoUsuarioElimina");

            entity.HasOne(d => d.CodigoUsuarioRegistroNavigation).WithMany(p => p.ArchivoPaqueteCodigoUsuarioRegistroNavigations)
                .HasForeignKey(d => d.CodigoUsuarioRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArchivoPaquete_CodigoUsuarioRegistro");
        });

        modelBuilder.Entity<ArchivoReembolso>(entity =>
        {
            entity.HasKey(e => e.CodigoArchivoReembolso);

            entity.ToTable("ArchivoReembolso");

            entity.Property(e => e.UrlarchivoReembolso)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("URLArchivoReembolso");

            entity.HasOne(d => d.CodigoCobroNavigation).WithMany(p => p.ArchivoReembolsos)
                .HasForeignKey(d => d.CodigoCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArchivoReembolso_CodigoCobro");
        });

        modelBuilder.Entity<ArchivoTarea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArchivoTarea");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ruta)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoTareaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoTarea)
                .HasConstraintName("FK_ArchivoTarea_Tarea");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_ArchivoTarea_Usuario");
        });

        modelBuilder.Entity<Asueto>(entity =>
        {
            entity.HasKey(e => e.Fecha).HasName("PK__Asueto__B30C8A5F70B53913");

            entity.ToTable("Asueto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Atraso>(entity =>
        {
            entity.HasKey(e => e.CodigoAtraso).HasName("PK__Atraso");

            entity.ToTable("Atraso");

            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Atributo>(entity =>
        {
            entity.HasKey(e => e.CodigoAtributo);

            entity.ToTable("Atributo");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.CodigoBanco);

            entity.ToTable("Banco");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pagina)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BienOservicio>(entity =>
        {
            entity.HasKey(e => e.CodigoBienOservicio).HasName("PK__BienOSer__5BC568D79719C722");

            entity.ToTable("BienOServicio");

            entity.Property(e => e.CodigoBienOservicio).HasColumnName("CodigoBienOServicio");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Bitacora>(entity =>
        {
            entity.HasKey(e => e.CodigoBitacora).HasName("PK__Bitacora");

            entity.ToTable("Bitacora");

            entity.HasIndex(e => e.Correo, "IDX_Bitacora_Correo_FechaNota");

            entity.HasIndex(e => e.Fecha, "IDX_Bitacora_Fecha_Correo");

            entity.Property(e => e.Archivo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nota)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Resultado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BitacoraGestionFactura>(entity =>
        {
            entity.HasKey(e => e.CodigoBitacoraGestionFactura).HasName("PK_CodigoBitacoraGestionFactura");

            entity.ToTable("BitacoraGestionFactura");

            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.BitacoraGestionFacturaCodigoFacturaNavigations)
                .HasForeignKey(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraGestionFactura_CodigoFactura");

            entity.HasOne(d => d.CodigoFacturaPadreNavigation).WithMany(p => p.BitacoraGestionFacturaCodigoFacturaPadreNavigations)
                .HasForeignKey(d => d.CodigoFacturaPadre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraGestionFactura_CodigoFacturaPadre");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.BitacoraGestionFacturas)
                .HasForeignKey(d => d.CodigoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraGestionFactura_CodigoUsuario");
        });

        modelBuilder.Entity<BitacoraManifiesto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BitacoraManifiesto");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK__BitacoraM__Codig__72457F0C");
        });

        modelBuilder.Entity<BitacoraMembresium>(entity =>
        {
            entity.HasKey(e => e.CodigoBitacoraMembresia).HasName("PK__Bitacora__D1CCD0C76EBC3DFE");

            entity.Property(e => e.FechaActivacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.BitacoraMembresia)
                .HasForeignKey(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraMembresia_Factura");

            entity.HasOne(d => d.CodigoMembresiaNavigation).WithMany(p => p.BitacoraMembresia)
                .HasForeignKey(d => d.CodigoMembresia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraMembresia_Membresia");

            entity.HasOne(d => d.CodigoMovimientoMembresiaNavigation).WithMany(p => p.BitacoraMembresia)
                .HasForeignKey(d => d.CodigoMovimientoMembresia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraMembresia_MovimientoMembresia");
        });

        modelBuilder.Entity<BitacoraPorcentajeCod>(entity =>
        {
            entity.HasKey(e => e.CodigoBitacoraPorcentajeCod).HasName("PK_BitacoraPorcentajeCOD_CodigoBitacoraPorcentajeCOD");

            entity.ToTable("BitacoraPorcentajeCOD");

            entity.Property(e => e.CodigoBitacoraPorcentajeCod).HasColumnName("CodigoBitacoraPorcentajeCOD");
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.PorcentajeComisionCod)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("PorcentajeComisionCOD");

            entity.HasOne(d => d.CodigoEmpresaDeEntregaNavigation).WithMany(p => p.BitacoraPorcentajeCods)
                .HasForeignKey(d => d.CodigoEmpresaDeEntrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraPorcentajeCOD_CodigoEmpresaDeEntrega");
        });

        modelBuilder.Entity<BitacoraProceso>(entity =>
        {
            entity.HasKey(e => e.CodigoBitacoraProceso).HasName("PK__Bitacora__F32DB953BF555F26");

            entity.ToTable("BitacoraProceso");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoProcesoNavigation).WithMany(p => p.BitacoraProcesos)
                .HasForeignKey(d => d.CodigoProceso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proceso_CodigoProceso");
        });

        modelBuilder.Entity<BitacoraRegimenProveedor>(entity =>
        {
            entity.HasKey(e => e.CodigoBitacoraRegimenProveedor).HasName("PK__Bitacora__7938AE4F935710BB");

            entity.ToTable("BitacoraRegimenProveedor");

            entity.Property(e => e.FechaCambioRegimen).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.CodigoProveedorNavigation).WithMany(p => p.BitacoraRegimenProveedors)
                .HasForeignKey(d => d.CodigoProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraRegimenProveedor_CodigoProveedor");

            entity.HasOne(d => d.CodigoRegimenNavigation).WithMany(p => p.BitacoraRegimenProveedors)
                .HasForeignKey(d => d.CodigoRegimen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraRegimenProveedor_CodigoRegimen");

            entity.HasOne(d => d.CodigoUsuarioModificacionRegimenNavigation).WithMany(p => p.BitacoraRegimenProveedors)
                .HasForeignKey(d => d.CodigoUsuarioModificacionRegimen)
                .HasConstraintName("FK_BitacoraRegimenProveedor_CodigoUsuarioModificacionRegimen");
        });

        modelBuilder.Entity<BitacoraServicioCaby>(entity =>
        {
            entity.HasKey(e => e.CodigoBitacoraServicioCaby).HasName("PK_CodigoBitacoraServicioCaby");

            entity.ToTable("BitacoraServicioCaby");

            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoCabyNavigation).WithMany(p => p.BitacoraServicioCabies)
                .HasForeignKey(d => d.CodigoCaby)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraServicioCaby_CodigoCaby");

            entity.HasOne(d => d.CodigoServicioNavigation).WithMany(p => p.BitacoraServicioCabies)
                .HasForeignKey(d => d.CodigoServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BitacoraServicioCaby_CodigoServicio");
        });

        modelBuilder.Entity<BusquedaPagina>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BusquedaPagina");

            entity.Property(e => e.CadenaBuscar)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Busquedum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Texto)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Caby>(entity =>
        {
            entity.HasKey(e => e.CodigoCaby).HasName("PK_CodigoCaby");

            entity.ToTable("Caby");

            entity.HasIndex(e => e.IdentificadorCategoriaCaby, "UQ__Caby__344EDA5675A99E60").IsUnique();

            entity.Property(e => e.IdentificadorCategoriaCaby)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoCaby).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NombreCaby)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Caja");

            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoCuentaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoCuenta)
                .HasConstraintName("FK__Caja__CodigoCuen__5EF2125F");
        });

        modelBuilder.Entity<CampaniaExterna>(entity =>
        {
            entity.HasKey(e => e.CodigoCampaniaExterna).HasName("PK_CampaniaExterna_CodigoCampaniaExterna");

            entity.ToTable("CampaniaExterna");

            entity.HasIndex(e => new { e.NombreCampaniaExterna, e.CodigoPlataformaAnuncioExterno }, "UQ_CampaniaExterna_CodigoCampaniaExterna_CodigoPlataformaAnuncioExterno").IsUnique();

            entity.Property(e => e.NombreCampaniaExterna)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CodigoPlataformaAnuncioExternoNavigation).WithMany(p => p.CampaniaExternas)
                .HasForeignKey(d => d.CodigoPlataformaAnuncioExterno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CampaniaExterna_CodigoPlataformaAnuncioExterno");
        });

        modelBuilder.Entity<Candidato>(entity =>
        {
            entity.HasKey(e => e.CodigoCandidato).HasName("PK_Candidato_CodigoCandidato");

            entity.ToTable("Candidato");

            entity.HasIndex(e => e.Cui, "UQ_Candidato_CUI").IsUnique();

            entity.Property(e => e.CodigoTipoDocumento).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Cui)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CUI");
            entity.Property(e => e.Cv)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CV");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Profesion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TituloAcademico)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoTipoDocumentoNavigation).WithMany(p => p.Candidatos)
                .HasForeignKey(d => d.CodigoTipoDocumento)
                .HasConstraintName("FK_Candidato_CodigoTipoDocumento");
        });

        modelBuilder.Entity<Carpetum>(entity =>
        {
            entity.HasKey(e => e.CodigoCarpeta);

            entity.HasIndex(e => new { e.CodigoCarpetaPadre, e.Activo }, "IDX_Carpeta_CodigoCarpetaPadre_Activo");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Ruta).HasMaxLength(500);

            entity.HasOne(d => d.CodigoCarpetaPadreNavigation).WithMany(p => p.InverseCodigoCarpetaPadreNavigation)
                .HasForeignKey(d => d.CodigoCarpetaPadre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Carpeta_Carpeta");
        });

        modelBuilder.Entity<CategoriaMensaje>(entity =>
        {
            entity.HasKey(e => e.CodigoCategoriaMensaje).HasName("PK__Categori__0DC1D0964CBF6CE8");

            entity.ToTable("CategoriaMensaje");

            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CategoriaNoAutomatizable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CategoriaNoAutomatizable");

            entity.Property(e => e.BrowseNodeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BrowseNodeID");
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.CodigoCategoria);

            entity.HasIndex(e => e.AnuncioId, "IDX_AnuncioId");

            entity.HasIndex(e => e.CampaniaId, "IDX_CampaniaId");

            entity.HasIndex(e => e.BrowseNodeId, "IDX_Categoria_BrowseNodeID").IsUnique();

            entity.HasIndex(e => new { e.BrowseNodeId, e.NoBuscarEnKeepa }, "IDX_Categoria_BrowseNodeIDNoBuscarEnKeepa");

            entity.HasIndex(e => e.CodigoCategoria, "IDX_Categoria_CodCategoria_NombreArancel");

            entity.HasIndex(e => e.GrupoId, "IDX_GrupoId");

            entity.HasIndex(e => e.Nombre, "IDX_Nombre");

            entity.HasIndex(e => e.NombreEnIngles, "IDX_NombreEnIngles");

            entity.HasIndex(e => e.CodigoCategoria, "_dta_index_Categoria_6_1051150790__K1_2");

            entity.HasIndex(e => e.NoPublicar, "_dta_index_Categoria_6_1051150790__K25_1_2_26_27");

            entity.Property(e => e.CodigoCategoria).ValueGeneratedNever();
            entity.Property(e => e.AmazonHtml).HasColumnName("AmazonHTML");
            entity.Property(e => e.AmazonHtmlcategoria).HasColumnName("AmazonHTMLCategoria");
            entity.Property(e => e.AmazonJson)
                .IsUnicode(false)
                .HasColumnName("AmazonJSON");
            entity.Property(e => e.AmazonJsoncategoria)
                .IsUnicode(false)
                .HasColumnName("AmazonJSONCategoria");
            entity.Property(e => e.BrowseNodeId).HasMaxLength(50);
            entity.Property(e => e.CampaniaStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionArancelaria)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionNodo).HasMaxLength(255);
            entity.Property(e => e.FechaAnuncio).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModifica).HasColumnType("smalldatetime");
            entity.Property(e => e.Foto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GrupoStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GuatemalaDigitalJson)
                .IsUnicode(false)
                .HasColumnName("GuatemalaDigitalJSON");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreEnIngles)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PartidaArancelaria)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SearchIndex).HasMaxLength(50);

            entity.HasOne(d => d.CodigoIndiceDeBusquedaNavigation).WithMany(p => p.Categoria)
                .HasForeignKey(d => d.CodigoIndiceDeBusqueda)
                .HasConstraintName("FK_Categoria_IndiceDeBusqueda");

            entity.HasOne(d => d.CodigoUsuarioModificaNavigation).WithMany(p => p.Categoria)
                .HasForeignKey(d => d.CodigoUsuarioModifica)
                .HasConstraintName("FK_Categoria_CodigoUsuarioModifica");

            entity.HasMany(d => d.CodigoAtributos).WithMany(p => p.CodigoCategoria)
                .UsingEntity<Dictionary<string, object>>(
                    "CategoriaAtributo",
                    r => r.HasOne<Atributo>().WithMany()
                        .HasForeignKey("CodigoAtributo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Atributo_CategoriaAtributo"),
                    l => l.HasOne<Categorium>().WithMany()
                        .HasForeignKey("CodigoCategoria")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Categoria_CategoriaAtributo"),
                    j =>
                    {
                        j.HasKey("CodigoCategoria", "CodigoAtributo");
                        j.ToTable("CategoriaAtributo");
                    });
        });

        modelBuilder.Entity<CierreContable>(entity =>
        {
            entity.HasKey(e => e.CodigoCierreContable).HasName("PK__CierreCo__3E184120F5122B9A");

            entity.ToTable("CierreContable");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioReversion).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.CierreContableCodigoUsuarioNavigations)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_CIERRECONTABLE_USUARIO");

            entity.HasOne(d => d.CodigoUsuarioReversionNavigation).WithMany(p => p.CierreContableCodigoUsuarioReversionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioReversion)
                .HasConstraintName("FK_CierreContable_CodigoUsuarioReversion");
        });

        modelBuilder.Entity<CierreDeCaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CierreDeCaja");

            entity.HasIndex(e => new { e.Estado, e.CodigoCuenta }, "IDX_CierreDeCaja_EstadoCodigoCuenta_Fecha");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaReversion).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoEnCaja).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoCuentaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoCuenta)
                .HasConstraintName("FK__CierreDeC__Codig__6526E146");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_Cierredecaja_Usuario");

            entity.HasOne(d => d.CodigoUsuarioReversionNavigation).WithMany()
                .HasForeignKey(d => d.CodigoUsuarioReversion)
                .HasConstraintName("FK_CierreDeCaja_UsuarioReversion");
        });

        modelBuilder.Entity<ClaseCuentaContable>(entity =>
        {
            entity.HasKey(e => e.CodigoClaseCuentaContable).HasName("PK__ClaseCue__E3DA96E07FF5B00E");

            entity.ToTable("ClaseCuentaContable");

            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaseDeGasto>(entity =>
        {
            entity.HasKey(e => e.CodigoClaseDeGasto).HasName("PK__ClaseDeG__0EB2B3E805AE8964");

            entity.ToTable("ClaseDeGasto");

            entity.Property(e => e.Nombre)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaseDocumento>(entity =>
        {
            entity.HasKey(e => e.CodigoClaseDocumento).HasName("PK__ClaseDoc__CAB654091B9DCA83");

            entity.ToTable("ClaseDocumento");

            entity.Property(e => e.Nombre)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaseTipoAplicacionExterna>(entity =>
        {
            entity.HasKey(e => e.CodigoClaseTipoAplicacionExterna).HasName("PK_CodigoClaseTipoAplicacionExterna");

            entity.ToTable("ClaseTipoAplicacionExterna");

            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Click>(entity =>
        {
            entity.HasKey(e => new { e.CodigoAnuncio, e.Fecha }).HasName("PK__Click");

            entity.ToTable("Click");

            entity.HasIndex(e => e.CodigoVenta, "IDX_Click_CodigoVenta");

            entity.HasIndex(e => e.CodigoVenta, "IDX_Click_CodigoVenta_CPC");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Cpc).HasColumnName("CPC");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.Clicks)
                .HasForeignKey(d => d.CodigoVenta)
                .HasConstraintName("FK_Click_CodigoVenta");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.CodigoCliente);

            entity.ToTable("Cliente");

            entity.HasIndex(e => e.Correo, "CK_Cliente_Correo")
                .IsUnique()
                .HasFilter("([Correo] IS NOT NULL)");

            entity.HasIndex(e => e.Correo, "IDX_Cliente_Correo");

            entity.Property(e => e.CodigoCliente).ValueGeneratedNever();
            entity.Property(e => e.Clave).HasMaxLength(256);
            entity.Property(e => e.Correo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DireccionFactura)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaModificacionBloqueoEfectivo).HasColumnType("smalldatetime");
            entity.Property(e => e.MontoVale).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Nit)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NombreFactura)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NombreTarjeta)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NumeroTarjeta)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoAlt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoTarjeta)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoUsuarioModificaBloqueoEfectivoNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.CodigoUsuarioModificaBloqueoEfectivo)
                .HasConstraintName("FK_Cliente_CodigoUsuario_CodigoUsuarioModificaBloqueoEfectivo");
        });

        modelBuilder.Entity<Cobro>(entity =>
        {
            entity.HasKey(e => e.CodigoCobro);

            entity.ToTable("Cobro");

            entity.HasIndex(e => new { e.CodigoFormaDePago, e.UsuarioTarjeta, e.FechaConfirmacion, e.CodigoFactura }, "Cobro_Cuotas_MontoCuota_CodigoRedCrediticia_ReferenciaCobroTarjeta");

            entity.HasIndex(e => new { e.ReferenciaCobroTarjeta, e.CodigoFormaDePago, e.Estado }, "Cobro_ReferenciaCobroTarjetaCodigoFormaDePagoEstado_BoletaRevisionCodigoDeRastreo");

            entity.HasIndex(e => new { e.Cod, e.ReferenciaCobroTarjeta }, "IDX_CODReferenciaCobroTarjeta_BoletaRevision");

            entity.HasIndex(e => e.Estado, "IDX_CobroEstado_FecConfirCodFacCodFormaPago");

            entity.HasIndex(e => new { e.BoletaDeposito, e.CodigoBanco, e.CodigoFormaDePago, e.Estado, e.CodigoCobro, e.CodigoFactura, e.Fecha }, "IDX_Cobro_BoletaDepositoCodBancoCodFormaDePagoEstadoCodCobroCodFacturaFecha");

            entity.HasIndex(e => new { e.BoletaDeposito, e.CodigoFormaDePago, e.Estado, e.CodigoBanco }, "IDX_Cobro_BoletaDepositoCodigoFormaDePagoEstadoCodigoBanco");

            entity.HasIndex(e => new { e.BoletaRevision, e.Cod, e.ReferenciaCobroTarjeta }, "IDX_Cobro_BoletaRevisionCODReferenciaCobroTarjeta");

            entity.HasIndex(e => new { e.Cod, e.CodigoDeRastreo }, "IDX_Cobro_CODCodigoDeRastreo");

            entity.HasIndex(e => new { e.Cod, e.ReferenciaCobroTarjeta }, "IDX_Cobro_CODReferenciaCobroTarjeta_FechaConfirmacion");

            entity.HasIndex(e => new { e.CodigoCobro, e.CodigoFormaDePago, e.Estado, e.CodigoFactura }, "IDX_Cobro_CodCobroCodFormaDePagoEstadoCodFactura");

            entity.HasIndex(e => new { e.CodigoCobro, e.CodigoFormaDePago, e.Estado, e.CodigoFactura }, "IDX_Cobro_CodCobroCodFormaDePagoEstadoCodFactura_CuotaMontoCuota");

            entity.HasIndex(e => new { e.CodigoFactura, e.CodigoRedCrediticia, e.CodigoFormaDePago }, "IDX_Cobro_CodFacturaCodRedCrediticiaCodFormaDePago_CuotasMontoCuotaCodCuenta");

            entity.HasIndex(e => new { e.CodigoFormaDePago, e.Estado }, "IDX_Cobro_CodForPagoEstado_MontoCuotaCodFactura");

            entity.HasIndex(e => new { e.CodigoFormaDePago, e.Estado, e.FechaConfirmacion, e.ReferenciaCobroTarjeta, e.BoletaRevision, e.Cod }, "IDX_Cobro_CodFormPagoEstFecConfirmacionRefCobroTarjetaBoletaRevCOD_CouotasMontoCuotaUsuarioEfecCodFacCodRastreo");

            entity.HasIndex(e => new { e.CodigoFormaDePago, e.Estado, e.FechaConfirmacion, e.MontoCuota, e.CodigoCobro, e.CodigoFactura, e.Fecha }, "IDX_Cobro_CodFormaDePagoEstadoMontoCuotaCodCobroCodiFacturaFecha_CuotaFechaPago");

            entity.HasIndex(e => new { e.CodigoRedCrediticia, e.CodigoFormaDePago, e.Estado }, "IDX_Cobro_CodRedCrediticiaCodFormaDePagoEstado_CuotasMontoCuotaCodFactura");

            entity.HasIndex(e => new { e.CodigoVenta, e.Estado }, "IDX_Cobro_CodVtaEstado_CodCobroFecNumTarCuotMonCuoNumAutIDTran");

            entity.HasIndex(e => e.CodigoCobro, "IDX_Cobro_CodigoCobro_CuotasBoletaDeositoReferenciaCobroTarjetaCodigoFacturaCodigoFormaDePago");

            entity.HasIndex(e => e.CodigoFactura, "IDX_Cobro_CodigoFactura");

            entity.HasIndex(e => e.CodigoFactura, "IDX_Cobro_CodigoFactura_Fecha");

            entity.HasIndex(e => new { e.CodigoFormaDePago, e.Estado, e.Cod, e.FechaConfirmacion, e.UsuarioPago }, "IDX_Cobro_CodigoFormaDePagoEstadoCODFechaConfirmacionUsuarioPago_MontoCuotaCodigoFactura");

            entity.HasIndex(e => new { e.CodigoFormaDePago, e.Estado, e.Cod, e.UsuarioEfectivo, e.FechaConfirmacion }, "IDX_Cobro_CodigoFormaDePagoEstadoCODUsuarioEfectivoFechaConfirmacion_MontoCuota");

            entity.HasIndex(e => new { e.CodigoFormaDePago, e.Estado }, "IDX_Cobro_CodigoFormaDePagoEstado_FechaCOD");

            entity.HasIndex(e => new { e.Estado, e.CodigoFactura, e.CodigoFormaDePago, e.CodigoCobro }, "IDX_Cobro_EstadoCodFacturaCodFormadepagoCodigoCobro_CuotasMontosCuotaNumeroAutorizacionFechaConfirmacion");

            entity.HasIndex(e => new { e.Estado, e.CodigoFactura, e.MontoCuota, e.CodigoCobro }, "IDX_Cobro_EstadoCodFacturaMontoCuotaCodCobro_FechaFechaConfirCodFormaPago");

            entity.HasIndex(e => new { e.Estado, e.CodigoFactura, e.MontoCuota, e.CodigoFormaDePago, e.CodigoRedCrediticia, e.Cuotas, e.CodigoCobro }, "IDX_Cobro_EstadoCodFacturaMontoCuotaCodFormaPagoCodRedCrediticiaCuotasCodCobro_FechaPago");

            entity.HasIndex(e => new { e.Estado, e.CodigoCodigoCanjeable, e.FechaConfirmacion }, "IDX_Cobro_EstadoCodigoCodigoCanjeableFechaConfirmacion_MontoCuota");

            entity.HasIndex(e => new { e.Estado, e.CodigoFormaDePago, e.FechaConfirmacion, e.CodigoFactura, e.CodigoCobro }, "IDX_Cobro_EstadoCodigodePagoFechaConfirmacionCodigoFacturaCodigoCobro");

            entity.HasIndex(e => new { e.Estado, e.FechaConfirmacion }, "IDX_Cobro_EstadoFechaConfirmacion_MontoCuotaCodigoCodigoCanjeable");

            entity.HasIndex(e => new { e.Estado, e.MontoCuota, e.CodigoFormaDePago }, "IDX_Cobro_EstadoMontoCuotaCodigoFormaDePago_CodigoFactura");

            entity.HasIndex(e => new { e.MontoCuota, e.Estado }, "IDX_Cobro_EstadoMontoCuota_CuotasCodigoFactura");

            entity.HasIndex(e => new { e.Estado, e.CodigoFormaDePago, e.CodigoFactura, e.Fecha, e.CodigoCobro, e.FechaConfirmacion, e.MontoCuota }, "IDX_Cobro_Estado_CodFormDPagoCodFacturaFechaCodCobroFechaConfiMontoCuota_Cuota");

            entity.HasIndex(e => e.Estado, "IDX_Cobro_Estado_CuotasMontoCuotaCodigoRedCrediticiaCodigoFacturaCodigoFormaDePago");

            entity.HasIndex(e => e.Estado, "IDX_Cobro_Estado_FechaMontoCuotaFechaConfirmacionCodigoFacutraCodigoFormaDePago");

            entity.HasIndex(e => new { e.FechaConfirmacion, e.Cod, e.CodigoDeRastreo }, "IDX_Cobro_FechaConfirmacionCODCodigoDeRastreo");

            entity.HasIndex(e => new { e.FechaConfirmacion, e.Estado }, "IDX_Cobro_FechaConfirmacionEstado");

            entity.HasIndex(e => new { e.FechaConfirmacion, e.ReferenciaCobroTarjeta, e.CodigoFormaDePago, e.Estado, e.Cod }, "IDX_Cobro_FechaConfirmacion_ReferenciaCobroTarjeta_CodigoFormaDePago_Estado_COD");

            entity.HasIndex(e => e.ReferenciaCobroTarjeta, "IDX_Cobro_ReferenciaCobroTarjeta_FechaConfirmacion");

            entity.HasIndex(e => new { e.UsuarioDeposito, e.FechaConfirmacion, e.Estado, e.CodigoFormaDePago }, "IDX_Cobro_UsuarioDepositoFehaconfirmacionEstadoCodigoFormaDePago");

            entity.HasIndex(e => new { e.UsuarioEfectivo, e.FechaConfirmacion, e.CodigoFormaDePago, e.Estado, e.Cod }, "IDX_Cobro_UsuarioEfecFecConfirCodFormaPagoEstCOD");

            entity.HasIndex(e => new { e.UsuarioTarjeta, e.FechaConfirmacion, e.CodigoFormaDePago, e.Estado, e.CodigoFactura }, "IDX_Cobro_UsuarioTarjetaFechaConfirmacionCodigoDePagoEstadoCodigoFactura");

            entity.HasIndex(e => new { e.CodigoBanco, e.BoletaDeposito, e.CodigoFormaDePago, e.Estado }, "IDX_CodigoBancoBoletaDepositoCodigoFormaDePagoEstadd");

            entity.HasIndex(e => new { e.Estado, e.CodigoCobro }, "IDX_Factura_SerieDeFacturaSinFactura");

            entity.HasIndex(e => new { e.CodigoFormaDePago, e.BoletaDeposito, e.Estado, e.CodigoBanco, e.CodigoCobro, e.FechaPago, e.CodigoFactura }, "IDX_cobro_CodFormaDePagoBoletaDepositoEstadoCodBancoCodCobroFechaPagoCodFactura");

            entity.Property(e => e.CodigoCobro).ValueGeneratedNever();
            entity.Property(e => e.BoletaDeposito)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BoletaRevision)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Cod).HasColumnName("COD");
            entity.Property(e => e.CodigoDeRastreo)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.CodigoSeguridad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DatosDeSeguridad)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaConfirmacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEliminacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaPago).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioCaptura).HasColumnType("smalldatetime");
            entity.Property(e => e.IdDeTransaccion)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.MontoCuota).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NombreTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumeroAutorizacion)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDeAuditoria)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NumeroTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PorcentajeComision).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ReembolsoTc).HasColumnName("ReembolsoTC");
            entity.Property(e => e.ReferenciaCobroTarjeta)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.VencimientoTarjeta)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoBancoNavigation).WithMany(p => p.Cobros)
                .HasForeignKey(d => d.CodigoBanco)
                .HasConstraintName("FK_Cobro_Banco");

            entity.HasOne(d => d.CodigoCodigoCanjeableNavigation).WithMany(p => p.Cobros)
                .HasForeignKey(d => d.CodigoCodigoCanjeable)
                .HasConstraintName("FK_Cobro_CodigoCodigoCanjeable");

            entity.HasOne(d => d.CodigoCuentaNavigation).WithMany(p => p.Cobros)
                .HasForeignKey(d => d.CodigoCuenta)
                .HasConstraintName("FK_Cobro_CodigoCuenta");

            entity.HasOne(d => d.CodigoFormaDePagoNavigation).WithMany(p => p.Cobros)
                .HasForeignKey(d => d.CodigoFormaDePago)
                .HasConstraintName("FK_Cobro_FormaDePago");

            entity.HasOne(d => d.CodigoRedCrediticiaNavigation).WithMany(p => p.Cobros)
                .HasForeignKey(d => d.CodigoRedCrediticia)
                .HasConstraintName("FK_Cobro_RedCrediticia");

            entity.HasOne(d => d.CodigoTipoDeTarjetaNavigation).WithMany(p => p.Cobros)
                .HasForeignKey(d => d.CodigoTipoDeTarjeta)
                .HasConstraintName("FK_Cobro_TipoDeTarjeta");

            entity.HasOne(d => d.CodigoTipoTransaccionTempNavigation).WithMany(p => p.Cobros)
                .HasForeignKey(d => d.CodigoTipoTransaccionTemp)
                .HasConstraintName("FK_Cobro_TipoTransaccion");

            entity.HasOne(d => d.CodigoUsuarioCapturaNavigation).WithMany(p => p.CobroCodigoUsuarioCapturaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCaptura)
                .HasConstraintName("FK_Cobro_CodigoUsuarioCaptura");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.CobroCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .HasConstraintName("FK__Cobro__CodigoUsu__22A81137");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.CobroCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_Cobro_Usuario_Modificacion");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.Cobros)
                .HasForeignKey(d => d.CodigoVenta)
                .HasConstraintName("FK_Cobro_Venta");

            entity.HasOne(d => d.UsuarioCobroNavigation).WithMany(p => p.CobroUsuarioCobroNavigations)
                .HasForeignKey(d => d.UsuarioCobro)
                .HasConstraintName("FK_Cobro_Usuario");

            entity.HasOne(d => d.UsuarioCreditoNavigation).WithMany(p => p.CobroUsuarioCreditoNavigations)
                .HasForeignKey(d => d.UsuarioCredito)
                .HasConstraintName("FK_Cobro_UsuarioCredito");

            entity.HasOne(d => d.UsuarioDepositoNavigation).WithMany(p => p.CobroUsuarioDepositoNavigations)
                .HasForeignKey(d => d.UsuarioDeposito)
                .HasConstraintName("FK_Cobro_UsuarioDeposito");

            entity.HasOne(d => d.UsuarioEfectivoNavigation).WithMany(p => p.CobroUsuarioEfectivoNavigations)
                .HasForeignKey(d => d.UsuarioEfectivo)
                .HasConstraintName("FK_Cobro_UsuarioEfectivo");

            entity.HasOne(d => d.UsuarioExencionNavigation).WithMany(p => p.CobroUsuarioExencionNavigations)
                .HasForeignKey(d => d.UsuarioExencion)
                .HasConstraintName("FK_Cobro_UsuarioExencion");

            entity.HasOne(d => d.UsuarioPagoNavigation).WithMany(p => p.CobroUsuarioPagoNavigations)
                .HasForeignKey(d => d.UsuarioPago)
                .HasConstraintName("FK_Cobro_UsuarioPago");

            entity.HasOne(d => d.UsuarioRevisionNavigation).WithMany(p => p.CobroUsuarioRevisionNavigations)
                .HasForeignKey(d => d.UsuarioRevision)
                .HasConstraintName("FK_Cobro_UsuarioRevision");

            entity.HasOne(d => d.UsuarioTarjetaNavigation).WithMany(p => p.CobroUsuarioTarjetaNavigations)
                .HasForeignKey(d => d.UsuarioTarjeta)
                .HasConstraintName("FK_Cobro_Tarjeta");
        });

        modelBuilder.Entity<CobroReembolso>(entity =>
        {
            entity.HasKey(e => e.CodigoCobroReembolso).HasName("PK_CodigoReembolso_CodigoCobroReembolso");

            entity.ToTable("CobroReembolso");

            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoCobroNavigation).WithMany(p => p.CobroReembolsoCodigoCobroNavigations)
                .HasForeignKey(d => d.CodigoCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodigoReembolso_CodigoCobro");

            entity.HasOne(d => d.CodigoCobroReintegroNavigation).WithMany(p => p.CobroReembolsoCodigoCobroReintegroNavigations)
                .HasForeignKey(d => d.CodigoCobroReintegro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodigoReembolso_CodigoCobroReintegro");
        });

        modelBuilder.Entity<CodigoCanjeable>(entity =>
        {
            entity.HasKey(e => e.CodigoCodigoCanjeable).HasName("PK__CodigoCa__A91F3CAA5DC901B3");

            entity.ToTable("CodigoCanjeable");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoGenerado)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioInactivo).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoCobroOrigenNavigation).WithMany(p => p.CodigoCanjeables)
                .HasForeignKey(d => d.CodigoCobroOrigen)
                .HasConstraintName("FK_CodigoCanjeable_CodigoCobroOrigen");

            entity.HasOne(d => d.CodigoFacturaEmisionNavigation).WithMany(p => p.CodigoCanjeables)
                .HasForeignKey(d => d.CodigoFacturaEmision)
                .HasConstraintName("FK_Canje_CodigoFacturaEmision");

            entity.HasOne(d => d.CodigoGarantiaNavigation).WithMany(p => p.CodigoCanjeables)
                .HasForeignKey(d => d.CodigoGarantia)
                .HasConstraintName("FK_Canje_CodigoGarantia");

            entity.HasOne(d => d.CodigoGastoNavigation).WithMany(p => p.CodigoCanjeables)
                .HasForeignKey(d => d.CodigoGasto)
                .HasConstraintName("FK_Canje_CodigoGasto");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.CodigoCanjeables)
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Canje_CodigoProducto");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.CodigoCanjeableCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Canje_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioInactivoNavigation).WithMany(p => p.CodigoCanjeableCodigoUsuarioInactivoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioInactivo)
                .HasConstraintName("FK_Canje_CodigoUsuarioInactivo");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.CodigoCanjeableCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_Canje_CodigoUsuarioModificacion");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.CodigoCanjeables)
                .HasForeignKey(d => d.CodigoVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Canje_CodigoVenta");
        });

        modelBuilder.Entity<CodigoProducto>(entity =>
        {
            entity.HasKey(e => e.CodigoProducto1);

            entity.ToTable("CodigoProducto");

            entity.Property(e => e.CodigoProducto1)
                .ValueGeneratedNever()
                .HasColumnName("CodigoProducto");
            entity.Property(e => e.CodigoAmazon)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CombustibleGasto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CombustibleGasto");

            entity.Property(e => e.Galon).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Idp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IDP");

            entity.HasOne(d => d.CodigoGastoNavigation).WithMany()
                .HasForeignKey(d => d.CodigoGasto)
                .HasConstraintName("FK__Combustib__Codig__32654CCD");

            entity.HasOne(d => d.CodigoTipoCombustibleNavigation).WithMany()
                .HasForeignKey(d => d.CodigoTipoCombustible)
                .HasConstraintName("FK__Combustib__Codig__798480D7");
        });

        modelBuilder.Entity<ConceptoNotaContable>(entity =>
        {
            entity.HasKey(e => e.CodigoConceptoNotaContable);

            entity.ToTable("ConceptoNotaContable");

            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConciliacionBancarium>(entity =>
        {
            entity.HasKey(e => e.CodigoConciliacionBancaria).HasName("PK_CodigoConciliacionBancaria");

            entity.Property(e => e.Conciliado).HasDefaultValue(false);
            entity.Property(e => e.CreditoEstadoCuenta).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreditoSistema).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DebitoEstadoCuenta).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DebitoSistema).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.FechaIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.SaldoInicial).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.CodigoCuentaNavigation).WithMany(p => p.ConciliacionBancaria)
                .HasForeignKey(d => d.CodigoCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConciliacionBancaria_CodigoCuenta");

            entity.HasOne(d => d.CodigoUsuarioIngresoNavigation).WithMany(p => p.ConciliacionBancariumCodigoUsuarioIngresoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioIngreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConciliacionBancaria_CodigoUsuarioIngreso");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.ConciliacionBancariumCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_ConciliacionBancaria_CodigoUsuarioModificacion");
        });

        modelBuilder.Entity<ContenidoAdicional>(entity =>
        {
            entity.HasKey(e => e.CodigoContenidoAdicional).HasName("PK_Contenido_Adicional");

            entity.ToTable("ContenidoAdicional");

            entity.Property(e => e.CodigoContenidoAdicional).ValueGeneratedNever();
            entity.Property(e => e.Contenido).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ContenidoDinamico>(entity =>
        {
            entity.HasKey(e => e.CodigoContenidoDinamico);

            entity.ToTable("ContenidoDinamico");

            entity.Property(e => e.CodigoContenidoDinamico).ValueGeneratedNever();
            entity.Property(e => e.Texto).IsUnicode(false);

            entity.HasOne(d => d.CodigoPaginaNavigation).WithMany(p => p.ContenidoDinamicos)
                .HasForeignKey(d => d.CodigoPagina)
                .HasConstraintName("FK_ContenidoDinamico_Pagina");

            entity.HasOne(d => d.CodigoTipoContenidoDinamicoNavigation).WithMany(p => p.ContenidoDinamicos)
                .HasForeignKey(d => d.CodigoTipoContenidoDinamico)
                .HasConstraintName("FK_ContenidoDinamico_TipoContenidoDinamico");
        });

        modelBuilder.Entity<ContraCargo>(entity =>
        {
            entity.HasKey(e => e.CodigoContraCargo).HasName("PK__ContraCa__C15448FEE1708E1D");

            entity.ToTable("ContraCargo");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaContraCargo).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

            entity.HasOne(d => d.CodigoCobroNavigation).WithMany(p => p.ContraCargos)
                .HasForeignKey(d => d.CodigoCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cobro_ContraCargo_CodigoCobro");

            entity.HasOne(d => d.CodigoEstadoContraCargoNavigation).WithMany(p => p.ContraCargos)
                .HasForeignKey(d => d.CodigoEstadoContraCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EstadoContraCargo_ContraCargo_CodigoEstadoContraCargo");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.ContraCargoCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_ContraCargo_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.ContraCargoCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_Usuario_ContraCargo_CodigoUsuarioModificacion");
        });

        modelBuilder.Entity<CorreoNotificacionGarantium>(entity =>
        {
            entity.HasKey(e => e.CodigoCorreoNotificacionGarantia).HasName("PK_CodigoCorreoNotificacionGarantia");

            entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

            entity.HasOne(d => d.CodigoMovimientoEstadoGarantiaNavigation).WithMany(p => p.CorreoNotificacionGarantia)
                .HasForeignKey(d => d.CodigoMovimientoEstadoGarantia)
                .HasConstraintName("FK_CorreoNotificacionGarantia_CodigoMovimientoEstadoGarantia");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.CorreoNotificacionGarantia)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_CorreoNotificacionGarantia_CodigoUsuario");
        });

        modelBuilder.Entity<CorreoPersonalizado>(entity =>
        {
            entity.HasKey(e => e.CodigoCorreoPersonalizado).HasName("PK__CorreoPe__D516CA38583E832D");

            entity.ToTable("CorreoPersonalizado");

            entity.Property(e => e.CodigoCorreoPersonalizado).ValueGeneratedNever();
            entity.Property(e => e.Activo).HasDefaultValue(false);
            entity.Property(e => e.CorreoEnviado).HasDefaultValue(false);
            entity.Property(e => e.Cuerpo).IsUnicode(false);
            entity.Property(e => e.Encabezado).IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaUsuarioModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Imagen)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.CorreoPersonalizadoCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .HasConstraintName("FK_CorreoPersonalizado_Usuario");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.CorreoPersonalizadoCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_CorreoPersonalizado_CodigoUsuarioModificacion");
        });

        modelBuilder.Entity<CorreoRebotado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CorreoRebotado");

            entity.Property(e => e.Correo)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Error)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<CorridaProceso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CorridaProceso");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Resultado).IsUnicode(false);
        });

        modelBuilder.Entity<CuentaContable>(entity =>
        {
            entity.HasKey(e => e.CodigoCuentaContable).HasName("PK__CuentaCo__D6226C85487070FA");

            entity.ToTable("CuentaContable");

            entity.HasIndex(e => e.CodigoCuentaContable, "IDX_CuentaContable_CodigoCuentaContable");

            entity.HasIndex(e => e.NumeroDeCuenta, "IDX_CuentaContable_NumeroCuenta").IsUnique();

            entity.Property(e => e.Nombre)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDeCuenta)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoClaseCuentaContableNavigation).WithMany(p => p.CuentaContables)
                .HasForeignKey(d => d.CodigoClaseCuentaContable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuentaCon__Codig__4B4CDDA5");

            entity.HasOne(d => d.CodigoClaseDeGastoNavigation).WithMany(p => p.CuentaContables)
                .HasForeignKey(d => d.CodigoClaseDeGasto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuentaCon__Codig__4A58B96C");

            entity.HasOne(d => d.CodigoCuentaContablePadreNavigation).WithMany(p => p.InverseCodigoCuentaContablePadreNavigation)
                .HasForeignKey(d => d.CodigoCuentaContablePadre)
                .HasConstraintName("FKCuentaContable_CodigoCuentaContablePadre");

            entity.HasOne(d => d.CodigoLibroContableNavigation).WithMany(p => p.CuentaContables)
                .HasForeignKey(d => d.CodigoLibroContable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuentaCon__Codig__4C4101DE");
        });

        modelBuilder.Entity<CuentaContableNivel>(entity =>
        {
            entity.HasKey(e => e.CodigoCuentaContableNivel);

            entity.ToTable("CuentaContableNivel");
        });

        modelBuilder.Entity<CuentaContableSaldo>(entity =>
        {
            entity.HasKey(e => new { e.CodigoCuentaContable, e.CodigoCierreContable }).HasName("PK__CuentaCo__C5C3E89795ABA8A8");

            entity.ToTable("CuentaContableSaldo");

            entity.Property(e => e.Debe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Haber).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoCierreContableNavigation).WithMany(p => p.CuentaContableSaldos)
                .HasForeignKey(d => d.CodigoCierreContable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUENTACONTABLESALDO_CIERRECONTABLE");

            entity.HasOne(d => d.CodigoCuentaContableNavigation).WithMany(p => p.CuentaContableSaldos)
                .HasForeignKey(d => d.CodigoCuentaContable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUENTACONTABLESALDO_CUENTACONTABLE");
        });

        modelBuilder.Entity<CuentaDeCompra>(entity =>
        {
            entity.HasKey(e => e.Correo).HasName("PK__CuentaDe__60695A1875035A77");

            entity.ToTable("CuentaDeCompra");

            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContraseñaCorreo).HasMaxLength(50);
            entity.Property(e => e.ContraseñaProveedor).HasMaxLength(50);
            entity.Property(e => e.Perfil)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoEstablecimientoNavigation).WithMany(p => p.CuentaDeCompras)
                .HasForeignKey(d => d.CodigoEstablecimiento)
                .HasConstraintName("FK_CuentaDeCompra_Establecimiento");
        });

        modelBuilder.Entity<Cuentum>(entity =>
        {
            entity.HasKey(e => e.CodigoCuenta).HasName("PK__Cuenta__52DE76051D7B6025");

            entity.HasIndex(e => new { e.CodigoCuenta, e.CodigoCuentaContable }, "IDX_CuentaCodCuentaCodCuentaContable");

            entity.HasIndex(e => e.CodigoCuentaContable, "IDX_Cuenta_CodCuentaContable");

            entity.HasIndex(e => e.CodigoCuenta, "IDX_Cuenta_CodCuenta_CodCuentaContable");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.CodigoCuenta }, "IDX_Cuenta_CodEstablecimientoCodCuenta_CodigoCuentaContableCodigoMoneda");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.CodigoCuenta }, "IDX_Cuenta_CodigoEstablecimientoCodigoCuenta_CodCuentaContable");

            entity.HasIndex(e => e.CodigoBanco, "IDX_Cuenta_codigoBanco");

            entity.HasIndex(e => e.CodigoCuenta, "_dta_index_Cuenta_6_462624691__K1_2_9_23");

            entity.HasIndex(e => e.CodigoCuenta, "_dta_index_Cuenta_6_462624691__K1_9");

            entity.Property(e => e.CodigoCuenta).ValueGeneratedNever();
            entity.Property(e => e.CajaChica).HasDefaultValue(false);
            entity.Property(e => e.Clave).HasMaxLength(256);
            entity.Property(e => e.Clave2).HasMaxLength(256);
            entity.Property(e => e.Clave3).HasMaxLength(256);
            entity.Property(e => e.Codigo).HasMaxLength(256);
            entity.Property(e => e.Codigo2).HasMaxLength(256);
            entity.Property(e => e.Codigo3).HasMaxLength(256);
            entity.Property(e => e.CuentaReembolso).HasDefaultValue(false);
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaSaldoInicialReporte).HasColumnType("smalldatetime");
            entity.Property(e => e.LimiteCredito).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoInicial).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoInicialReporte).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TelefonosRegistrados)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Usuario).HasMaxLength(256);
            entity.Property(e => e.Usuario2).HasMaxLength(256);
            entity.Property(e => e.Usuario3).HasMaxLength(256);

            entity.HasOne(d => d.CodigoBancoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.CodigoBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cuenta_Banco");

            entity.HasOne(d => d.CodigoCuentaContableNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.CodigoCuentaContable)
                .HasConstraintName("FK__Cuenta__CodigoCu__6047FA8B");

            entity.HasOne(d => d.CodigoCuentaPadreNavigation).WithMany(p => p.InverseCodigoCuentaPadreNavigation)
                .HasForeignKey(d => d.CodigoCuentaPadre)
                .HasConstraintName("CodigoCuentaPadre");

            entity.HasOne(d => d.CodigoEstablecimientoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.CodigoEstablecimiento)
                .HasConstraintName("FK_Cuenta_Establecimiento");

            entity.HasOne(d => d.CodigoMonedaNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.CodigoMoneda)
                .HasConstraintName("FK_CUENTA_MONEDA");

            entity.HasOne(d => d.CodigoTipoCuentaNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.CodigoTipoCuenta)
                .HasConstraintName("FK_Cuenta_TipoCuenta");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.CuentaNavigation)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_Cuenta_CodigoUsuario_CodigoUsuarioModificacion");
        });

        modelBuilder.Entity<CuotaTarjetum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdentificadorTransaccionCuota)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PorcentajeAcreditacion).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.PorcentajeComision).HasColumnType("numeric(18, 4)");

            entity.HasOne(d => d.CodigoRedCrediticiaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoRedCrediticia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuotaTarjeta_RedCrediticia");
        });

        modelBuilder.Entity<DefinicionEscaner>(entity =>
        {
            entity.HasKey(e => e.CodigoDefinicionEscaner).HasName("PK__Definici__5093DE76CA186BC4");

            entity.ToTable("DefinicionEscaner");

            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DefinicionEscanerDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DefinicionEscanerDetalle");

            entity.Property(e => e.Fin)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Inicio)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreColumna)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Salida)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoDefinicionEscanerNavigation).WithMany()
                .HasForeignKey(d => d.CodigoDefinicionEscaner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefinicionEscanerDetalle_DefinicionEscaner");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.CodigoDepartamento).HasName("PK__Departam__FB4631036EDE2F88");

            entity.ToTable("Departamento");

            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DepartamentoEmpresa>(entity =>
        {
            entity.HasKey(e => e.CodigoDepartamentoEmpresa).HasName("PK__Departam__31F1952AD4E40B11");

            entity.ToTable("DepartamentoEmpresa");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoDepartamentoPadreNavigation).WithMany(p => p.InverseCodigoDepartamentoPadreNavigation)
                .HasForeignKey(d => d.CodigoDepartamentoPadre)
                .HasConstraintName("FK__Departame__Codig__3DD0D7C9");
        });

        modelBuilder.Entity<Deposito>(entity =>
        {
            entity.HasKey(e => e.CodigoDeposito);

            entity.ToTable("Deposito");

            entity.Property(e => e.CodigoDeposito).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoBancoNavigation).WithMany(p => p.Depositos)
                .HasForeignKey(d => d.CodigoBanco)
                .HasConstraintName("FK_Deposito_Banco");

            entity.HasOne(d => d.CuentaDestinoNavigation).WithMany(p => p.DepositoCuentaDestinoNavigations)
                .HasForeignKey(d => d.CuentaDestino)
                .HasConstraintName("FK_Deposito_CuentaDestino");

            entity.HasOne(d => d.CuentaOrigenNavigation).WithMany(p => p.DepositoCuentaOrigenNavigations)
                .HasForeignKey(d => d.CuentaOrigen)
                .HasConstraintName("FK_Deposito_CuentaOrigen");
        });

        modelBuilder.Entity<DepositoEmpresaEntrega>(entity =>
        {
            entity.HasKey(e => e.CodigoDepositoEmpresaEntrega).HasName("PK__Deposito__BD78F89E75E9DE19");

            entity.ToTable("DepositoEmpresaEntrega");

            entity.Property(e => e.FechaDeposito).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaUsuarioModificacion)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.MontoDepositado).HasColumnType("decimal(11, 2)");
            entity.Property(e => e.NoBoleta)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Urlimagen)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URLImagen");

            entity.HasOne(d => d.CodigoCuentaNavigation).WithMany(p => p.DepositoEmpresaEntregas)
                .HasForeignKey(d => d.CodigoCuenta)
                .HasConstraintName("FK_DepositoEmpresaEntrega_CodigoCuenta");

            entity.HasOne(d => d.CodigoEstadoDepositoEmpresaEntregaNavigation).WithMany(p => p.DepositoEmpresaEntregas)
                .HasForeignKey(d => d.CodigoEstadoDepositoEmpresaEntrega)
                .HasConstraintName("FK_DepositoEmpresaEntrega_CodigoEstadoDepositoEmpresaEntrega");

            entity.HasOne(d => d.CodigoTransaccionNavigation).WithMany(p => p.DepositoEmpresaEntregaCodigoTransaccionNavigations)
                .HasForeignKey(d => d.CodigoTransaccion)
                .HasConstraintName("FK_DepositoEmpresaEntrega_CodigoTransaccion");

            entity.HasOne(d => d.CodigoTransaccionAnulacionNavigation).WithMany(p => p.DepositoEmpresaEntregaCodigoTransaccionAnulacionNavigations)
                .HasForeignKey(d => d.CodigoTransaccionAnulacion)
                .HasConstraintName("FK_DepositoEmpresaEntrega_CodigoTransaccion_CodigoTransaccionAnulacion");

            entity.HasOne(d => d.CodigoUsuarioDepositoNavigation).WithMany(p => p.DepositoEmpresaEntregaCodigoUsuarioDepositoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioDeposito)
                .HasConstraintName("FK_DepositoEmpresaEntrega_CodigoUsuario_CodigoUsuarioDeposito");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.DepositoEmpresaEntregaCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_DepositoEmpresaEntrega_CodigoUsuario");
        });

        modelBuilder.Entity<DetalleConciliacionBancarium>(entity =>
        {
            entity.HasKey(e => e.CodigoDetalleConciliacionBancaria).HasName("PK_CodigoDetalleConciliacionBancaria");

            entity.Property(e => e.Credito)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Debito)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.FechaEstadoCuenta).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.Referencia)
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoConciliacionBancariaNavigation).WithMany(p => p.DetalleConciliacionBancaria)
                .HasForeignKey(d => d.CodigoConciliacionBancaria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleConciliacionBancaria_CodigoConciliacionBancaria");

            entity.HasOne(d => d.CodigoTransaccionNavigation).WithMany(p => p.DetalleConciliacionBancaria)
                .HasForeignKey(d => d.CodigoTransaccion)
                .HasConstraintName("FK_DetalleConciliacionBancaria_CodigoTransaccion");
        });

        modelBuilder.Entity<DetalleVentaServicio>(entity =>
        {
            entity.HasKey(e => new { e.CodigoVenta, e.CodigoServicio }).HasName("DetalleVentaServicio_PK");

            entity.ToTable("DetalleVentaServicio");

            entity.HasIndex(e => new { e.CodigoVenta, e.CodigoServicio }, "DetalleVentaServicio_CodigoVentaCodigoServicio").HasFillFactor(100);

            entity.HasIndex(e => e.CodigoServicio, "IDX_DetalleVentaServicio_CodigoServicio_CodigoVenta_Monto").HasFillFactor(100);

            entity.HasIndex(e => e.CodigoVenta, "IDX_DetalleVentaServicio_CodigoVenta_CodigoServicio_Monto").HasFillFactor(100);

            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoServicioNavigation).WithMany(p => p.DetalleVentaServicios)
                .HasForeignKey(d => d.CodigoServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleVentaServicio_CodigoServicio");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.DetalleVentaServicios)
                .HasForeignKey(d => d.CodigoVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleVentaServicio_CodigoVenta");
        });

        modelBuilder.Entity<DireccionImportador>(entity =>
        {
            entity.HasKey(e => e.CodigoDireccionImportador).HasName("PK_DireccionImportador_CodigoDireccionImportador");

            entity.ToTable("DireccionImportador");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.DireccionImportador1)
                .HasMaxLength(510)
                .HasColumnName("DireccionImportador");
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoImportadorNavigation).WithMany(p => p.DireccionImportadors)
                .HasForeignKey(d => d.CodigoImportador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DireccionImportador_CodigoImportador");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.DireccionImportadorCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DireccionImportador_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.DireccionImportadorCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_DireccionImportador_CodigoUsuarioModificacion");
        });

        modelBuilder.Entity<DireccionIpcliente>(entity =>
        {
            entity.HasKey(e => e.CodigoDireccionIpcliente).HasName("PK_CodigoDireccionIPCliente");

            entity.ToTable("DireccionIPCliente");

            entity.Property(e => e.CodigoDireccionIpcliente).HasColumnName("CodigoDireccionIPCliente");
            entity.Property(e => e.DireccionIpcliente1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DireccionIPCliente");
            entity.Property(e => e.FechaCapturaIp)
                .HasColumnType("smalldatetime")
                .HasColumnName("FechaCapturaIP");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.DireccionIpclientes)
                .HasForeignKey(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DireccionIPCliente_Factura");
        });

        modelBuilder.Entity<DirectorioContacto>(entity =>
        {
            entity.HasKey(e => e.CodigoDirectorioContacto);

            entity.ToTable("DirectorioContacto");

            entity.Property(e => e.Correo).HasMaxLength(50);
            entity.Property(e => e.Departamento).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Puesto).HasMaxLength(50);
            entity.Property(e => e.Telefono1).HasMaxLength(25);
            entity.Property(e => e.Telefono2).HasMaxLength(25);

            entity.HasOne(d => d.CodigoDirectorioEmpresaNavigation).WithMany(p => p.DirectorioContactos)
                .HasForeignKey(d => d.CodigoDirectorioEmpresa)
                .HasConstraintName("FK_DirectorioContacto_DirectorioEmpresa");
        });

        modelBuilder.Entity<DirectorioEmpresa>(entity =>
        {
            entity.HasKey(e => e.CodigoDirectorioEmpresa);

            entity.ToTable("DirectorioEmpresa");

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Fax).HasMaxLength(25);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(25);
        });

        modelBuilder.Entity<Dispositivo>(entity =>
        {
            entity.HasKey(e => e.CodigoDispositivo).HasName("PK__Disposit__54B5C46AF4A38642");

            entity.ToTable("Dispositivo");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Marca)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.Serie)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoTipoDispositivoNavigation).WithMany(p => p.Dispositivos)
                .HasForeignKey(d => d.CodigoTipoDispositivo)
                .HasConstraintName("FK__Dispositi__Codig__7BB60446");

            entity.HasOne(d => d.CodigoUsuarioAsignadoNavigation).WithMany(p => p.DispositivoCodigoUsuarioAsignadoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioAsignado)
                .HasConstraintName("FK__Dispositi__Codig__79CDBBD4");

            entity.HasOne(d => d.CodigoUsuarioBajaNavigation).WithMany(p => p.DispositivoCodigoUsuarioBajaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioBaja)
                .HasConstraintName("FK_Dispositivo_CodigoUsuarioBaja");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.DispositivoCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK__Dispositi__Codig__7AC1E00D");
        });

        modelBuilder.Entity<ElementoRobot>(entity =>
        {
            entity.HasKey(e => e.CodigoElementoRobot).HasName("PK__Elemento__3C43202E7C6F7215");

            entity.ToTable("ElementoRobot");

            entity.Property(e => e.Campo)
                .HasMaxLength(700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Embarque>(entity =>
        {
            entity.HasKey(e => e.CodigoEmbarque).HasName("PK__Embarque__DE043E710A688BB1");

            entity.ToTable("Embarque");

            entity.HasIndex(e => new { e.CodigoEmbarque, e.FechaVerificacion }, "IDX_Embarque_CodigoEmbarqueFechaVerificacion");

            entity.HasIndex(e => e.FechaVerificacion, "IDX_Embarque_FechaVerificacion");

            entity.Property(e => e.CodigoEmbarque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CargarArchivo).HasColumnType("text");
            entity.Property(e => e.FechaPedido).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRecbido).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeVendido).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Empaque>(entity =>
        {
            entity.HasKey(e => e.CodigoEmpaque).HasName("PK_Empaque_CodigoEmpaque");

            entity.ToTable("Empaque");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Foto)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasMany(d => d.CodigoEmpresaDeEntregas).WithMany(p => p.CodigoEmpaques)
                .UsingEntity<Dictionary<string, object>>(
                    "EmpaqueEmpresaDeEntrega",
                    r => r.HasOne<EmpresaDeEntrega>().WithMany()
                        .HasForeignKey("CodigoEmpresaDeEntrega")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmpaqueEmpresaDeEntrega_CodigoEmpreasDeEntrega"),
                    l => l.HasOne<Empaque>().WithMany()
                        .HasForeignKey("CodigoEmpaque")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmpaqueEmpresaDeEntrega_CodigoEmpaque"),
                    j =>
                    {
                        j.HasKey("CodigoEmpaque", "CodigoEmpresaDeEntrega");
                        j.ToTable("EmpaqueEmpresaDeEntrega");
                    });
        });

        modelBuilder.Entity<EmpaqueDeRegalo>(entity =>
        {
            entity.HasKey(e => e.CodigoEmpaqueDeRegalo).HasName("PK__EmpaqueD__AC13C0EF85D2E161");

            entity.ToTable("EmpaqueDeRegalo");

            entity.Property(e => e.De)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Foto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Para)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.CodigoEmpresa).HasName("PK__Empresa__2A36A285C7046DEB");

            entity.ToTable("Empresa");

            entity.Property(e => e.AfiliacionIva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AfiliacionIVA");
            entity.Property(e => e.CorreoEmisor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FechaVigencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.NombreEmisor)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Token).IsUnicode(false);

            entity.HasOne(d => d.CodigoMunicipioNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.CodigoMunicipio)
                .HasConstraintName("FK_Empresa_Municipio");
        });

        modelBuilder.Entity<EmpresaDeEntrega>(entity =>
        {
            entity.HasKey(e => e.CodigoEmpresaDeEntrega).HasName("PK_EmpresaDeEntrega_CodigoEmpresaDeEntrega");

            entity.ToTable("EmpresaDeEntrega");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.AplicaCod)
                .HasDefaultValue(false)
                .HasColumnName("AplicaCOD");
            entity.Property(e => e.AplicaManifiesto).HasDefaultValue(false);
            entity.Property(e => e.CorreosAcreditacion)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.CorreosApi)
                .HasMaxLength(150)
                .HasColumnName("CorreosAPI");
            entity.Property(e => e.EncabezadoCorreoAcreditacion)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.GenerarGuiaGd)
                .HasDefaultValue(false)
                .HasColumnName("GenerarGuiaGD");
            entity.Property(e => e.ModificaDireccion).HasDefaultValue(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Prefijo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TituloCorreoAcreditacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UrlRastreoGuia)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoCuentaContablePorCobrarNavigation).WithMany(p => p.EmpresaDeEntregas)
                .HasForeignKey(d => d.CodigoCuentaContablePorCobrar)
                .HasConstraintName("FK_EmpresaDeEntrega_CodigoCuentaContablePorCobrar");

            entity.HasOne(d => d.CodigoCuentaDepositoNavigation).WithMany(p => p.EmpresaDeEntregas)
                .HasForeignKey(d => d.CodigoCuentaDeposito)
                .HasConstraintName("FK_EmpresaDeEntrega_CodigoCuentaDeposito");
        });

        modelBuilder.Entity<EmpresaEntregaBitacora>(entity =>
        {
            entity.HasKey(e => e.CodigoEmpresaEntregaBitacora).HasName("PK_CodigoBitacora");

            entity.ToTable("EmpresaEntregaBitacora");

            entity.HasIndex(e => new { e.CodigoUsuario, e.CodigoEstadoEntregaFactura, e.CodigoFactura, e.CodigoDeRastreo }, "IDX_EmpresaEntregaBitacora_CodUsuarioCodEstadoEntregaFacturaCodigoFacturaCodigoDeRastreo_CodEmpresaEntregaBitacoraFecha");

            entity.HasIndex(e => e.CodigoDeRastreo, "IDX_EmpresaEntregaBitacora_CodigoDeRastreo_CodigoEstadoEntregaFacturaFecha");

            entity.Property(e => e.CodigoDeRastreo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.CodigoEstadoEntregaFacturaNavigation).WithMany(p => p.EmpresaEntregaBitacoras)
                .HasForeignKey(d => d.CodigoEstadoEntregaFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpresaEntregaBitacora_EstadoEntregaFactura");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.EmpresaEntregaBitacoras)
                .HasForeignKey(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpresaEntregaBitacora_Factura");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.EmpresaEntregaBitacoras)
                .HasForeignKey(d => d.CodigoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpresaEntregaBitacora_Usuario");
        });

        modelBuilder.Entity<Entradum>(entity =>
        {
            entity.HasKey(e => e.CodigoEntrada);

            entity.HasIndex(e => new { e.CodigoUsuario, e.EntradaSalida }, "IDX_EntradaCodigoUsuarioEntradaSAlida_Fecha");

            entity.HasIndex(e => new { e.CodigoUsuario, e.Fecha }, "IDX_Entrada_CodigoUsuarioFecha_EntradaSalidaIP");

            entity.HasIndex(e => e.Fecha, "IDX_Entrada_Fecha_CodigoUsuarioEntradaSalidaIP");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.HoraEntradaUsuario).HasPrecision(0);
            entity.Property(e => e.HoraSalidaUsuario).HasPrecision(0);
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasColumnName("IP");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_Entrada_Usuario");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.CodigoError);

            entity.ToTable("Error");

            entity.Property(e => e.Archivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoTipoErrorNavigation).WithMany(p => p.Errors)
                .HasForeignKey(d => d.CodigoTipoError)
                .HasConstraintName("FK_Error_TipoError");
        });

        modelBuilder.Entity<ErrorApi>(entity =>
        {
            entity.HasKey(e => e.CodigoErrorApi).HasName("PK__ErrorApi__D1F270495DA068A2");

            entity.ToTable("ErrorApi");

            entity.Property(e => e.CodigoErrorApi)
                .HasMaxLength(38)
                .IsUnicode(false);
            entity.Property(e => e.CodigoTipoError).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.CodigoUsuario).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Contenido)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Stacktrace)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.CodigoTipoErrorNavigation).WithMany(p => p.ErrorApis)
                .HasForeignKey(d => d.CodigoTipoError)
                .HasConstraintName("FK_TipoError_CodigoTipoError");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.ErrorApis)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_Usuario_CodigoUsuario");
        });

        modelBuilder.Entity<EscenarioContable>(entity =>
        {
            entity.HasKey(e => e.CodigoEscenarioContable).HasName("PK__Escenari__B0960811631A4595");

            entity.ToTable("EscenarioContable");

            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.CodigoTipoEscenarioContableNavigation).WithMany(p => p.EscenarioContables)
                .HasForeignKey(d => d.CodigoTipoEscenarioContable)
                .HasConstraintName("FK__Escenario__Codig__65028E07");
        });

        modelBuilder.Entity<EscenarioContableCuentaContable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EscenarioContableCuentaContable");

            entity.HasIndex(e => e.CodigoEscenarioContable, "IDX_EscenarioContableCuentaContable_CodigoEscenarioContable").IsClustered();

            entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 14)");

            entity.HasOne(d => d.CodigoCuentaContableNavigation).WithMany()
                .HasForeignKey(d => d.CodigoCuentaContable)
                .HasConstraintName("FK__Escenario__Codig__716864EC");

            entity.HasOne(d => d.CodigoEscenarioContableNavigation).WithMany()
                .HasForeignKey(d => d.CodigoEscenarioContable)
                .HasConstraintName("FK__Escenario__Codig__707440B3");
        });

        modelBuilder.Entity<Establecimiento>(entity =>
        {
            entity.HasKey(e => e.CodigoEstablecimiento).HasName("PK__Establec__C4D66D322739D489");

            entity.ToTable("Establecimiento");

            entity.HasIndex(e => e.Url, "IDX_establecimiento_Url_CodEstablecimientoNombre");

            entity.Property(e => e.CodigoEstablecimiento).ValueGeneratedNever();
            entity.Property(e => e.CargaArchivo).HasDefaultValue(false);
            entity.Property(e => e.ClienteId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("clienteId");
            entity.Property(e => e.CodigoCasillero)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ConsignatarioId)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Contacto1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Contacto2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Correo1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Correo2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CostoFijo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HabilitaPromocion).HasDefaultValue(true);
            entity.Property(e => e.Horario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Logo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModificaAsin).HasDefaultValue(false);
            entity.Property(e => e.Nit)
                .HasMaxLength(12)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreImportacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesEstablecimiento)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PorcentajeComision).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeComisionPedido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PromocionSinExistencia).HasDefaultValue(false);
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoAlterno)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoClienteNavigation).WithMany(p => p.Establecimientos)
                .HasForeignKey(d => d.CodigoCliente)
                .HasConstraintName("FK_Establecimiento_Cliente");

            entity.HasOne(d => d.CodigoCuentaCompraNavigation).WithMany(p => p.EstablecimientoCodigoCuentaCompraNavigations)
                .HasForeignKey(d => d.CodigoCuentaCompra)
                .HasConstraintName("FK_EstablecimientoCompra_Cuenta");

            entity.HasOne(d => d.CodigoCuentaCxPNavigation).WithMany(p => p.EstablecimientoCodigoCuentaCxPNavigations)
                .HasForeignKey(d => d.CodigoCuentaCxP)
                .HasConstraintName("FK_EstablecimientoCxP_Cuenta");

            entity.HasOne(d => d.CodigoCuentaInventarioNavigation).WithMany(p => p.EstablecimientoCodigoCuentaInventarioNavigations)
                .HasForeignKey(d => d.CodigoCuentaInventario)
                .HasConstraintName("FK_EstablecimientoInventario_Cuenta");

            entity.HasOne(d => d.CuentaPorPagarNavigation).WithMany(p => p.EstablecimientoCuentaPorPagarNavigations)
                .HasForeignKey(d => d.CuentaPorPagar)
                .HasConstraintName("FK__Estableci__Cuent__056049E9");
        });

        modelBuilder.Entity<EstadoAnuncio>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoAnuncio).HasName("PK__EstadoAn__73EA9C771CD8A25C");

            entity.ToTable("EstadoAnuncio");

            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoAnuncioAprobacion>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoAnuncioAprobacion).HasName("PK__EstadoAn__627CD62D82F7A652");

            entity.ToTable("EstadoAnuncioAprobacion");

            entity.Property(e => e.CodigoEstadoAnuncioAprobacion).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoAplicacionPlaza>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoAplicacionPlaza).HasName("PK__EstadoAp__AEAD00C4625F1588");

            entity.ToTable("EstadoAplicacionPlaza");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoCampaniaExterna>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoCampaniaExterna).HasName("PK__EstadoCa__FC5BED563C631BC4");

            entity.ToTable("EstadoCampaniaExterna");

            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoCivil>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoCivil).HasName("PK__EstadoCi__889DE1B215653996");

            entity.ToTable("EstadoCivil");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoContraCargo>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoContraCargo).HasName("PK__EstadoCo__1055FBB69EB3B1A6");

            entity.ToTable("EstadoContraCargo");

            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoDeAnuncio>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoDeAnuncio).HasName("PK__EstadoDe__A1FE0B2D421E5970");

            entity.ToTable("EstadoDeAnuncio");

            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoDeVentum>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoDeVenta).HasName("PK__EstadoDe__C31DACEDE143E3B3");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoDepositoEmpresaEntrega>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoDepositoEmpresaEntrega);

            entity.ToTable("EstadoDepositoEmpresaEntrega");

            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoEntrega>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoEntrega);

            entity.ToTable("EstadoEntrega");

            entity.Property(e => e.Etapa)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoEntregaEmpresaDeEntrega>(entity =>
        {
            entity.HasKey(e => new { e.CodigoEstadoEntregaEmpresaDeEntrega, e.CodigoEmpresaDeEntrega });

            entity.ToTable("EstadoEntregaEmpresaDeEntrega");

            entity.Property(e => e.CodigoEstadoEntregaEmpresaDeEntrega)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoEmpresaDeEntregaNavigation).WithMany(p => p.EstadoEntregaEmpresaDeEntregas)
                .HasForeignKey(d => d.CodigoEmpresaDeEntrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EstadoEntregaEmpresaDeEntrega_CodigoEmpresaDeEntrega");

            entity.HasOne(d => d.CodigoEstadoEntregaFacturaNavigation).WithMany(p => p.EstadoEntregaEmpresaDeEntregas)
                .HasForeignKey(d => d.CodigoEstadoEntregaFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EstadoEntregaEmpresaDeEntrega_CodigoEstadoEntregaFactura");
        });

        modelBuilder.Entity<EstadoEntregaFactura>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoEntregaFactura);

            entity.ToTable("EstadoEntregaFactura");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<EstadoFactura>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoFactura).HasName("PK__EstadoFa__57A5A2E402C769E9");

            entity.ToTable("EstadoFactura");

            entity.Property(e => e.CodigoEstadoFactura).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoGarantium>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoGarantia).HasName("PK__EstadoGa__1D7C6EE1C2F6E09B");

            entity.Property(e => e.EstadoFinal).HasDefaultValue(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoGuiaReclamadum>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoGuiaReclamada).HasName("PK__EstadoGu__0B4FADC9634D23B3");

            entity.Property(e => e.Nombre)
                .HasMaxLength(700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoNotaContable>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoNotaContable).HasName("PK_EstadoNotaContable_CodigoEstadoNotaContable");

            entity.ToTable("EstadoNotaContable");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prefijo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EstadoPaquete>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoPaquete).HasName("PK__EstadoPa__4A726056025D5595");

            entity.ToTable("EstadoPaquete");

            entity.Property(e => e.CodigoEstadoPaquete).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoPaqueteReclamado>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoPaqueteReclamado).HasName("PK__EstadoPa__6DDB67E57253CC68");

            entity.ToTable("EstadoPaqueteReclamado");

            entity.Property(e => e.Nombre)
                .HasMaxLength(700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoPedido>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoPedido);

            entity.ToTable("EstadoPedido");

            entity.Property(e => e.CodigoEstadoPedido).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<EstadoPreguntum>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoPregunta).HasName("PK__EstadoPr__5A5AD1C863C87759");

            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoProducto>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoProducto).HasName("pk_EstadoProducto");

            entity.ToTable("EstadoProducto");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoPromocion>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoPromocion).HasName("PK__EstadoPr__E45F9161E6FC1EA9");

            entity.ToTable("EstadoPromocion");

            entity.Property(e => e.CodigoEstadoPromocion).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoRevision>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoRevision).HasName("PK__EstadoRe__ABFBA5FE725BF7F6");

            entity.ToTable("EstadoRevision");

            entity.Property(e => e.CodigoEstadoRevision).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoTransferencium>(entity =>
        {
            entity.HasKey(e => e.CodigoEstadoTransferencia).HasName("PK__EstadoAC__BBDF80CB24C4FCF2");

            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.CodigoFactura).HasName("PK__Factura__EAED4A697D0E9093");

            entity.ToTable("Factura");

            entity.HasIndex(e => new { e.DatosDeReembolsoPendientes, e.CodigoFactura }, "Factura_DatosDeReembolsoPendientesCodigoFactura_SerieDeFacturaNumeroDeFacturaCodigoEmpresaFechaTotalTotalSinComisiones");

            entity.HasIndex(e => new { e.SerieDeFactura, e.CodigoEstadoFactura, e.FechaGuia, e.CodigoFactura, e.TotalSinComisiones, e.TotalFactura }, "Factura_SerieDeFacturaCodigoEstadoFacturaFechaGuiaCodigoFacturaTotalSinComisionesTotalFactura");

            entity.HasIndex(e => e.CodigoPolizaMercaderia, "IDX_CodigoPolizaMercaderia");

            entity.HasIndex(e => e.CodigoPolizaServicio, "IDX_CodigoPolizaServicio");

            entity.HasIndex(e => e.CodigoResolucion, "IDX_CodigoResolucion_FacturaReferencia");

            entity.HasIndex(e => e.CodigoResolucion, "IDX_CodigoResolucion_NumeroFactura");

            entity.HasIndex(e => new { e.SerieDeFactura, e.EsFacturaElectronica }, "IDX_EsFacturaElectronicaYSerieDeFactura_NumeroDeFactura");

            entity.HasIndex(e => new { e.Cae, e.FechaEntrega, e.CodigoEmpresaDeEntrega, e.SerieDeFactura, e.FechaGuia, e.CodigoDeRastreo }, "IDX_Factura_CaeFechaEntregaCodigoEmpresaDeEntregaSerieDeFacturaFechaGuiaCodigoDeRastreo");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.CodigoDeRastreo, e.FechaVencimiento }, "IDX_Factura_CodEstFacCodDeRastreoFecVenc_CodigoEstEntregaFacCodEmpresaDeEntrega");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.CodigoDeRastreo, e.FechaVencimiento }, "IDX_Factura_CodEstFacCodRastreoFecVencimiento_NombreTotalFac");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.SerieDeFacturaReferencia, e.SerieDeFactura }, "IDX_Factura_CodEstFacSerRefSerFac_NumeroNitNombreFecha");

            entity.HasIndex(e => e.CodigoEstadoEntregaFactura, "IDX_Factura_CodEstadoEntFac_FecRegFecEntr");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.CodigoDeRastreo, e.FechaVencimiento }, "IDX_Factura_CodEstadoFacturaCodDeRastreoFechaVencimiento_NombreTotalFacturaCodEstadoEntregaFacturaCodEmpresaDeEntrega");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.Fecha, e.CodigoFactura }, "IDX_Factura_CodEstadoFacturaFehcaCodFactura_serieDeFacturaNumeroDeFactura");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.SerieDeFactura, e.Fecha }, "IDX_Factura_CodEstadoFacturaSerieDeFacturaFechaCodFactura");

            entity.HasIndex(e => new { e.CodigoFactura, e.SerieDeFactura, e.Fecha }, "IDX_Factura_CodFacturaSerieDeFacturaFaFecha");

            entity.HasIndex(e => e.CodigoCliente, "IDX_Factura_CodigoCliente");

            entity.HasIndex(e => e.CodigoDeRastreo, "IDX_Factura_CodigoDeRastreo_CodigoEstadoEntregaFacturaCodigoEmpresaDeEntrega");

            entity.HasIndex(e => new { e.CodigoEmpresa, e.Cae, e.EsFacturaElectronica, e.SerieDeFactura, e.CodigoEstadoFactura }, "IDX_Factura_CodigoEmpresaCaeEsFacturaElectronicaSerieDeFacturaCodigoEstadoFactura");

            entity.HasIndex(e => e.CodigoEmpresaDeEntrega, "IDX_Factura_CodigoEmpresaDeEntrega");

            entity.HasIndex(e => new { e.CodigoEmpresaDeEntrega, e.CodigoDeRastreo }, "IDX_Factura_CodigoEmpresaDeEntregaCodigoDeRastreo_FechaFechaGuiaCodigoEstadoEntregaFactura");

            entity.HasIndex(e => new { e.CodigoEmpresa, e.FechaEnvioFactura, e.CodigoEmpresaDeEntrega, e.SerieDeFactura, e.CodigoEstadoFactura, e.CodigoDeRastreo, e.Cae }, "IDX_Factura_CodigoEmpresaFechaEnvioFacturaCodigoEmpresaDeEntregaSerieDeFacturaCodigoEstadoFActuraCodigoDeRastreoCAE_SinFactura");

            entity.HasIndex(e => e.CodigoEstadoEntregaFactura, "IDX_Factura_CodigoEstadoEntregaFactura");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.CodigoDeRastreo, e.FechaVencimiento }, "IDX_Factura_CodigoEstadoFActuraCodigoDeRastreoFeVencimiento");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.CodigoDeRastreo, e.CodigoEstadoEntregaFactura, e.CodigoEmpresaDeEntrega }, "IDX_Factura_CodigoEstadoFacturaCodigoDeRastreoCodigoEstadoEntregaFacturaCodigoEmpresaDeEntrega_FechaGeneracionGuia");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.CodigoEstadoEntregaFactura, e.FechaGuia, e.CodigoDeRastreo }, "IDX_Factura_CodigoEstadoFacturaCodigoEstadoEntregaFacturaFechaGuiaCodigoDeRastreo");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.SerieDeFactura, e.Fecha, e.Cae }, "IDX_Factura_CodigoEstadoFacturaSerieDeFacturaFechaCAE");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.SerieDeFactura, e.Fecha, e.Cae }, "IDX_Factura_CodigoEstadoFacturaSerieDeFacturaFechaCAE_CodigoFormaDeEnvioEnvio");

            entity.HasIndex(e => new { e.CodigoEstadoFactura, e.SinFactura, e.CodigoFactura }, "IDX_Factura_CodigoEstadoFacturaSinFacturaCodigoFactura_CodigoEmpresaTotalSinComisionesTotalFactura");

            entity.HasIndex(e => e.CodigoFacturaAnulada, "IDX_Factura_CodigoFacturaAnulada");

            entity.HasIndex(e => e.CodigoFactura, "IDX_Factura_CodigoFactura_SerieDFacturaNumeroDeFacturaCodEmpreaFechaTotalTOtalsinComisFechaRegistro");

            entity.HasIndex(e => e.CodigoFormaDeEnvio, "IDX_Factura_CodigoFormaDeEnvio");

            entity.HasIndex(e => e.CodigoFactura, "IDX_Factura_Codigofactura_SerieDeFactura");

            entity.HasIndex(e => e.Correo, "IDX_Factura_Correo");

            entity.HasIndex(e => e.Fecha, "IDX_Factura_Fecha");

            entity.HasIndex(e => new { e.FechaEntrega, e.CodigoEstadoEntregaFactura }, "IDX_Factura_FechaEntregaCodigoEstadoEntregaFactura");

            entity.HasIndex(e => e.FechaGeneracionGuia, "IDX_Factura_FechaGeneracionGuia_CodigoUsuarioGuia");

            entity.HasIndex(e => e.FechaGuia, "IDX_Factura_FechaGuia").IsDescending();

            entity.HasIndex(e => new { e.FechaGuia, e.CodigoFactura, e.CodigoUsuarioGuia }, "IDX_Factura_FechaGuiaCodigoFacturaCodigoUsuarioGuia");

            entity.HasIndex(e => e.Fecha, "IDX_Factura_Fecha_SerieDeFacturaNumeroDeFacturaTotalTotalFactura");

            entity.HasIndex(e => new { e.SerieDeFactura, e.CodigoEstadoFactura, e.Fecha }, "IDX_Factura_SerieDeFactCodEstadoFacturaFecha_NumFactNitNombreTotalImpFactSerieFactRefNumFactRef");

            entity.HasIndex(e => new { e.SerieDeFactura, e.CodigoEmpresa, e.Cae, e.EsFacturaElectronica, e.CodigoEstadoFactura, e.CodigoDeRastreo }, "IDX_Factura_SerieDeFacturaCodigoempresaCAEEsFacturaElectronicaCodigoEstadoFActuraCodigoDeRastreo");

            entity.HasIndex(e => new { e.SerieDeFactura, e.SinFactura }, "IDX_Factura_SerieDeFacturaSinFactura");

            entity.HasIndex(e => new { e.SerieDeFactura, e.SinFactura, e.TotalSinComisiones }, "IDX_Factura_SerieDeFacturaSinFacturaTotalSinComisiones");

            entity.HasIndex(e => new { e.SerieDeFactura, e.SinFactura, e.TotalSinComisiones }, "IDX_Factura_SerieDeFacturaSinFacturaTotalSinComisiones_TotalFacturaCodigoDeRastreoEsFacturaElectronica");

            entity.HasIndex(e => new { e.SerieDeFactura, e.TotalSinComisiones }, "IDX_Factura_SerieDeFacturaTotalSinComisiones_TotalFacturaCodigoDeRastreoEsFacturaElectronica");

            entity.HasIndex(e => new { e.SinFactura, e.CodigoFactura, e.SerieDeFactura, e.CodigoEstadoFactura }, "IDX_Factura_SinFactura_CodigoFactura_SerieDeFactura_CodigoEstadoFactura");

            entity.HasIndex(e => e.TotalFactura, "IDX_Factura_TotalFactura");

            entity.HasIndex(e => e.NumeroDeFactura, "IDX_NumeroFactura_Fecha");

            entity.HasIndex(e => new { e.SerieDeFactura, e.NumeroDeFactura }, "IDX_Serie_Y_NumeroDeFactura");

            entity.HasIndex(e => new { e.CodigoFactura, e.Cae, e.GuidFirma, e.GuidRegistrarDocumento, e.GuidFirmaResponse, e.GuidAnularResponse, e.GuidAnular }, "_dta_index_Factura_6_2066106401__K1_K26_K62_K63_K65_K67_K64");

            entity.HasIndex(e => new { e.FechaVencimiento, e.CodigoEstadoFactura, e.CodigoDeRastreo, e.CodigoEmpresaDeEntrega, e.CodigoEstadoEntregaFactura, e.CodigoFactura }, "_dta_index_Factura_6_2066106401__K61D_K8_K24_K42_K39_K1_5_17").IsDescending(true, false, false, false, false, false);

            entity.Property(e => e.CodigoFactura).ValueGeneratedNever();
            entity.Property(e => e.Cae)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CAE");
            entity.Property(e => e.CaedeNotaCredito)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CAEDeNotaCredito");
            entity.Property(e => e.CodigoDeRastreo)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.CodigoTipoDocumento).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.ConceptoDeNotaCredito)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Cui)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CUI");
            entity.Property(e => e.DatosDeReembolsoPendientes).HasDefaultValue(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Envio).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaAnulacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDatosReembolso).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDeNotaCredito).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEnvioCliente).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEnvioFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaGeneracionGuia).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaGuia).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificaDireccion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaPago).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRecepcionEmpresaDeEntrega).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");
            entity.Property(e => e.GuidAnular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidAnularResponse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidFirma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidFirmaResponse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidRegistrarDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidRegistrarDocumentoResponse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MontoServicioEnEfectivo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Nit)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreRecibido)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDeFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDeFacturaReferencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDeNotaCredito).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesDespacho)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesEmpresaEntrega)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesGuia)
                .HasMaxLength(182)
                .IsUnicode(false);
            entity.Property(e => e.PagarEnvio).HasDefaultValue(false);
            entity.Property(e => e.PorcentajeRegimenFactura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PruebaEntrega)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Reembolso)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.SerieDeFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SerieDeFacturaReferencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SerieDeNotaCredito)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SinFactura)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Telefonos)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalImpresionFactura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPendiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSinComisiones).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoClienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoCliente)
                .HasConstraintName("FK_Factura_Cliente");

            entity.HasOne(d => d.CodigoDepartamentoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoDepartamento)
                .HasConstraintName("FK_DepartamentoFactura");

            entity.HasOne(d => d.CodigoEmpresaNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoEmpresa)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Factura_Empresa");

            entity.HasOne(d => d.CodigoEmpresaDeEntregaNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoEmpresaDeEntrega)
                .HasConstraintName("FK_Factura_CodigoEmpresaDeEntrega");

            entity.HasOne(d => d.CodigoEstadoEntregaFacturaNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoEstadoEntregaFactura)
                .HasConstraintName("FK_Factura_EstadoEntregaFactura");

            entity.HasOne(d => d.CodigoEstadoFacturaNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoEstadoFactura)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Factura_EstadoFactura");

            entity.HasOne(d => d.CodigoFacturaAnuladaNavigation).WithMany(p => p.InverseCodigoFacturaAnuladaNavigation)
                .HasForeignKey(d => d.CodigoFacturaAnulada)
                .HasConstraintName("FK_Factura_CodigoFacturaAnulada");

            entity.HasOne(d => d.CodigoFormaDeEnvioNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoFormaDeEnvio)
                .HasConstraintName("FK_Factura_CodigoFormaDeEnvio");

            entity.HasOne(d => d.CodigoMembresiaNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoMembresia)
                .HasConstraintName("FK_Factura_Memebresia_CodigoMembresia");

            entity.HasOne(d => d.CodigoMunicipioNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoMunicipio)
                .HasConstraintName("FK_MunicipioFactura");

            entity.HasOne(d => d.CodigoPolizaMercaderiaNavigation).WithMany(p => p.FacturaCodigoPolizaMercaderiaNavigations)
                .HasForeignKey(d => d.CodigoPolizaMercaderia)
                .HasConstraintName("FK__Factura__CodigoP__6C114EB5");

            entity.HasOne(d => d.CodigoPolizaServicioNavigation).WithMany(p => p.FacturaCodigoPolizaServicioNavigations)
                .HasForeignKey(d => d.CodigoPolizaServicio)
                .HasConstraintName("FK__Factura__CodigoP__6D0572EE");

            entity.HasOne(d => d.CodigoPorcentajeRetencionExencionNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoPorcentajeRetencionExencion)
                .HasConstraintName("FK_Factura_CodigoPorcentageRetencionExencion");

            entity.HasOne(d => d.CodigoTipoDocumentoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.CodigoTipoDocumento)
                .HasConstraintName("FK_Factura_CodigoTipoDocumento");

            entity.HasOne(d => d.CodigoUsuarioAnulacionNavigation).WithMany(p => p.FacturaCodigoUsuarioAnulacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioAnulacion)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Factura_Usuario");

            entity.HasOne(d => d.CodigoUsuarioDespachoNavigation).WithMany(p => p.FacturaCodigoUsuarioDespachoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioDespacho)
                .HasConstraintName("fk_usuarioDespacho");

            entity.HasOne(d => d.CodigoUsuarioModificaDireccionNavigation).WithMany(p => p.FacturaCodigoUsuarioModificaDireccionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificaDireccion)
                .HasConstraintName("FK__Factura__CodigoU__112D2DC5");

            entity.HasMany(d => d.CodigoGarantia).WithMany(p => p.CodigoFacturas)
                .UsingEntity<Dictionary<string, object>>(
                    "FacturaGarantiaDevolucion",
                    r => r.HasOne<Garantium>().WithMany()
                        .HasForeignKey("CodigoGarantia")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FacturaGarantiaDevolucion_Garantia"),
                    l => l.HasOne<Factura>().WithMany()
                        .HasForeignKey("CodigoFactura")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FacturaGarantiaDevolucion_Factura"),
                    j =>
                    {
                        j.HasKey("CodigoFactura", "CodigoGarantia");
                        j.ToTable("FacturaGarantiaDevolucion");
                    });
        });

        modelBuilder.Entity<FacturaCreditoFiscal>(entity =>
        {
            entity.HasKey(e => e.CodigoFacturaCreditoFiscal).HasName("PK_FacturaCreditoFiscal_CodigoFacturaCreditoFiscal");

            entity.ToTable("FacturaCreditoFiscal");

            entity.HasIndex(e => e.CodigoFactura, "UQ__FacturaC__EAED4A68A280AB99").IsUnique();

            entity.Property(e => e.ActividadEconomica).HasColumnType("text");
            entity.Property(e => e.NumeroRegistroFiscal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial).HasColumnType("text");
            entity.Property(e => e.TelefonoFactura)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoDepartamentoNavigation).WithMany(p => p.FacturaCreditoFiscals)
                .HasForeignKey(d => d.CodigoDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacturaCreditoFiscal_CodigoDepartamento");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithOne(p => p.FacturaCreditoFiscal)
                .HasForeignKey<FacturaCreditoFiscal>(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Factura_FacturaCreditoFiscal");

            entity.HasOne(d => d.CodigoMunicipioNavigation).WithMany(p => p.FacturaCreditoFiscals)
                .HasForeignKey(d => d.CodigoMunicipio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacturaCreditoFiscal_CodigoMunicipio");
        });

        modelBuilder.Entity<FacturaDepositoEmpresaEntrega>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FacturaDepositoEmpresaEntrega");

            entity.HasIndex(e => e.CodigoFactura, "FacturaDepositoEmpresaEntrega_CodigoFactura");

            entity.HasOne(d => d.CodigoDepositoEmpresaEntregaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoDepositoEmpresaEntrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacturaDepositoEmpresaEntrega_CodigoDepositoEmpresaEntrega");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacturaDepositoEmpresaEntrega_CodigoFactura");
        });

        modelBuilder.Entity<FacturaDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FacturaDetalle");

            entity.HasIndex(e => e.CodigoFactura, "IDX_FacturaDetall_CodigoFactura");

            entity.HasIndex(e => new { e.CodigoFactura, e.CodigoProducto }, "IDX_FacturaDetalle_CodFacturaCodProducto_PrecioUnitario_Cantidad");

            entity.HasIndex(e => e.CodigoPolizaContableServicio, "IDX_FacturaDetalle_CodigoPolizaContableServicio");

            entity.HasIndex(e => e.CodigoProducto, "IDX_FacturaDetalle_CodigoProducto_CodigoFacturaPrecioUnitarioCantidad");

            entity.HasIndex(e => e.CodigoServicio, "IDX_FacturaDetalle_CodigoServicio_CodigoFacturaPrecioUnitarioCantidad");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoPolizaContableServicioNavigation).WithMany()
                .HasForeignKey(d => d.CodigoPolizaContableServicio)
                .HasConstraintName("FK_FacturaDetalle_CodigoPolizaContableServicio_CodigoPolizaContable");

            entity.HasOne(d => d.CodigoServicioNavigation).WithMany()
                .HasForeignKey(d => d.CodigoServicio)
                .HasConstraintName("FK_FacturaDetalle_CodigoServicio");
        });

        modelBuilder.Entity<FormaDeEnvio>(entity =>
        {
            entity.HasKey(e => e.CodigoFormaDeEnvio).HasName("PK__FormaDeE__F598FC56E2C64605");

            entity.ToTable("FormaDeEnvio");

            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasMany(d => d.CodigoEmpresaDeEntregas).WithMany(p => p.CodigoFormaDeEnvios)
                .UsingEntity<Dictionary<string, object>>(
                    "FormaDeEnvioEmpresaDeEntrega",
                    r => r.HasOne<EmpresaDeEntrega>().WithMany()
                        .HasForeignKey("CodigoEmpresaDeEntrega")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FormaDeEnvioEmpresaDeEntrega_CodigoEmpresaDeEntrega"),
                    l => l.HasOne<FormaDeEnvio>().WithMany()
                        .HasForeignKey("CodigoFormaDeEnvio")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FormaDeEnvioEmpresaDeEntrega_CodigoFormaDeEnvio"),
                    j =>
                    {
                        j.HasKey("CodigoFormaDeEnvio", "CodigoEmpresaDeEntrega");
                        j.ToTable("FormaDeEnvioEmpresaDeEntrega");
                    });
        });

        modelBuilder.Entity<FormaDePago>(entity =>
        {
            entity.HasKey(e => e.CodigoFormaDePago);

            entity.ToTable("FormaDePago");

            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoTipoGuiaNavigation).WithMany(p => p.FormaDePagos)
                .HasForeignKey(d => d.CodigoTipoGuia)
                .HasConstraintName("FK_FormaDePago_TipoGuia");
        });

        modelBuilder.Entity<Garantium>(entity =>
        {
            entity.HasKey(e => e.CodigoGarantia).HasName("PK__Garantia");

            entity.HasIndex(e => e.CodigoEstadoGarantia, "IDX_CierreDeCaja_EstadoCodigoCuenta_Fecha");

            entity.HasIndex(e => e.CodigoPedido, "IDX_GarantiaCodigoPedido");

            entity.HasIndex(e => new { e.CodigoEstadoGarantia, e.ActualizaSaldoProveedor, e.CodigoVenta }, "IDX_Garantia_CodEstadoGantiaActualizaSaldoProveedorCodVenta_CodGarantiaFechaEntregaMontoReembolsadoPagoParcial");

            entity.HasIndex(e => new { e.CodigoEstadoGarantia, e.ActualizaSaldoProveedor }, "IDX_Garantia_CodigoEstadoGarantiaActualizaSaldoProveedor_CodigoVentaFechaEntregaMontoReembolsadoPagoParcial");

            entity.HasIndex(e => new { e.CodigoEstadoGarantia, e.CodigoCobro }, "IDX_Garantia_CodigoEstadoGarantiaCodigoCobro");

            entity.HasIndex(e => new { e.CodigoEstadoGarantia, e.PagoParcial }, "IDX_Garantia_CodigoEstadoGarantiaPagoParcial_CodigoVentaCodigoTipoGarantiaMontoReembolsado");

            entity.HasIndex(e => e.CodigoEstadoGarantia, "IDX_Garantia_CodigoEstadoGarantia_CodVentaFecInicioCorreoCodAmazonProdVerificado");

            entity.HasIndex(e => new { e.CodigoVenta, e.CodigoEstadoGarantia }, "IDX_Garantia_CodigoVentaCodigoEstadoGarantia");

            entity.HasIndex(e => new { e.Pedido, e.CodigoAmazon }, "IDX_Garantia_PedidoCodigoAmazon");

            entity.HasIndex(e => new { e.CodigoEstadoGarantia, e.Pedido, e.CodigoPedido, e.CodigoGarantia, e.CodigoVenta }, "_dta_index_Garantia_6_155147598__K2_K7_K6_K1_K3_15_20");

            entity.Property(e => e.CodigoGarantia).ValueGeneratedNever();
            entity.Property(e => e.ArticulosRecibidos).IsUnicode(false);
            entity.Property(e => e.CodigoAmazon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CorreoContacto)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(900)
                .IsUnicode(false);
            entity.Property(e => e.Dpi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DPI");
            entity.Property(e => e.ExcepcionTiempoGarantia).HasColumnType("text");
            entity.Property(e => e.FechaEntrega).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaInicio).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRecepcionGuia).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaResolucion).HasColumnType("smalldatetime");
            entity.Property(e => e.MensajeCliente).IsUnicode(false);
            entity.Property(e => e.MontoProveedor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoReembolsado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NombreContacto)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDeSerie)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PersonaEntrega)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Resolucion).IsUnicode(false);
            entity.Property(e => e.TelefonoContacto)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoCobroNavigation).WithMany(p => p.Garantia)
                .HasForeignKey(d => d.CodigoCobro)
                .HasConstraintName("FK_Garantia_Cobro");

            entity.HasOne(d => d.CodigoEstadoGarantiaNavigation).WithMany(p => p.Garantia)
                .HasForeignKey(d => d.CodigoEstadoGarantia)
                .HasConstraintName("FK_Garantia_EstadoGarantia");

            entity.HasOne(d => d.CodigoLocalidadNavigation).WithMany(p => p.Garantia)
                .HasForeignKey(d => d.CodigoLocalidad)
                .HasConstraintName("FK_Garantia_Localidad");

            entity.HasOne(d => d.CodigoPedidoNavigation).WithMany(p => p.Garantia)
                .HasForeignKey(d => d.CodigoPedido)
                .HasConstraintName("FK_Garantia_CodigoPedido");

            entity.HasOne(d => d.CodigoTipoGarantiaNavigation).WithMany(p => p.Garantia)
                .HasForeignKey(d => d.CodigoTipoGarantia)
                .HasConstraintName("FK_Garantia_TipoGarantia");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.Garantia)
                .HasForeignKey(d => d.CodigoVenta)
                .HasConstraintName("FK_Garantia_Venta");
        });

        modelBuilder.Entity<Gasto>(entity =>
        {
            entity.HasKey(e => e.CodigoGasto);

            entity.ToTable("Gasto");

            entity.HasIndex(e => new { e.CodigoTipoDeGasto, e.Estado, e.CodigoClaseDocumento, e.FechaAplica }, "GastoCodigoTipoGastoEstadoCodigoClaseDocumentoFechaAplica");

            entity.HasIndex(e => e.CodigoPolizaContableProveedor, "IDX_Gasto_CodigoPolizaContableProveedor");

            entity.HasIndex(e => new { e.CodigoTipoDeGasto, e.Estado, e.CodigoClaseDocumento, e.FechaOperacion }, "IDX_Gasto_CodigoTipoGastoEstadoCodigoClaseDocumentoFechaOperacion_FacturaCodigoProveedor");

            entity.HasIndex(e => e.CuentaOrigen, "IDX_Gasto_CuentaOrigen");

            entity.HasIndex(e => e.CuentaOrigen, "IDX_Gasto_CuentaOrigen_FechaMonto");

            entity.HasIndex(e => new { e.Estado, e.FechaAplica }, "IDX_Gasto_EstFecApli_MontoFacProvImgISR");

            entity.HasIndex(e => new { e.Estado, e.CodigoClaseDocumento, e.FechaAplica }, "IDX_Gasto_EstadoCodigoClaseDocumentoFechaAplica_CodigoTipoDeGastoCodigoProveedor");

            entity.HasIndex(e => new { e.Estado, e.CodigoProveedor, e.FechaOperacion }, "IDX_Gasto_EstadoCodigoProveedorFechaOperacion");

            entity.HasIndex(e => new { e.Estado, e.CodigoTipoDeGasto, e.FechaAplica }, "IDX_Gasto_EstadoCodigoTipoDeGastoFechaAplica_FechaFacturaCodigoProveedorCodigoClaseDocumentoFechaOperacion");

            entity.HasIndex(e => new { e.Estado, e.Fecha, e.CodigoClaseDocumento, e.CodigoTipoDeGasto, e.CodigoGasto }, "IDX_Gasto_EstadoFechaCodClaseDocumentoCodTipoDeGastoCodGasto");

            entity.HasIndex(e => new { e.Estado, e.FechaOperacion }, "IDX_Gasto_EstadoFechaOperacion");

            entity.HasIndex(e => new { e.Estado, e.FechaRevision }, "IDX_Gasto_EstadoFechaRevision");

            entity.HasIndex(e => new { e.Estado, e.FechaAplica, e.CodigoGasto, e.CodigoTipoDeGasto, e.CodigoClaseDocumento, e.CodigoProveedor }, "IDX_Gasto_EstadoFehcaAplicaCodGastoCodTipoGastoCodClaseDocCodProveedor");

            entity.HasIndex(e => e.FechaAplica, "IDX_Gasto_FechaAplica_FechaOperacion");

            entity.HasIndex(e => e.CodigoGasto, "_dta_index_Gasto_6_133575514__K1_5_13_25");

            entity.Property(e => e.CodigoGasto).ValueGeneratedNever();
            entity.Property(e => e.BoletaDeposito)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Factura)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAplica).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEliminacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificaGastoNoDeducible).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaOperacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaRevision).HasColumnType("datetime");
            entity.Property(e => e.Imagen)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Isr)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("ISR");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PolizaMayor).HasDefaultValue(false);

            entity.HasOne(d => d.CodigoClaseDocumentoNavigation).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.CodigoClaseDocumento)
                .HasConstraintName("FK__Gasto__CodigoCla__6DA1F5A9");

            entity.HasOne(d => d.CodigoFormaDePagoNavigation).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.CodigoFormaDePago)
                .HasConstraintName("FK_Gasto_FormaDePago");

            entity.HasOne(d => d.CodigoGastoImpuestoAduaneroNavigation).WithMany(p => p.InverseCodigoGastoImpuestoAduaneroNavigation)
                .HasForeignKey(d => d.CodigoGastoImpuestoAduanero)
                .HasConstraintName("FK_CodigoGastoImpuestoAduanero");

            entity.HasOne(d => d.CodigoPolizaContableProveedorNavigation).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.CodigoPolizaContableProveedor)
                .HasConstraintName("FK_gasto_PolizaContable");

            entity.HasOne(d => d.CodigoProveedorNavigation).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.CodigoProveedor)
                .HasConstraintName("FK__Gasto__CodigoPro__6BB9AD37");

            entity.HasOne(d => d.CodigoTipoDeGastoNavigation).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.CodigoTipoDeGasto)
                .HasConstraintName("FK_Gasto_TipoDeGasto");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.GastoCodigoUsuarioNavigations)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_Gasto_Usuario");

            entity.HasOne(d => d.CodigoUsuarioModificaGastoNoDeducibleNavigation).WithMany(p => p.GastoCodigoUsuarioModificaGastoNoDeducibleNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificaGastoNoDeducible)
                .HasConstraintName("FK_Gasto_CodigoUsuarioModificaGastoNoDeducible");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.GastoCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_Gasto_UsuarioModificacion");

            entity.HasOne(d => d.CuentaOrigenNavigation).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.CuentaOrigen)
                .HasConstraintName("FK_Gasto_CuentaOrigen");
        });

        modelBuilder.Entity<GastoDetalle>(entity =>
        {
            entity.HasKey(e => e.CodigoGastoDetalle);

            entity.ToTable("GastoDetalle");

            entity.Property(e => e.Monto).HasColumnType("decimal(16, 2)");

            entity.HasOne(d => d.CodigoGastoNavigation).WithMany(p => p.GastoDetalles)
                .HasForeignKey(d => d.CodigoGasto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PK_GastoDetalle_Gasto");

            entity.HasOne(d => d.CodigoTipoGastoNavigation).WithMany(p => p.GastoDetalles)
                .HasForeignKey(d => d.CodigoTipoGasto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PK_GastoDetalle_TipoDeGasto");
        });

        modelBuilder.Entity<GestionCorreoExencion>(entity =>
        {
            entity.HasKey(e => e.CodigoGestionCorreoExtencion).HasName("PK_CodigoGestionCorreoExencion");

            entity.ToTable("GestionCorreoExencion");

            entity.Property(e => e.EnviarCopiaExencion).HasDefaultValue(false);
            entity.Property(e => e.NuncaEnviarExencion).HasDefaultValue(false);
            entity.Property(e => e.SiempreEnviarExencion).HasDefaultValue(false);

            entity.HasOne(d => d.CodigoArancelNavigation).WithMany(p => p.GestionCorreoExencions)
                .HasForeignKey(d => d.CodigoArancel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GestionCorreoExenciono_CodigoArancel");

            entity.HasOne(d => d.CodigoEstablecimientoNavigation).WithMany(p => p.GestionCorreoExencions)
                .HasForeignKey(d => d.CodigoEstablecimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GestionCorreoExencion_CodigoEstablecimiento");

            entity.HasOne(d => d.CodigoUsuarioAplicacionExternaNavigation).WithMany(p => p.GestionCorreoExencions)
                .HasForeignKey(d => d.CodigoUsuarioAplicacionExterna)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GestionCorreoExencion_CodigoUsuarioAplicacionExterna");
        });

        modelBuilder.Entity<GradoUniversitario>(entity =>
        {
            entity.HasKey(e => e.CodigoGradoUniversitario).HasName("PK__GradoUni__7088E5F9D25D03A4");

            entity.ToTable("GradoUniversitario");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GuiaEliminadum>(entity =>
        {
            entity.HasKey(e => e.CodigoGuiaEliminada).HasName("PK__GuiaElim__C4C57F26FA7DC483");

            entity.HasIndex(e => e.CodigoFactura, "IDX_GuiaEliminadaCodigoFactura");

            entity.HasIndex(e => e.NumeroDeGuia, "IDX_GuiaEliminada_NumeroDeGuia");

            entity.Property(e => e.FechaRecepcionEmpresaDeEntrega).HasColumnType("smalldatetime");
            entity.Property(e => e.NumeroDeGuia)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .HasMaxLength(205)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoEmpresaDeEntregaNavigation).WithMany(p => p.GuiaEliminada)
                .HasForeignKey(d => d.CodigoEmpresaDeEntrega)
                .HasConstraintName("FK_GuiaEliminada_CodigoEmpresaDeEntrega");

            entity.HasOne(d => d.CodigoEstadoEntregaFacturaNavigation).WithMany(p => p.GuiaEliminada)
                .HasForeignKey(d => d.CodigoEstadoEntregaFactura)
                .HasConstraintName("FK_GuiaAnulada_EstadoEntregaFactura");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.GuiaEliminada)
                .HasForeignKey(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuiaAnulada_Factura");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.GuiaEliminada)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_GuiaAnulada_Usuario");
        });

        modelBuilder.Entity<GuiaReclamadum>(entity =>
        {
            entity.HasKey(e => e.CodigoGuiaReclamada);

            entity.HasIndex(e => new { e.CodigoEstadoGuiaReclamada, e.CodigoDeRastreo }, "_dta_index_GuiaReclamada_6_212754594__K6_K2");

            entity.Property(e => e.CodigoDeRastreo)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionReclamo)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.FechaReclamo).HasColumnType("smalldatetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Resolucion).HasColumnType("text");

            entity.HasOne(d => d.CodigoEmpresaDeEntregaNavigation).WithMany(p => p.GuiaReclamada)
                .HasForeignKey(d => d.CodigoEmpresaDeEntrega)
                .HasConstraintName("FK_GuiaReclamada_CodigoEmpresaDeEntrega");

            entity.HasOne(d => d.CodigoEstadoGuiaReclamadaNavigation).WithMany(p => p.GuiaReclamada)
                .HasForeignKey(d => d.CodigoEstadoGuiaReclamada)
                .HasConstraintName("FK__GuiaRecla__Codig__65356C25");
        });

        modelBuilder.Entity<HistoricoPagoVentum>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CodigoVenta, "IDX_HistoricoPagoVenta_CodigoVenta");

            entity.Property(e => e.FechaPago).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoBancoNavigation).WithMany()
                .HasForeignKey(d => d.CodigoBanco)
                .HasConstraintName("FK_HistoricoPagoVenta_CodigoBanco");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoVenta)
                .HasConstraintName("FK_HistoricoPagoVenta_CodigoVenta");

            entity.HasOne(d => d.UsuarioPagoNavigation).WithMany()
                .HasForeignKey(d => d.UsuarioPago)
                .HasConstraintName("FK_HistoricoPagoVenta_UsuarioPago");
        });

        modelBuilder.Entity<HistoricoVale>(entity =>
        {
            entity.HasKey(e => e.CodigoHistoricoVale).HasName("PK_CodigoHistoricoVale");

            entity.ToTable("HistoricoVale");

            entity.Property(e => e.Estado).HasDefaultValue(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.HistoricoVales)
                .HasForeignKey(d => d.CodigoFactura)
                .HasConstraintName("FK_HistoricoVale_Factura");

            entity.HasOne(d => d.CodigoTipoHistoricoNavigation).WithMany(p => p.HistoricoVales)
                .HasForeignKey(d => d.CodigoTipoHistorico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoVale_TipoHistorico");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.HistoricoVales)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .HasConstraintName("FK_HistoricoVale_UsuarioCreacion");

            entity.HasOne(d => d.CodigoValeNavigation).WithMany(p => p.HistoricoVales)
                .HasForeignKey(d => d.CodigoVale)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoVale_Vale");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.HistoricoVales)
                .HasForeignKey(d => d.CodigoVenta)
                .HasConstraintName("FK_HistoricoVale_Venta");
        });

        modelBuilder.Entity<ImagenContraCargo>(entity =>
        {
            entity.HasKey(e => e.CodigoImagenContraCargo).HasName("PK__ImagenCo__A66710B7F235290B");

            entity.ToTable("ImagenContraCargo");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");
            entity.Property(e => e.FechaSubida).HasColumnType("datetime");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UrlImagen)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoContraCargoNavigation).WithMany(p => p.ImagenContraCargos)
                .HasForeignKey(d => d.CodigoContraCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContraCargo_ImagenContraCargo_CodigoContraCargo");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.ImagenContraCargoCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_ImagenContraCargo_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioEliminacionNavigation).WithMany(p => p.ImagenContraCargoCodigoUsuarioEliminacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEliminacion)
                .HasConstraintName("FK_Usuario_ImagenContraCargo_CodigoUsuarioEliminacion");
        });

        modelBuilder.Entity<ImagenDeposito>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImagenDeposito");

            entity.Property(e => e.CodigoImagenDeposito).ValueGeneratedOnAdd();
            entity.Property(e => e.FechaEliminacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaSubida).HasColumnType("smalldatetime");
            entity.Property(e => e.Urlimagen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URLImagen");

            entity.HasOne(d => d.CodigoTransaccionNavigation).WithMany()
                .HasForeignKey(d => d.CodigoTransaccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImagenDep__Codig__3E34B5CE");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany()
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImagenDep__Codig__3F28DA07");

            entity.HasOne(d => d.CodigoUsuarioEliminacionNavigation).WithMany()
                .HasForeignKey(d => d.CodigoUsuarioEliminacion)
                .HasConstraintName("FK__ImagenDep__Codig__401CFE40");
        });

        modelBuilder.Entity<ImagenGarantium>(entity =>
        {
            entity.HasKey(e => e.CodigoImagenGarantia).HasName("PK__ImagenGa__17EAD95533C525A4");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FechaSubida).HasColumnType("datetime");
            entity.Property(e => e.Urlimagen)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLImagen");

            entity.HasOne(d => d.CodigoGarantiaNavigation).WithMany(p => p.ImagenGarantia)
                .HasForeignKey(d => d.CodigoGarantia)
                .HasConstraintName("FK_CodigoGarantiaImagenGarantia");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.ImagenGarantia)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_CodigoUsuarioImagenGarantia");
        });

        modelBuilder.Entity<ImagenGasto>(entity =>
        {
            entity.HasKey(e => e.CodigoImagenGasto).HasName("PK__ImagenGa__5CC48B0575B9BA59");

            entity.ToTable("ImagenGasto");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaEliminacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaSubida)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Urlimagen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URLImagen");

            entity.HasOne(d => d.CodigoGastoNavigation).WithMany(p => p.ImagenGastos)
                .HasForeignKey(d => d.CodigoGasto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenGasto_Gasto");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.ImagenGastoCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenGasto_UsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioEliminacionNavigation).WithMany(p => p.ImagenGastoCodigoUsuarioEliminacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEliminacion)
                .HasConstraintName("FK_ImagenGasto_UsuarioEliminacion");
        });

        modelBuilder.Entity<ImagenGuiaReclamadum>(entity =>
        {
            entity.HasKey(e => e.CodigoImagenGuiaReclamo).HasName("PK__ImagenGu__F8F048F537E69323");

            entity.Property(e => e.CodigoImagenGuiaReclamo).HasColumnName("codigoImagenGuiaReclamo");
            entity.Property(e => e.FechaEliminacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaSubida).HasColumnType("smalldatetime");
            entity.Property(e => e.Urlimagen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URLImagen");

            entity.HasOne(d => d.CodigoGuiaReclamadaNavigation).WithMany(p => p.ImagenGuiaReclamada)
                .HasForeignKey(d => d.CodigoGuiaReclamada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImagenGui__Codig__0CB7A12D");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.ImagenGuiaReclamadumCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImagenGui__Codig__0DABC566");

            entity.HasOne(d => d.CodigoUsuarioEliminacionNavigation).WithMany(p => p.ImagenGuiaReclamadumCodigoUsuarioEliminacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEliminacion)
                .HasConstraintName("FK__ImagenGui__Codig__0E9FE99F");
        });

        modelBuilder.Entity<ImagenPaqueteReclamadum>(entity =>
        {
            entity.HasKey(e => e.CodigoImagenPaqueteReclamadao).HasName("PK__ImagenPa__62734C70BADAA091");

            entity.Property(e => e.CodigoImagenPaqueteReclamadao).HasColumnName("codigoImagenPaqueteReclamadao");
            entity.Property(e => e.FechaEliminacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaSubida).HasColumnType("smalldatetime");
            entity.Property(e => e.Urlimagen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URLImagen");

            entity.HasOne(d => d.CodigoPaqueteReclamadoNavigation).WithMany(p => p.ImagenPaqueteReclamada)
                .HasForeignKey(d => d.CodigoPaqueteReclamado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImagenPaq__Codig__117C564A");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.ImagenPaqueteReclamadumCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImagenPaq__Codig__12707A83");

            entity.HasOne(d => d.CodigoUsuarioEliminacionNavigation).WithMany(p => p.ImagenPaqueteReclamadumCodigoUsuarioEliminacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEliminacion)
                .HasConstraintName("FK__ImagenPaq__Codig__13649EBC");
        });

        modelBuilder.Entity<ImagenPolizaDeImportacion>(entity =>
        {
            entity.HasKey(e => e.CodigoImagenPolizaDeImportacion).HasName("PK__ImagenPo__3F76C6A70A6B7DC2");

            entity.ToTable("ImagenPolizaDeImportacion");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");
            entity.Property(e => e.FechaSubida).HasColumnType("datetime");
            entity.Property(e => e.UrlImagen)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoPolizaDeImportacionNavigation).WithMany(p => p.ImagenPolizaDeImportacions)
                .HasForeignKey(d => d.CodigoPolizaDeImportacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenPolizaDeImportacion_CodigoPolizaDeImportacion");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.ImagenPolizaDeImportacionCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagenPolizaDeImportacion_CodigoUsuario_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioEliminacionNavigation).WithMany(p => p.ImagenPolizaDeImportacionCodigoUsuarioEliminacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEliminacion)
                .HasConstraintName("FK_ImagenPolizaDeImportacion_CodigoUsuario_CodigoUsuarioEliminacion");
        });

        modelBuilder.Entity<ImagenTema>(entity =>
        {
            entity.HasKey(e => e.CodigoImagenTema).HasName("PK__ImagenTe__084C9C7DDD029F3C");

            entity.ToTable("ImagenTema");

            entity.Property(e => e.Urlimagen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URLImagen");

            entity.HasOne(d => d.CodigoTemaNavigation).WithMany(p => p.ImagenTemas)
                .HasForeignKey(d => d.CodigoTema)
                .HasConstraintName("FK_CodigoTema");
        });

        modelBuilder.Entity<Importador>(entity =>
        {
            entity.HasKey(e => e.CodigoImportador).HasName("PK_CodigoImportador");

            entity.ToTable("Importador");

            entity.Property(e => e.AplicaVerificacionTracking).HasDefaultValue(false);
            entity.Property(e => e.AsociaGuia).HasDefaultValue(true);
            entity.Property(e => e.CorreoFacturas).HasMaxLength(150);
            entity.Property(e => e.CorreoPaquetesSinImpuestos).HasMaxLength(150);
            entity.Property(e => e.CorreosApi)
                .HasMaxLength(150)
                .HasColumnName("CorreosAPI");
            entity.Property(e => e.Direccion1Envio).HasMaxLength(510);
            entity.Property(e => e.Dominio).HasMaxLength(50);
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Linea1Awb)
                .HasMaxLength(50)
                .HasColumnName("Linea1AWB");
            entity.Property(e => e.Linea2Awb)
                .HasMaxLength(50)
                .HasColumnName("Linea2AWB");
            entity.Property(e => e.Linea3Awb)
                .HasMaxLength(50)
                .HasColumnName("Linea3AWB");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.PatronGuia)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TituloCorreoFactura).HasMaxLength(100);
            entity.Property(e => e.TituloCorreoNotificacionBodegaGuatemala).HasMaxLength(100);
            entity.Property(e => e.TituloCorreoNotificacionBodegaMiami).HasMaxLength(100);
            entity.Property(e => e.ValorLibra).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.UsuarioModificacionNavigation).WithMany(p => p.Importadors)
                .HasForeignKey(d => d.UsuarioModificacion)
                .HasConstraintName("FK__Importado__Usuar__6C2A85B9");
        });

        modelBuilder.Entity<IncidenciaVentum>(entity =>
        {
            entity.HasKey(e => e.CodigoIncidenciaVenta).HasName("PK__Incidenc__D7E40DD6263F0EE3");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IndiceDeBusquedum>(entity =>
        {
            entity.HasKey(e => e.CodigoIndiceDeBusqueda);

            entity.HasIndex(e => e.SearchIndex, "IDX_SearchIndex");

            entity.Property(e => e.CodigoIndiceDeBusqueda).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SearchIndex)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IntentoDeEntrega>(entity =>
        {
            entity.HasKey(e => e.CodigoIntentoDeEntrega);

            entity.ToTable("IntentoDeEntrega");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UbicacionIntentoEntrega)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.IntentoDeEntregas)
                .HasForeignKey(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntentoDeEntrega_Factura");

            entity.HasOne(d => d.CodigoMotivoRetornoNavigation).WithMany(p => p.IntentoDeEntregas)
                .HasForeignKey(d => d.CodigoMotivoRetorno)
                .HasConstraintName("FK_IntentoDeEntrega_CodigoMotivoRetorno");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.IntentoDeEntregas)
                .HasForeignKey(d => d.CodigoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntentoDeEntrega_Usuario");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.CodigoInventario).HasName("PK__Inventar__D5EC1A766AB506C4");

            entity.ToTable("Inventario");

            entity.Property(e => e.FechaFinal).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaInicial).HasColumnType("smalldatetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InventarioDiario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InventarioDiario");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.Fecha }, "IDX_InventarioDiario_CodigoEstablecimientoFecha_MontoMontoVentaCantidadDeProductosCantidadDeProductosDiferentes");

            entity.HasIndex(e => e.Fecha, "IDX_InventarioDiario_Fecha_CodigoEstablecimientoMontoMontoVentaCantidadDeProductosCantidadDeProductosDiferentes");

            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoVenta).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Ipexterna>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IPExterna");

            entity.HasIndex(e => e.Pais, "IDX_IPExterna_Pais");

            entity.HasIndex(e => e.Pais, "IDX_IPExterna_Pais_IP");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TituloPagina)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UrlDestino)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("urlDestino");
            entity.Property(e => e.UrlOrigen)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ippai>(entity =>
        {
            entity.HasKey(e => e.Network);

            entity.ToTable("IPPais");

            entity.Property(e => e.Network)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("network");
            entity.Property(e => e.GeonameId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("geoname_id");
            entity.Property(e => e.IsAnonymousProxy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("is_anonymous_proxy");
            entity.Property(e => e.IsSatelliteProvider)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("is_satellite_provider");
            entity.Property(e => e.RegisteredCountryGeonameId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("registered_country_geoname_id");
            entity.Property(e => e.RepresentedCountryGeonameId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("represented_country_geoname_id");
        });

        modelBuilder.Entity<LibroContable>(entity =>
        {
            entity.HasKey(e => e.CodigoLibroContable).HasName("PK__LibroCon__81B1E6FA102C17D7");

            entity.ToTable("LibroContable");

            entity.Property(e => e.Nombre)
                .HasMaxLength(700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LlamadaKeepa>(entity =>
        {
            entity.HasKey(e => e.CodigoLlamada).HasName("PK__LlamadaK__04F114264B0DDF75");

            entity.ToTable("LlamadaKeepa");

            entity.Property(e => e.CodigoLlamada)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<Localidad>(entity =>
        {
            entity.HasKey(e => e.CodigoLocalidad).HasName("PK__Localida__88D96045C048D567");

            entity.ToTable("Localidad");

            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.CodigoMarca).HasName("PK__Marca__F44A70CC6B44E613");

            entity.ToTable("Marca");

            entity.Property(e => e.Campania)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CampaniaStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaAnuncio).HasColumnType("smalldatetime");
            entity.Property(e => e.GrupoStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MedioAplicacionPlaza>(entity =>
        {
            entity.HasKey(e => e.CodigoMedioAplicacionPlaza).HasName("PK_MedioAplicacionPlaza_CodigoMedioAplicacionPlaza");

            entity.ToTable("MedioAplicacionPlaza");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MedioDesuscripcion>(entity =>
        {
            entity.HasKey(e => e.CodigoMedioDesuscripcion).HasName("PK__MedioDes__3C4CA697C9C80E6F");

            entity.ToTable("MedioDesuscripcion");

            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MedioSuscripcion>(entity =>
        {
            entity.HasKey(e => e.CodigoMedioSuscripcion).HasName("PK__MedioSus__63C872492F650636");

            entity.ToTable("MedioSuscripcion");

            entity.Property(e => e.CodigoMedioSuscripcion).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Membresium>(entity =>
        {
            entity.HasKey(e => e.CodigoMembresia).HasName("PK__Membresi__2494F508B28BB4A4");

            entity.Property(e => e.AliasMembresia).HasMaxLength(255);
            entity.Property(e => e.CodigoSeguridad).HasMaxLength(100);
            entity.Property(e => e.DireccionDeEntrega)
                .HasMaxLength(900)
                .IsUnicode(false);
            entity.Property(e => e.FechaCancelacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaVencimineto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreTarjeta).HasMaxLength(255);
            entity.Property(e => e.NumeroTarjeta).HasMaxLength(255);

            entity.HasOne(d => d.CodigoClienteNavigation).WithMany(p => p.Membresia)
                .HasForeignKey(d => d.CodigoCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Membresia_Cliente");

            entity.HasOne(d => d.CodigoDepartamentoNavigation).WithMany(p => p.Membresia)
                .HasForeignKey(d => d.CodigoDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Membresia_Departamento");

            entity.HasOne(d => d.CodigoMunicipioNavigation).WithMany(p => p.Membresia)
                .HasForeignKey(d => d.CodigoMunicipio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Membresia_Municipio");

            entity.HasOne(d => d.CodigoTipoDeTarjetaNavigation).WithMany(p => p.Membresia)
                .HasForeignKey(d => d.CodigoTipoDeTarjeta)
                .HasConstraintName("FK_Membresia_TipoDeTarjeta");
        });

        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.HasKey(e => e.CodigoMensaje);

            entity.ToTable("Mensaje");

            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Texto)
                .HasMaxLength(2570)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoCategoriaMensajeNavigation).WithMany(p => p.Mensajes)
                .HasForeignKey(d => d.CodigoCategoriaMensaje)
                .HasConstraintName("fk_mensaje_categoriaMensaje");
        });

        modelBuilder.Entity<ModificacionDeInventario>(entity =>
        {
            entity.HasKey(e => e.CodigoModificacionDeInventario).HasName("PK__Modifica__61E6B7983552E9B6");

            entity.ToTable("ModificacionDeInventario");

            entity.Property(e => e.CodigoModificacionDeInventario).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.ModificacionDeInventarios)
                .HasForeignKey(d => d.CodigoProducto)
                .HasConstraintName("FK_ModificacionDeInventario_Producto");
        });

        modelBuilder.Entity<Monedum>(entity =>
        {
            entity.HasKey(e => e.CodigoMoneda).HasName("PK__Moneda__8E6DB165D8E4C0F7");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Simbolo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<MotivoReclamo>(entity =>
        {
            entity.HasKey(e => e.CodigoMotivoReclamo);

            entity.ToTable("MotivoReclamo");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MotivoRetorno>(entity =>
        {
            entity.HasKey(e => e.CodigoMotivoRetorno).HasName("PK__MotivoRe__FF6C5BDC2F36E01F");

            entity.ToTable("MotivoRetorno");

            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MotivoRetornoEmpresaDeEntrega>(entity =>
        {
            entity.HasKey(e => new { e.CodigoMotivoRetornoEmpresaEntrega, e.CodigoEmpresaDeEntrega });

            entity.ToTable("MotivoRetornoEmpresaDeEntrega");

            entity.Property(e => e.CodigoMotivoRetornoEmpresaEntrega)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoEmpresaDeEntregaNavigation).WithMany(p => p.MotivoRetornoEmpresaDeEntregas)
                .HasForeignKey(d => d.CodigoEmpresaDeEntrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MotivoRetornoEmpresaDeEntrega_CodigoEmpresaDeEntrega");

            entity.HasOne(d => d.CodigoMotivoRetornoNavigation).WithMany(p => p.MotivoRetornoEmpresaDeEntregas)
                .HasForeignKey(d => d.CodigoMotivoRetorno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MotivoRetornoEmpresaDeEntrega_CodigoMotivoRetorno");
        });

        modelBuilder.Entity<Movimiento>(entity =>
        {
            entity.HasKey(e => e.CodigoMovimiento);

            entity.ToTable("Movimiento");

            entity.HasIndex(e => new { e.CodigoVenta, e.CodigoMovimiento, e.Fecha, e.CodigoTipoMovimiento }, "IDX_Movimieno_CodigoVentaCodigoMovimientoFecha_CodigoTipoMovimiento");

            entity.HasIndex(e => new { e.CodigoTipoMovimiento, e.CodigoVenta }, "IDX_MovimientoCodTipoMovimientoCodVenta_Fecha");

            entity.HasIndex(e => e.Actualizado, "IDX_Movimiento_Actualizado_CodigoTipoMovimientoCodigoProductoCantidadFechaCodigoUsuarioCodigoVentaCodigoEmbarque");

            entity.HasIndex(e => new { e.CodigoTipoMovimiento, e.Cantidad, e.Fecha }, "IDX_Movimiento_CodTipoMovCantidadFecha_CodEmbCodPolizaEntradaMercaderiaCodPolizaEntradaArancelCantidadAnterior");

            entity.HasIndex(e => new { e.CodigoTipoMovimiento, e.Cantidad, e.Fecha }, "IDX_Movimiento_CodTipoMovCantidadFecha_CodVentaCodPolizaEntradaMercaderiaCodPolizaEntradaArancelCantidadAnterior");

            entity.HasIndex(e => new { e.CodigoUsuario, e.CodigoVenta, e.CodigoTipoMovimiento }, "IDX_Movimiento_CodigoMovimientoUsuarioVenta");

            entity.HasIndex(e => e.CodigoPolizaEntradaArancel, "IDX_Movimiento_CodigoPolizaEntradaArancel");

            entity.HasIndex(e => e.CodigoPolizaEntradaMercaderia, "IDX_Movimiento_CodigoPolizaEntradaMercaderia");

            entity.HasIndex(e => e.CodigoPolizaSalidaArancel, "IDX_Movimiento_CodigoPolizaSalidaArancel");

            entity.HasIndex(e => e.CodigoPolizaSalidaMercaderia, "IDX_Movimiento_CodigoPolizaSalidaMercaderia");

            entity.HasIndex(e => e.CodigoProducto, "IDX_Movimiento_CodigoProducto");

            entity.HasIndex(e => e.CodigoTipoMovimiento, "IDX_Movimiento_CodigoTipoMovimiento_CodigoProducto_Cantidad");

            entity.HasIndex(e => e.CodigoTipoMovimiento, "IDX_Movimiento_CodigoTipoMovimiento_FechaCodigoVenta");

            entity.HasIndex(e => new { e.CodigoUsuario, e.CodigoTipoMovimiento }, "IDX_Movimiento_CodigoUsuarioCodigoTipoMovimiento_FechaCodigoVenta");

            entity.HasIndex(e => e.CodigoVenta, "IDX_Movimiento_CodigoVenta");

            entity.HasIndex(e => new { e.Fecha, e.CodigoTipoMovimiento, e.Cantidad, e.CodigoPolizaEntradaMercaderia }, "IDX_Movimiento_FechaCodTipoMovimientoCantidadCodPolizaEntradaMercaderia");

            entity.HasIndex(e => e.Fecha, "IDX_Movimiento_Fecha_CodigoProducto");

            entity.HasIndex(e => e.VentaEmbarqueAnt, "IDX_Movimiento_VentaEmbarqueAnt");

            entity.Property(e => e.CodigoMovimiento).ValueGeneratedNever();
            entity.Property(e => e.CodigoEmbarque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiasAtraso).HasDefaultValue(0);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.VentaEmbarqueAnt)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoEmbarqueNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.CodigoEmbarque)
                .HasConstraintName("FK_Embarque_Movimiento");

            entity.HasOne(d => d.CodigoPolizaEntradaArancelNavigation).WithMany(p => p.MovimientoCodigoPolizaEntradaArancelNavigations)
                .HasForeignKey(d => d.CodigoPolizaEntradaArancel)
                .HasConstraintName("FK_MovimientoEntradaArancel_Cuenta");

            entity.HasOne(d => d.CodigoPolizaEntradaMercaderiaNavigation).WithMany(p => p.MovimientoCodigoPolizaEntradaMercaderiaNavigations)
                .HasForeignKey(d => d.CodigoPolizaEntradaMercaderia)
                .HasConstraintName("FK_MovimientoEntradaMercaderia_Cuenta");

            entity.HasOne(d => d.CodigoPolizaSalidaArancelNavigation).WithMany(p => p.MovimientoCodigoPolizaSalidaArancelNavigations)
                .HasForeignKey(d => d.CodigoPolizaSalidaArancel)
                .HasConstraintName("FK_MovimientoSalidaArancel_Cuenta");

            entity.HasOne(d => d.CodigoPolizaSalidaMercaderiaNavigation).WithMany(p => p.MovimientoCodigoPolizaSalidaMercaderiaNavigations)
                .HasForeignKey(d => d.CodigoPolizaSalidaMercaderia)
                .HasConstraintName("FK_MovimientoSalidaMercaderia_Cuenta");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.CodigoProducto)
                .HasConstraintName("FK_Movimiento_Producto");

            entity.HasOne(d => d.CodigoTipoMovimientoNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.CodigoTipoMovimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movimiento_TipoMovimiento");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_Movimiento_Usuario");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.CodigoVenta)
                .HasConstraintName("FK_Venta_Movimiento");
        });

        modelBuilder.Entity<MovimientoEstadoGarantium>(entity =>
        {
            entity.HasKey(e => e.CodigoMovimientoEstadoGarantia).HasName("PK_CodigoMovimientoEstadoGarantia");

            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoEstadoGarantiaNavigation).WithMany(p => p.MovimientoEstadoGarantia)
                .HasForeignKey(d => d.CodigoEstadoGarantia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoEstadoGarantia_CodigoEstadoGarantia");

            entity.HasOne(d => d.CodigoGarantiaNavigation).WithMany(p => p.MovimientoEstadoGarantia)
                .HasForeignKey(d => d.CodigoGarantia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoEstadoGarantia_CodigoGarantia");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.MovimientoEstadoGarantia)
                .HasForeignKey(d => d.CodigoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoEstadoGarantia_CodigoUsuario");
        });

        modelBuilder.Entity<MovimientoGarantium>(entity =>
        {
            entity.HasKey(e => e.CodigoMovimientoGarantia).HasName("PK__Movimien__E57DD95176FD9DBE");

            entity.Property(e => e.FechaHoraUsuarioModifica).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoEstadoGarantiaNavigation).WithMany(p => p.MovimientoGarantia)
                .HasForeignKey(d => d.CodigoEstadoGarantia)
                .HasConstraintName("FK_MovimientoGarantia_CodigoEstadoGarantia");

            entity.HasOne(d => d.CodigoGarantiaNavigation).WithMany(p => p.MovimientoGarantia)
                .HasForeignKey(d => d.CodigoGarantia)
                .HasConstraintName("FK_MovimientoGarantia_CodigoGarantia");

            entity.HasOne(d => d.CodigoUsuarioMovimientoNavigation).WithMany(p => p.MovimientoGarantia)
                .HasForeignKey(d => d.CodigoUsuarioMovimiento)
                .HasConstraintName("FK_MovimientoGarantia_CodigoUsuario");
        });

        modelBuilder.Entity<MovimientoMembresium>(entity =>
        {
            entity.HasKey(e => e.CodigoMovimientoMembresia).HasName("PK__Movimien__947E7BFF625033A3");

            entity.Property(e => e.NombreMovimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.CodigoMunicipio).HasName("PK__Municipi__FC9CE6BF51C15D4F");

            entity.ToTable("Municipio");

            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoDepartamentoNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.CodigoDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Municipio_Departamento");
        });

        modelBuilder.Entity<MunicipioEmpresaDeEntrega>(entity =>
        {
            entity.HasKey(e => new { e.CodigoMunicipio, e.CodigoEmpresaDeEntrega });

            entity.ToTable("MunicipioEmpresaDeEntrega");

            entity.Property(e => e.CodigoCabecera)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoEmpresaDeEntregaNavigation).WithMany(p => p.MunicipioEmpresaDeEntregas)
                .HasForeignKey(d => d.CodigoEmpresaDeEntrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MunicipioEmpresaDeEntrega_CodigoEmpresaDeEntrega");

            entity.HasOne(d => d.CodigoMunicipioNavigation).WithMany(p => p.MunicipioEmpresaDeEntregas)
                .HasForeignKey(d => d.CodigoMunicipio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MunicipioEmpresaDeEntrega_CodigoMunicipio");
        });

        modelBuilder.Entity<NoEnviarCorreo>(entity =>
        {
            entity.HasKey(e => e.CodigoNoEnviarcorreo).HasName("PK__NoEnviar__1CB98F5608F38FA7");

            entity.ToTable("NoEnviarCorreo");

            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NotaContable>(entity =>
        {
            entity.HasKey(e => e.CodigoNotaContable);

            entity.ToTable("NotaContable");

            entity.HasIndex(e => new { e.CodigoEstadoNotaContable, e.CodigoCobro }, "IDX_NotaContable_CodigoEstadoNotaContableCodigoCobro");

            entity.HasIndex(e => new { e.CodigoFactura, e.CodigoEstadoNotaContable }, "IDX_NotaContable_CodigoFacturaCodigoEstadoNotaContable");

            entity.HasIndex(e => e.CodigoPolizaContable, "IDX_NotaContable_CodigoPolizaContable");

            entity.HasIndex(e => new { e.FechaEmision, e.CodigoEstadoNotaContable }, "IDX_NotaContable_FechaEmisionCodigoEstadoNotaContable");

            entity.HasIndex(e => new { e.CodigoFactura, e.GuidFirma, e.GuidAnular, e.GuidRegistrarDocumento, e.GuidFirmaResponse, e.Cae, e.GuidAnularResponse }, "_dta_index_NotaContable_6_127088776__K6_K20_K22_K21_K23_K12_K25");

            entity.Property(e => e.CodigoNotaContable).ValueGeneratedNever();
            entity.Property(e => e.Cae)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CAE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FechaAnulacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEmision).HasColumnType("smalldatetime");
            entity.Property(e => e.GuidAnular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidAnularResponse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidFirma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidFirmaResponse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidRegistrarDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GuidRegistrarDocumentoResponse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Iva).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Numero).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UsuarioAnulacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValorNeto).HasColumnType("numeric(18, 2)");

            entity.HasOne(d => d.CodigoClaseDocumentoNavigation).WithMany(p => p.NotaContables)
                .HasForeignKey(d => d.CodigoClaseDocumento)
                .HasConstraintName("FK_notacontable_claseDocumento");

            entity.HasOne(d => d.CodigoCobroNavigation).WithMany(p => p.NotaContables)
                .HasForeignKey(d => d.CodigoCobro)
                .HasConstraintName("FK_NotaContable_Cobro");

            entity.HasOne(d => d.CodigoConceptoNotaContableNavigation).WithMany(p => p.NotaContables)
                .HasForeignKey(d => d.CodigoConceptoNotaContable)
                .HasConstraintName("FK_NotaContable_ConceptoNotaContable");

            entity.HasOne(d => d.CodigoEstadoNotaContableNavigation).WithMany(p => p.NotaContables)
                .HasForeignKey(d => d.CodigoEstadoNotaContable)
                .HasConstraintName("FK_NotaContable_CodigoEstadoNotaContable");

            entity.HasOne(d => d.CodigoPolizaContableNavigation).WithMany(p => p.NotaContables)
                .HasForeignKey(d => d.CodigoPolizaContable)
                .HasConstraintName("FK_NotaContable_PolizaContable");

            entity.HasOne(d => d.CodigoResolucionNavigation).WithMany(p => p.NotaContables)
                .HasForeignKey(d => d.CodigoResolucion)
                .HasConstraintName("FK_NotaContable_Resolucion");
        });

        modelBuilder.Entity<Notificacion>(entity =>
        {
            entity.HasKey(e => e.CodigoNotificacion);

            entity.ToTable("Notificacion");

            entity.HasIndex(e => e.CodigoProducto, "IDX_Notificacion_CodigoProducto");

            entity.Property(e => e.CodigoNotificacion).ValueGeneratedNever();
            entity.Property(e => e.Correo)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDisponible).HasColumnType("smalldatetime");
            entity.Property(e => e.Notificada).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.Notificacions)
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notificacion_Producto");
        });

        modelBuilder.Entity<ObservacionesComun>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ObservacionesComun");

            entity.Property(e => e.CodigoObservacionesComun).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Texto)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenDeCompra>(entity =>
        {
            entity.HasKey(e => e.OrdenDeAmazon).HasName("PK__OrdenDeC__66DE333A58671BC9");

            entity.ToTable("OrdenDeCompra");

            entity.Property(e => e.OrdenDeAmazon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaReembolsoImpuestoManual).HasColumnType("datetime");
        });

        modelBuilder.Entity<Pagina>(entity =>
        {
            entity.HasKey(e => e.CodigoPagina);

            entity.ToTable("Pagina");

            entity.HasIndex(e => e.Nombre, "IDX_Pagina_Nombre").IsUnique();

            entity.Property(e => e.CodigoPagina).ValueGeneratedNever();
            entity.Property(e => e.CostoMinimo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HtmlAnuncios)
                .HasDefaultValue("<div><a href=\"http://anuncios.guatemaladigital.com\" target=\"_blank\"><h3>Publica tu anuncio con nosotros</h3></a></div>")
                .HasColumnType("text");
            entity.Property(e => e.Jsonanuncios)
                .IsUnicode(false)
                .HasColumnName("JSONAnuncios");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ponderacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrimerLugar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Url)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoArchivoMenuNavigation).WithMany(p => p.Paginas)
                .HasForeignKey(d => d.CodigoArchivoMenu)
                .HasConstraintName("FK_Pagina_ArchivoMenu");
        });

        modelBuilder.Entity<PalabraNegativaProducto>(entity =>
        {
            entity.HasKey(e => e.CodigoPalabraNegativaProducto);

            entity.ToTable("PalabraNegativaProducto");

            entity.Property(e => e.PalabraNegativaProducto1)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("PalabraNegativaProducto");
        });

        modelBuilder.Entity<Paquete>(entity =>
        {
            entity.HasKey(e => e.CodigoPaquete).HasName("PK__Paquete");

            entity.ToTable("Paquete");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.CodigoGasto, e.GuiaAerea, e.FechaRecibida, e.MontoIva, e.MontoArancel, e.CodigoImportador }, "IDX_CodEstGastoGuiaRecibidaMontIvaArancelImportador_CodigoDeRastreo");

            entity.HasIndex(e => e.CodigoDeRastreo, "IDX_CodigoDeRastreo");

            entity.HasIndex(e => e.CodigoPolizaContableArancel, "IDX_CodigoPolizaContableArancel");

            entity.HasIndex(e => e.CodigoPolizaContableIva, "IDX_CodigoPolizaContableIVA");

            entity.HasIndex(e => e.CodigoPolizaContablePagoImpuesto, "IDX_CodigoPolizaContablePagoImpuesto");

            entity.HasIndex(e => e.GuiaAerea, "IDX_GuiaAerea")
                .IsUnique()
                .HasFilter("([GuiaAerea] IS NOT NULL)");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.GuiaAerea }, "IDX_Paquete_CodEstGuia_FecMontIvaMontArancelCodGastoCifDua");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.CodigoEstadoPaquete, e.FechaRecibida }, "IDX_Paquete_CodEstaCoEstadoPaqueteFecRec_DescriMontoIVAMontoArancelCodImpoCodGastCodIVACodArancel");

            entity.HasIndex(e => e.CodigoGasto, "IDX_Paquete_CodGasto_MontoFleteMontoIvaMontoArancel");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.CodigoImportador }, "IDX_Paquete_CodigoEstablecimientoCodigoImportador_CodigoDeRastreoGuiaAereaDescripcionPesoMonto");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.FechaMontoFlete, e.FechaRecibida, e.CodigoImportador }, "IDX_Paquete_CodigoEstablecimientoFechaMontoFleteFechaRecibidaCodigoImportador_CodigoDeRastreoCodigoEstadoPaquete");

            entity.HasIndex(e => new { e.CodigoEstadoPaquete, e.CodigoEstablecimiento, e.FechaEnvioFactura }, "IDX_Paquete_CodigoEstadoPaqueteCodigoEstablecimientoFechaEnvioFactura");

            entity.HasIndex(e => new { e.CodigoEstadoPaquete, e.CodigoEstablecimiento, e.FechaRecibida }, "IDX_Paquete_CodigoEstadoPaqueteCodigoEstablecimientoFechaRecibida");

            entity.HasIndex(e => new { e.CodigoEstadoPaquete, e.CodigoEstablecimiento, e.GuiaAerea, e.FechaEnvioFactura }, "IDX_Paquete_CodigoEstadoPaqueteCodigoEstablecimientoGuiaAereaFechaEnvioFactura_Fecha");

            entity.HasIndex(e => new { e.CodigoEstadoPaquete, e.CodigoImportador }, "IDX_Paquete_CodigoEstadoPaqueteCodigoImportador_CodigoDeRastreoGuiaAereaPesoCodigoEstablecimiento");

            entity.HasIndex(e => e.CodigoEstadoPaquete, "IDX_Paquete_CodigoEstadoPaquete_GuiaAereaFechaFechaRecibida");

            entity.HasIndex(e => e.CodigoImportador, "IDX_Paquete_CodigoImportador_FechaRecibida");

            entity.HasIndex(e => e.CodigoPolizaDeImportacion, "IDX_Paquete_CodigoPolizaDeImportacion");

            entity.HasIndex(e => e.Dua, "IDX_Paquete_DUA_CdRGAeDcMIFecCdEPqCdECdAraFecRecFecEvFactValMontFleteMtIVAMtArCdImpFecMonFleCdGasValLocCIFGDCIFAduCodUsCdPolImp");

            entity.HasIndex(e => new { e.FechaMontoFlete, e.CodigoEstadoPaquete, e.FechaRecibida, e.CodigoImportador }, "IDX_Paquete_FechaMontoFleteCodigoEstadoPaqueteFechaRecibidaCodigoImportador");

            entity.HasIndex(e => new { e.Generado, e.FechaRecibida, e.FechaEnvioFactura, e.Descripcion, e.CodigoEstadoPaquete }, "IDX_Paquete_GeneradoFechaRecibidaFechaEnvioFacturaDescripcionCodigoEstadoPaquete");

            entity.HasIndex(e => new { e.CodigoImportador, e.CodigoEstadoPaquete, e.FechaEnvioFactura }, "Paquete_CodigoImportadorCodigoEstadoPaqueteFechaEnvioFactura_CodigoDeRastreoGuiaAereaPesoCodigoEstablecimiento");

            entity.HasIndex(e => new { e.CodigoImportador, e.FechaMontoFlete, e.CodigoEstadoPaquete, e.FechaRecibida, e.FechaEnvioFactura }, "Paquete_CodigoImportadorFechaMontoFleteCodigoEstadoPaqueteFechaRecibidaFechaEnvioFactura");

            entity.HasIndex(e => e.FechaEnvioFactura, "Paquete_FechaEnvioFactura");

            entity.Property(e => e.Cifaduana)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("CIFAduana");
            entity.Property(e => e.CifguatemalaDigital)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("CIFGuatemalaDigital");
            entity.Property(e => e.CodigoDeRastreo)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPolizaContableIva).HasColumnName("CodigoPolizaContableIVA");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Dua)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DUA");
            entity.Property(e => e.EnviadoPor)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaCodigoDeRastreoNoEncontrado).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEnvioFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaInicioProceso).HasColumnType("datetime");
            entity.Property(e => e.FechaMontoFlete).HasColumnType("datetime");
            entity.Property(e => e.FechaRecibida).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioModificacion).HasColumnType("datetime");
            entity.Property(e => e.Gca)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GCA");
            entity.Property(e => e.GuiaAerea)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.MontoArancel).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoFlete).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoImpuesto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MontoIVA");
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PesoVolumetrico).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorFleteAduana).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.ValorLocal).HasColumnType("decimal(14, 2)");

            entity.HasOne(d => d.CodigoEstablecimientoNavigation).WithMany(p => p.Paquetes)
                .HasForeignKey(d => d.CodigoEstablecimiento)
                .HasConstraintName("FK_Paquete_Establecimiento");

            entity.HasOne(d => d.CodigoEstadoPaqueteNavigation).WithMany(p => p.Paquetes)
                .HasForeignKey(d => d.CodigoEstadoPaquete)
                .HasConstraintName("FK__Paquete__CodigoE__21617176");

            entity.HasOne(d => d.CodigoImportadorNavigation).WithMany(p => p.Paquetes)
                .HasForeignKey(d => d.CodigoImportador)
                .HasConstraintName("FK__Paquete__CodigoI__72C5FFBD");

            entity.HasOne(d => d.CodigoPolizaContableArancelNavigation).WithMany(p => p.PaqueteCodigoPolizaContableArancelNavigations)
                .HasForeignKey(d => d.CodigoPolizaContableArancel)
                .HasConstraintName("FK_PaqueteArancel_PolizaContable");

            entity.HasOne(d => d.CodigoPolizaContableIvaNavigation).WithMany(p => p.PaqueteCodigoPolizaContableIvaNavigations)
                .HasForeignKey(d => d.CodigoPolizaContableIva)
                .HasConstraintName("FK_PaqueteIva_PolizaContable");

            entity.HasOne(d => d.CodigoPolizaContablePagoImpuestoNavigation).WithMany(p => p.PaqueteCodigoPolizaContablePagoImpuestoNavigations)
                .HasForeignKey(d => d.CodigoPolizaContablePagoImpuesto)
                .HasConstraintName("FK_PaquetePagoImpuesto_PolizaContable");

            entity.HasOne(d => d.CodigoPolizaDeImportacionNavigation).WithMany(p => p.Paquetes)
                .HasForeignKey(d => d.CodigoPolizaDeImportacion)
                .HasConstraintName("FK_Paquete_CodigoPolizaDeImportacion");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.Paquetes)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK__Paquete__CodigoU__2349B9E8");
        });

        modelBuilder.Entity<PaqueteReclamado>(entity =>
        {
            entity.HasKey(e => e.CodigoPaqueteReclamado).HasName("PK__PaqueteR__655CF23A00A1EBBF");

            entity.ToTable("PaqueteReclamado");

            entity.HasIndex(e => e.CodigoEstadoPaqueteReclamado, "IDX_PaqueteReclamado_CodigoEstadoPaqueteReclamado_FechaReclamo");

            entity.HasIndex(e => e.CodigoPaquete, "IDX_PaqueteReclamado_CodigoPaquete");

            entity.Property(e => e.DescripcionReclamo)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.FechaCambioEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaReclamo).HasColumnType("smalldatetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Resolucion).HasColumnType("text");

            entity.HasOne(d => d.CodigoEstadoPaqueteReclamadoNavigation).WithMany(p => p.PaqueteReclamados)
                .HasForeignKey(d => d.CodigoEstadoPaqueteReclamado)
                .HasConstraintName("FK__PaqueteRe__Codig__037E586A");

            entity.HasOne(d => d.CodigoMotivoReclamoNavigation).WithMany(p => p.PaqueteReclamados)
                .HasForeignKey(d => d.CodigoMotivoReclamo)
                .HasConstraintName("FK_PaqueteReclamado_CodigoMotivoReclamo");

            entity.HasOne(d => d.CodigoPaqueteNavigation).WithMany(p => p.PaqueteReclamados)
                .HasForeignKey(d => d.CodigoPaquete)
                .HasConstraintName("FK__PaqueteRe__Codig__2AEADBB0");

            entity.HasOne(d => d.CodigoTipoReclamoPaqueteNavigation).WithMany(p => p.PaqueteReclamados)
                .HasForeignKey(d => d.CodigoTipoReclamoPaquete)
                .HasConstraintName("FK__PaqueteRe__Codig__04727CA3");

            entity.HasOne(d => d.CodigoUsuarioCambioEstadoNavigation).WithMany(p => p.PaqueteReclamadoCodigoUsuarioCambioEstadoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCambioEstado)
                .HasConstraintName("FK__PaqueteRe__Codig__27A7A1FB");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.PaqueteReclamadoCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK__PaqueteRe__Codig__289BC634");

            entity.HasOne(d => d.CodigoUsuarioReclamoNavigation).WithMany(p => p.PaqueteReclamadoCodigoUsuarioReclamoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioReclamo)
                .HasConstraintName("FK_PaqueteReclamado_CodigoUsuarioReclamo");
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.HasKey(e => e.CodigoParametro).HasName("PK__Parametr__30F6E5D06AD18BB8");

            entity.ToTable("Parametro");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.FechaUsuarioModifica).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasMaxLength(2000);

            entity.HasOne(d => d.CodigoUsuarioModificaNavigation).WithMany(p => p.Parametros)
                .HasForeignKey(d => d.CodigoUsuarioModifica)
                .HasConstraintName("FK_Parametro_CodigoUsuarioModifica");
        });

        modelBuilder.Entity<ParametroPorcentajeImpuesto>(entity =>
        {
            entity.HasKey(e => e.CodigoParametroPorcentajeImpuesto).HasName("PK__Parametr__3382CBADBECB8B39");

            entity.ToTable("ParametroPorcentajeImpuesto");

            entity.HasOne(d => d.CodigoClaseDocumentoNavigation).WithMany(p => p.ParametroPorcentajeImpuestos)
                .HasForeignKey(d => d.CodigoClaseDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParametroPorcentajeImpuesto_CodigoClaseDocumento");

            entity.HasOne(d => d.CodigoPorcentajeImpuestoNavigation).WithMany(p => p.ParametroPorcentajeImpuestos)
                .HasForeignKey(d => d.CodigoPorcentajeImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParametroPorcentajeImpuesto_CodigoPorcentajeImpuesto");

            entity.HasOne(d => d.CodigoRegimenNavigation).WithMany(p => p.ParametroPorcentajeImpuestos)
                .HasForeignKey(d => d.CodigoRegimen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParametroPorcentajeImpuesto_CodigoRegimen");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.CodigoPedido);

            entity.ToTable("Pedido");

            entity.HasIndex(e => e.CodigoDeRastreo, "IDX_CodigoDeRastreo");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_CodigoEstadoPedido");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_CodigoEstadoPedido_CodigoPedidoAmazonCantidadReservado");

            entity.HasIndex(e => e.CodigoPaquete, "IDX_CodigoPaquete");

            entity.HasIndex(e => new { e.OrdenDeAmazon, e.CodigoAmazon }, "IDX_OrdenAmazon_CodigoAmazon");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_Paquete_CodigoEstadoPaqueteCodigoEstablecimientoGuiaAereaFechaEnvioFactura_Fecha");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.Cantidad, e.CodigoPedido, e.CodigoAmazon, e.CodigoPaquete, e.CodigoDeRastreo }, "IDX_PedidoCodEstadoPedidoCantidadCodPedidoCodAmazonCodPaqueteCodDeRastreo");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_PedidoCodigoEstado_OrdenAmazonCodigoAmazonCodigoRastreoCodigoPaquete");

            entity.HasIndex(e => new { e.CodigoAmazon, e.FechaDeOrden }, "IDX_Pedido_CodAmazonFechaDeOrden");

            entity.HasIndex(e => new { e.CodigoAmazon, e.FechaDeOrden, e.CodigoPedido, e.CodigoEstadoPedido }, "IDX_Pedido_CodAmazonFechaDeOrdenCodEstadoPedido_PrecioWebsite");

            entity.HasIndex(e => new { e.CodigoAmazon, e.FechaDeOrden, e.CodigoPedido }, "IDX_Pedido_CodAmazonFechaOrdenCodPedido");

            entity.HasIndex(e => new { e.CodigoEmbarque, e.Cantidad, e.CodigoEstadoPedido, e.CodigoAmazon, e.CodigoPedido }, "IDX_Pedido_CodEmbarqueCantidadCodEstadoPedidoCodAmazonCodPedido_Precio");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.Cantidad, e.CodigoPaquete, e.CodigoAmazon, e.CodigoPedido }, "IDX_Pedido_CodEstadoPedidoCantidadCodPaqueteCodAmanozCodPedido");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.CodigoAmazon, e.FechaDeOrden, e.CodigoPedido }, "IDX_Pedido_CodEstadoPedidoCodAmazonFechaDeOrdenCodPedido_PrecioWebsite");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.CodigoAmazon }, "IDX_Pedido_CodEstadoPedidoCodAmazon_CodPedidoFechaDeOrdenCantidad");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.CodigoEmbarque, e.Cantidad, e.CodigoPedido, e.CodigoAmazon }, "IDX_Pedido_CodEstadoPedidoCodEmbarqueCantidaCodPedidoCodAmazon_CodDeRastreo");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.CodigoPaquete, e.OrdenDeAmazon, e.CodigoDeRastreo, e.CodigoPedido, e.CodigoAmazon }, "IDX_Pedido_CodEstadoPedidoCodPaqueteOrdenAmazonCodRastreoCodPedidoCodAmazon");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_Pedido_CodEstadoPedido_CorreoCodDeRastreo");

            entity.HasIndex(e => new { e.CodigoPaquete, e.CodigoAmazon, e.CodigoEstadoPedido, e.CodigoPedido, e.NombreEnvio, e.ZipDeEnvio, e.OrdenDeAmazon }, "IDX_Pedido_CodPaqueteCodAmazonCodEstadoPedidoCodPedidoCodPedidoNombreEnvioZipDeEnvioOrdenDeAmazon_CodDeRastreo");

            entity.HasIndex(e => new { e.CodigoAmazon, e.FechaDeOrden, e.CodigoEstadoPedido }, "IDX_Pedido_CodigoAmanozFechaDeOrdenCodigoEstadoPedido");

            entity.HasIndex(e => e.CodigoAmazon, "IDX_Pedido_CodigoAmazon");

            entity.HasIndex(e => new { e.CodigoEmbarque, e.Warehouse }, "IDX_Pedido_CodigoEmbarqueWarehouse_CodigoAmazon");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.Cantidad }, "IDX_Pedido_CodigoEstadoPedidoCantidad_FechaDeOrdenPrecioCorreoCodigoEmbarqueMontoArancel");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.Cantidad }, "IDX_Pedido_CodigoEstadoPedidoCantidad_FechaDeOrdenPrecioCorreoMontoArancel");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.CodigoEmbarque }, "IDX_Pedido_CodigoEstadoPedidoCodigoEmbarque");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.CodigoImportador }, "IDX_Pedido_CodigoEstadoPedidoCodigoImportador_FechaDeEnvio");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.FechaIngreso }, "IDX_Pedido_CodigoEstadoPedidoFechaIngreso");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.Notificacion }, "IDX_Pedido_CodigoEstadoPedidoNotificacion_CodigoAmazon");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_Pedido_CodigoEstadoPedido_CodigoAmazonCantidadCIFAduana");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_Pedido_CodigoEstadoPedido_CodigoPaquete");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_Pedido_CodigoEstadoPedido_FechaDeOrdenCodigoAmazon");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_Pedido_CodigoEstadoPedido_OrdenDeAmazonCantidadImpuestoImpuestoReembolsado");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_Pedido_CodigoEstadoPedido_OrdenDeAmazonTarjetaCorreoImpuestoReembolsado");

            entity.HasIndex(e => e.CodigoEstadoPedido, "IDX_Pedido_CodigoEstadoPedido_PrecioCantidadCodigoderastreo");

            entity.HasIndex(e => new { e.CodigoImportador, e.Cantidad }, "IDX_Pedido_CodigoImportadoCantidad_FechaDeOrdenOrdenDeAmazonNombreProductoCodigoAmazonVendedorPrecioCorreo");

            entity.HasIndex(e => e.CodigoImportador, "IDX_Pedido_CodigoImportador");

            entity.HasIndex(e => new { e.CodigoPaquete, e.CodigoEstadoPedido }, "IDX_Pedido_CodigoPaqueteCodigoEstadoPedido");

            entity.HasIndex(e => e.CodigoPaqueteReclamado, "IDX_Pedido_CodigoPaqueteReclamado_CodigoAmazonPrecioCantidadCodigoDeRastreoObservacionesCodigoEstadoPedidoAnterior");

            entity.HasIndex(e => new { e.CodigoPedido, e.CodigoEstadoPedido }, "IDX_Pedido_CodigoPedidoCodigoEstadoPedido");

            entity.HasIndex(e => e.CodigoPolizaContableImpuestoCobrado, "IDX_Pedido_CodigoPolizaContableImpuestoCobrado");

            entity.HasIndex(e => e.CodigoPolizaContableMercaderiaEnTransito, "IDX_Pedido_CodigoPolizaInventarioArancel");

            entity.HasIndex(e => e.CodigoPolizaInventarioMercaderia, "IDX_Pedido_CodigoPolizaInventarioMercaderia");

            entity.HasIndex(e => new { e.Correo, e.CodigoEstadoPedido, e.Cantidad }, "IDX_Pedido_CorreoCodigoEstadoPedidoCantidad_FechaDeOrdenPrecioCodigoEmbarqueMontoArancel");

            entity.HasIndex(e => new { e.Correo, e.FechaDeOrden, e.Tarjeta, e.CodigoEstadoPedido }, "IDX_Pedido_CorreoFechaDeOrdenTarjetaCodigoEstadoPedido_OrdenDeAmazonCodigoAmazonCodigoDeRastreoMontoTotalCodigoPaquete");

            entity.HasIndex(e => new { e.FechaDeOrden, e.CodigoPaquete, e.Correo, e.CodigoEstadoPedido, e.CodigoPedido, e.CodigoAmazon, e.Tarjeta }, "IDX_Pedido_FechaDeOrdenCodPaqueteCorreoCodEstadoPedidoCodPedidoCodAmazonTarjeta_MontoTotal");

            entity.HasIndex(e => new { e.FechaDeOrden, e.Tarjeta, e.CodigoEstadoPedido, e.Impuesto }, "IDX_Pedido_FechaDeOrdenTarjetaCodigoEstadoPedidoImpuesto_OrdenDeAmazonCodigoAmazonCorreoCodigoDeRastreoCodigoPaquete");

            entity.HasIndex(e => new { e.ImpuestoReembolsado, e.CodigoEstadoPedido, e.Impuesto }, "IDX_Pedido_ImpuestoReembolsadoCodigoEstadoPedidoImpuesto_FechaDeOrdenOrdenDeAmazonCodigoAmazon");

            entity.HasIndex(e => new { e.ImpuestoReembolsado, e.CodigoEstadoPedido, e.Impuesto }, "IDX_Pedido_ImpuestoReembolsadoCodigoEstadoPedidoImpuesto_OrdenDeAmazonCantidad");

            entity.HasIndex(e => new { e.NombreEnvio, e.ZipDeEnvio, e.CodigoPaquete, e.CodigoEstadoPedido }, "IDX_Pedido_NombreEnvioZipDeEnvioCodPaqueteCodEstadoPedido_OrdenDeAmazonCodAmazonCodDeRastreo");

            entity.HasIndex(e => e.Notificacion, "IDX_Pedido_Notificacion_CodigoAmazon");

            entity.HasIndex(e => new { e.OrdenDeAmazon, e.Cantidad, e.Precio, e.MontoTotal, e.CodigoEstadoPedido, e.EstadoDeLaOrden, e.Impuesto, e.FechaDeOrden }, "IDX_Pedido_OrdendeamazonCantidadPrecioMontoTotalCodEstadoPedidoImpuestoFechaDeOrden");

            entity.HasIndex(e => new { e.OrdenDeAmazon, e.Correo }, "IDX_Pedido_OrdendeamazonCorreo");

            entity.HasIndex(e => new { e.Precio, e.Cantidad, e.EstadoDeLaOrden, e.MontoTotal, e.CodigoEstadoPedido }, "IDX_Pedido_PrecioCantEstOrdenMontTotalCodEstPed_FecOrdenOrdenAmazonImpuesto");

            entity.HasIndex(e => new { e.Preordenado, e.CodigoEstadoPedido }, "IDX_Pedido_PreordenadoCodigoEstadoPedido_FechaDeOrdenCodigoAmazonPrecioCantidadReservado");

            entity.HasIndex(e => new { e.OrdenDeAmazon, e.UrlOrden }, "IDX_pedido_OrdenDeamazonUrlOrden").IsDescending(false, true);

            entity.HasIndex(e => e.CodigoPedido, "IX_Pedido_CodigoAmazon");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.Cifaduana, e.Precio, e.Cantidad }, "Pedido_CodigoEstadoPedidoCIFAduanaPrecioCantidad");

            entity.HasIndex(e => new { e.CodigoPaquete, e.CodigoEstadoPedido }, "Pedido_CodigoPaqueteCodigoEstadoPedido_OrdenDeAmazonCorreoDireccion1EnvioCodigoDeRastreoCodigoImportador");

            entity.HasIndex(e => new { e.CodigoPedido, e.CodigoAmazon, e.CodigoPaquete }, "_dta_index_Pedido_6_999671396__K1_K6_K37_2_3_9_10_11_14_16_23_25_26_27_29_30_31_33_44_47");

            entity.HasIndex(e => new { e.CodigoEstadoPedido, e.Correo, e.Cantidad, e.CodigoPedido, e.EstadoDeLaOrden, e.CodigoDeRastreo }, "_dta_index_Pedido_6_999671396__K26_K14_K11_K1_K22_K23_2_35");

            entity.HasIndex(e => new { e.OrdenDeAmazon, e.CodigoAmazon, e.CodigoPedido, e.CodigoEstadoPedido, e.Modificado }, "_dta_index_Pedido_6_999671396__K3_K6_K1_K26_K42");

            entity.HasIndex(e => new { e.CodigoAmazon, e.CodigoPedido, e.CodigoPaquete }, "_dta_index_Pedido_6_999671396__K6_K1_K37_2_3_9_10_11_14_16_23_25_26_27_29_30_31_33_44_47");

            entity.HasIndex(e => new { e.CodigoAmazon, e.CodigoEstadoPedido, e.CodigoPedido, e.FechaDeOrden }, "_dta_index_Pedido_6_999671396__K6_K26_K1_K2_10_11");

            entity.HasIndex(e => new { e.CodigoAmazon, e.OrdenDeAmazon, e.CodigoPedido, e.CodigoEstadoPedido, e.Modificado }, "_dta_index_Pedido_6_999671396__K6_K3_K1_K26_K42");

            entity.Property(e => e.CodigoPedido).ValueGeneratedNever();
            entity.Property(e => e.Cifaduana)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("CIFAduana");
            entity.Property(e => e.CiudadDeEnvio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodigoAmazon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodigoDeRastreo)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.CodigoEmbarque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Condicion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion1Envio)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.Direccion2Envio)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.EstadoDeEnvio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoDeLaOrden)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaDeEnvio).HasColumnType("datetime");
            entity.Property(e => e.FechaDeLanzamiento).HasColumnType("datetime");
            entity.Property(e => e.FechaDeOrden).HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Impuesto).HasColumnType("money");
            entity.Property(e => e.ImpuestoReembolsado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Marca)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MontoArancel).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoFlete).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MontoIVA");
            entity.Property(e => e.MontoReembolsado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoTotal).HasColumnType("money");
            entity.Property(e => e.NombreEnvio)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2500)
                .IsUnicode(false);
            entity.Property(e => e.OrdenDeAmazon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrdenDeCompra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Precio).HasColumnType("money");
            entity.Property(e => e.Tarjeta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoDeProducto)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.Transportista)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.UrlOrden)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Vendedor)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.Warehouse)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ZipDeEnvio)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoAmazonNavigation).WithMany(p => p.Pedidos)
                .HasPrincipalKey(p => p.CodigoAmazon)
                .HasForeignKey(d => d.CodigoAmazon)
                .HasConstraintName("FK_Pedido_Producto");

            entity.HasOne(d => d.CodigoCuentaNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.CodigoCuenta)
                .HasConstraintName("FK_Pedido_CodigoCuenta");

            entity.HasOne(d => d.CodigoEmbarqueNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.CodigoEmbarque)
                .HasConstraintName("FK_Pedido_Embarque");

            entity.HasOne(d => d.CodigoEstadoPedidoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.CodigoEstadoPedido)
                .HasConstraintName("FK__Pedido__CodigoEs__5E4C67C9");

            entity.HasOne(d => d.CodigoPaqueteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.CodigoPaquete)
                .HasConstraintName("FK_Pedido_Paquete");

            entity.HasOne(d => d.CodigoPaqueteReclamadoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.CodigoPaqueteReclamado)
                .HasConstraintName("FK__Pedido__CodigoPa__51FE6D74");

            entity.HasOne(d => d.CodigoPolizaContableImpuestoCobradoNavigation).WithMany(p => p.PedidoCodigoPolizaContableImpuestoCobradoNavigations)
                .HasForeignKey(d => d.CodigoPolizaContableImpuestoCobrado)
                .HasConstraintName("FK_Pedido_CodigoPolizaContable_CodigoPolizaContableImpuestoCobrado");

            entity.HasOne(d => d.CodigoPolizaContableMercaderiaEnTransitoNavigation).WithMany(p => p.PedidoCodigoPolizaContableMercaderiaEnTransitoNavigations)
                .HasForeignKey(d => d.CodigoPolizaContableMercaderiaEnTransito)
                .HasConstraintName("FK_InventarioArancel");

            entity.HasOne(d => d.CodigoPolizaInventarioMercaderiaNavigation).WithMany(p => p.PedidoCodigoPolizaInventarioMercaderiaNavigations)
                .HasForeignKey(d => d.CodigoPolizaInventarioMercaderia)
                .HasConstraintName("FK_InventarioMercaderia");

            entity.HasOne(d => d.CodigoUsuarioAplicacionExternaNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.CodigoUsuarioAplicacionExterna)
                .HasConstraintName("FK_Pedido_CodigoUsuarioAplicacionExterna");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK__Pedido__CodigoUs__3621A83A");

            entity.HasOne(d => d.CorreoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.Correo)
                .HasConstraintName("FK_Pedido_CuentaDeCompra");
        });

        modelBuilder.Entity<Penalizacion>(entity =>
        {
            entity.HasKey(e => e.CodigoPenalizacion).HasName("PK__Penaliza__B749EDAF7DCDAAA2");

            entity.ToTable("Penalizacion");

            entity.Property(e => e.CodigoPenalizacion).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PerfilDeImpresion>(entity =>
        {
            entity.HasKey(e => e.CodigoPerfilDeImpresion);

            entity.ToTable("PerfilDeImpresion");

            entity.Property(e => e.NombreImpresora)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PlantillaCorreo>(entity =>
        {
            entity.HasKey(e => e.CodigoPlantillaCorreo).HasName("PK__Plantill__578896A4BC15C5A7");

            entity.ToTable("PlantillaCorreo");

            entity.Property(e => e.CodigoUsuarioInactivo).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.CodigoUsuarioModificacion).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Contenido).HasColumnType("text");
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaInactivo)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacion)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.PlantillaCorreoCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlantillaCorreo_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioInactivoNavigation).WithMany(p => p.PlantillaCorreoCodigoUsuarioInactivoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioInactivo)
                .HasConstraintName("FK_PlantillaCorreo_CodigoUsuarioInactivo");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.PlantillaCorreoCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_PlantillaCorreo_CodigoUsuarioModificacion");
        });

        modelBuilder.Entity<PlataformaAnuncioExterno>(entity =>
        {
            entity.HasKey(e => e.CodigoPlataformaAnuncioExterno).HasName("PK__Platafor__11FC7485DF1CC1FC");

            entity.ToTable("PlataformaAnuncioExterno");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Plaza>(entity =>
        {
            entity.HasKey(e => e.CodigoPlaza).HasName("PK__Plaza__8EEC4BD2FE8F5FBD");

            entity.ToTable("Plaza");

            entity.Property(e => e.CodigoPlaza).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(3500)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEstado).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModifica).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.PlazaCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Plaza_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioEstadoNavigation).WithMany(p => p.PlazaCodigoUsuarioEstadoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEstado)
                .HasConstraintName("FK_Plaza_CodigoUsuarioEstado");

            entity.HasOne(d => d.CodigoUsuarioModificaNavigation).WithMany(p => p.PlazaCodigoUsuarioModificaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModifica)
                .HasConstraintName("FK_Plaza_CodigoUsuarioModifica");
        });

        modelBuilder.Entity<PolizaContable>(entity =>
        {
            entity.HasKey(e => e.CodigoPolizaContable).HasName("PK__PolizaCo__70B388BF29E1C839");

            entity.ToTable("PolizaContable");

            entity.HasIndex(e => new { e.CodigoEscenarioContable, e.CodigoPolizaContable, e.Fecha }, "IDX_PolizaContable_CodEscenarioContableCodPolizaContableFecha");

            entity.HasIndex(e => e.CodigoCierreContable, "IDX_PolizaContable_CodigoCierreContable");

            entity.HasIndex(e => e.CodigoEscenarioContable, "IDX_PolizaContable_CodigoEscenarioContable_Fecha");

            entity.HasIndex(e => e.Fecha, "IDX_PolizaContable_Fecha_CodigoEscenarioContable");

            entity.HasIndex(e => new { e.CodigoEscenarioContable, e.CodigoPolizaContable, e.CodigoCierreContable }, "_dta_index_PolizaContable_CodigoEscenarioContable_CodigoPolizaContable_CodigoCierreContable");

            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CodigoCierreContableNavigation).WithMany(p => p.PolizaContables)
                .HasForeignKey(d => d.CodigoCierreContable)
                .HasConstraintName("FK_POLIZACONTABLE_CIERRECONTABLE");

            entity.HasOne(d => d.CodigoEscenarioContableNavigation).WithMany(p => p.PolizaContables)
                .HasForeignKey(d => d.CodigoEscenarioContable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_escenarioContable");
        });

        modelBuilder.Entity<PolizaContableBitacora>(entity =>
        {
            entity.HasKey(e => e.CodigoBitacora).HasName("pk_PolizaContableBitacora");

            entity.ToTable("PolizaContableBitacora");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FhIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fh_ingreso");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.PolizaContableBitacoras)
                .HasForeignKey(d => d.CodigoFactura)
                .HasConstraintName("FK_PolizaContableCuentaContable_CodigoFactura");

            entity.HasOne(d => d.CodigoGastoNavigation).WithMany(p => p.PolizaContableBitacoras)
                .HasForeignKey(d => d.CodigoGasto)
                .HasConstraintName("FK_PolizaContableCuentaContable_CodigoGasto");

            entity.HasOne(d => d.CodigoNotaContableNavigation).WithMany(p => p.PolizaContableBitacoras)
                .HasForeignKey(d => d.CodigoNotaContable)
                .HasConstraintName("FK_PolizaContableCuentaContable_CodigoNotaContable");

            entity.HasOne(d => d.CodigoPaqueteNavigation).WithMany(p => p.PolizaContableBitacoras)
                .HasForeignKey(d => d.CodigoPaquete)
                .HasConstraintName("FK_PolizaContableCuentaContable_CodigoPaquete");

            entity.HasOne(d => d.CodigoPedidoNavigation).WithMany(p => p.PolizaContableBitacoras)
                .HasForeignKey(d => d.CodigoPedido)
                .HasConstraintName("FK_PolizaContableCuentaContable_CodigoPedido");

            entity.HasOne(d => d.CodigoPolizaContableNavigation).WithMany(p => p.PolizaContableBitacoras)
                .HasForeignKey(d => d.CodigoPolizaContable)
                .HasConstraintName("FK_PolizaContableCuentaContable_CodigoPolizaContable");

            entity.HasOne(d => d.CodigoTipoEscenarioContableNavigation).WithMany(p => p.PolizaContableBitacoras)
                .HasForeignKey(d => d.CodigoTipoEscenarioContable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_TipoEscenario");

            entity.HasOne(d => d.CodigoTransaccionNavigation).WithMany(p => p.PolizaContableBitacoras)
                .HasForeignKey(d => d.CodigoTransaccion)
                .HasConstraintName("FK_PolizaContableCuentaContable_CodigoTransaccion");
        });

        modelBuilder.Entity<PolizaContableCuentaContable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PolizaContableCuentaContable");

            entity.HasIndex(e => e.CodigoPolizaContable, "IDX_PolizaContableCuentaContable_CodigoPolizaContable_CodigoCuentaContableMontoDebeHaber");

            entity.HasIndex(e => new { e.DebeHaber, e.CodigoPolizaContable, e.CodigoCuentaContable }, "_dta_index_PolizaContableCuentaContable_6_1070664024__K4_K1_K2_3");

            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CodigoCuentaContableNavigation).WithMany()
                .HasForeignKey(d => d.CodigoCuentaContable)
                .HasConstraintName("FK__PolizaCon__Codig__41B951CA");

            entity.HasOne(d => d.CodigoPolizaContableNavigation).WithMany()
                .HasForeignKey(d => d.CodigoPolizaContable)
                .HasConstraintName("FK__PolizaCon__Codig__40C52D91");
        });

        modelBuilder.Entity<PolizaDeImportacion>(entity =>
        {
            entity.HasKey(e => e.CodigoPolizaDeImportacion).HasName("PK__PolizaDe__4CE7F824E716DF3B");

            entity.ToTable("PolizaDeImportacion");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaPolizaDeImportacion).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.NumeroDua)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NumeroDUA");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.PolizaDeImportacionCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PolizaDeImportacion_CodigoUsuario_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.PolizaDeImportacionCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_PolizaDeImportacion_CodigoUsuario_CodigoUsuarioModificacion");
        });

        modelBuilder.Entity<PorcentajeImpuesto>(entity =>
        {
            entity.HasKey(e => e.CodigoPorcentajeImpuesto).HasName("PK__Porcenta__93BD4FBB1FCC2381");

            entity.ToTable("PorcentajeImpuesto");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaInicio).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.RangoMaximo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RangoMinimo).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<PorcentajeRetencionExencion>(entity =>
        {
            entity.HasKey(e => e.CodigoPorcentajeRetencionExencion).HasName("PK__Porcenta__B3FD13228BC44A7F");

            entity.ToTable("PorcentajeRetencionExencion");

            entity.Property(e => e.Porcentaje).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.CodigoRegimenFacturaNavigation).WithMany(p => p.PorcentajeRetencionExencions)
                .HasForeignKey(d => d.CodigoRegimenFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PorcentajeRetencionExencion_CodigoRegimenFactura");
        });

        modelBuilder.Entity<PrecioBitacora>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PrecioBitacora");

            entity.Property(e => e.Fecha)
                .HasComputedColumnSql("(getdate())", false)
                .HasColumnType("datetime");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany()
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodigoProducto_PrecioBitacora");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.CodigoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodigoUsuario_PrecioBitacora");
        });

        modelBuilder.Entity<Preguntum>(entity =>
        {
            entity.HasKey(e => e.CodigoPregunta);

            entity.HasIndex(e => new { e.CodigoEstadoPregunta, e.CodigoPreguntaPrincipal }, "IDX_CodigoEstadoPreguntaCodigoPreguntaPrincipal_FechaNombreCorreoPreguntaRespuestaFechaRespuestaCodigoProductoCodigo");

            entity.HasIndex(e => e.CodigoPreguntaPrincipal, "IDX_CodigoPreguntaPrincipal_Fecha");

            entity.HasIndex(e => e.CodigoProducto, "IDX_CodigoProducto");

            entity.HasIndex(e => new { e.CodigoEstadoPregunta, e.CodigoPreguntaPrincipal }, "IDX_Pregunta_CodEstPregCodPregP_NombreCorreoPregRespFecResCodProCodUsCodvenCodAmCodFac");

            entity.HasIndex(e => new { e.CodigoTipoPregunta, e.CodigoEstadoPregunta }, "IDX_Pregunta_CodTipoCodEstado");

            entity.HasIndex(e => e.CodigoAmazon, "IDX_Pregunta_CodigoAmazon");

            entity.HasIndex(e => e.CodigoFactura, "IDX_Pregunta_CodigoFactura_FechaNombreCorreoPreguntaRespuestaFechaRespuesta");

            entity.HasIndex(e => new { e.CodigoPregunta, e.CodigoPreguntaPrincipal }, "IDX_Pregunta_CodigoPreguntaCodigoPreguntaPrincipal");

            entity.HasIndex(e => new { e.CodigoPreguntaPrincipal, e.Fecha }, "IDX_Pregunta_CodigoPreguntaPrincipal_Fecha");

            entity.HasIndex(e => e.CodigoPregunta, "IDX_Pregunta_CodigoPregunta_FechaNombreCorreoPreguntaRespuestaFechaRespuesta");

            entity.HasIndex(e => new { e.CodigoTipoPregunta, e.CodigoEstadoPregunta, e.CodigoPreguntaPrincipal }, "IDX_Pregunta_CodigoTipoPreguntaCodigoEstadoPreguntaCodigoPreguntaPrincipal_Fecha");

            entity.HasIndex(e => new { e.CodigoVenta, e.CodigoFactura }, "IDX_Pregunta_CodigoVenta_CodigoFactura");

            entity.Property(e => e.CodigoAmazon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRespuesta).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pregunta).IsUnicode(false);
            entity.Property(e => e.Respuesta).IsUnicode(false);

            entity.HasOne(d => d.CodigoEstadoPreguntaNavigation).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.CodigoEstadoPregunta)
                .HasConstraintName("FK__PreguntaT__Codig__66DAC32C");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Pregunta_Producto");

            entity.HasOne(d => d.CodigoTipoPreguntaNavigation).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.CodigoTipoPregunta)
                .HasConstraintName("FK_Pregunta_TipoPregunta");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.Pregunta)
                .HasForeignKey(d => d.CodigoVenta)
                .HasConstraintName("FK_Pregunta_Venta");
        });

        modelBuilder.Entity<Prioridad>(entity =>
        {
            entity.HasKey(e => new { e.CodigoCategoria, e.CodigoPagina });

            entity.ToTable("Prioridad");

            entity.HasIndex(e => new { e.CodigoPagina, e.CodigoCategoria }, "IDX_Prioridad_CodPaginaCodCategoria");

            entity.HasIndex(e => e.CodigoCategoria, "IDX_Prioridad_CodigoCategoria");

            entity.HasIndex(e => e.CodigoPagina, "IDX_Prioridad_CodigoPagina");

            entity.Property(e => e.Aleatorio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoCategoriaNavigation).WithMany(p => p.Prioridads)
                .HasForeignKey(d => d.CodigoCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prioridad_Categoria");

            entity.HasOne(d => d.CodigoPaginaNavigation).WithMany(p => p.Prioridads)
                .HasForeignKey(d => d.CodigoPagina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prioridad_Pagina");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.Prioridads)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .HasConstraintName("FK_Prioridad_CodigoUsuario_CodigoUsuarioCreacion");
        });

        modelBuilder.Entity<Proceso>(entity =>
        {
            entity.HasKey(e => e.CodigoProceso).HasName("PK__Proceso2__34676A5EA5F7F3F0");

            entity.ToTable("proceso");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.CodigoProducto);

            entity.ToTable("Producto");

            entity.HasIndex(e => e.CodigoAmazon, "CK_Producto_CodigoAmazon").IsUnique();

            entity.HasIndex(e => e.CaracteristicasTraducida, "IDX_CaracterisiticasTraducida");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.CodigoProducto }, "IDX_Produco_CodEstableciemientoCodProducto_NombreCodAmazon");

            entity.HasIndex(e => new { e.CodigoCategoria, e.Cantidad, e.Busqueda }, "IDX_ProductoCategoriaCantidadBusqueda");

            entity.HasIndex(e => e.Precio, "IDX_ProductoPrecio");

            entity.HasIndex(e => e.PrecioVigenteAmazon, "IDX_ProductoPrecioVigenteAmazon").IsDescending();

            entity.HasIndex(e => e.Busqueda, "IDX_Producto_Busqueda").IsDescending();

            entity.HasIndex(e => new { e.Busqueda, e.CodigoCategoria, e.Cantidad }, "IDX_Producto_BusquedaCodCategoriaCantidadReservaDisponibleApi").IsDescending(true, false, false);

            entity.HasIndex(e => new { e.Busqueda, e.CodigoProducto, e.Cantidad, e.CodigoCategoria }, "IDX_Producto_BusquedaCodigoProductoCantidadCodigoCategoria_NombreFotoPrecioCantiCodAmfot11fot12fot13ResePrecioVigAmNombreBusq:").IsDescending(true, false, false, false);

            entity.HasIndex(e => new { e.Busqueda, e.CorreoPrecio, e.CodigoProducto, e.Precio, e.PrecioAnterior, e.CodigoCategoria }, "IDX_Producto_BusquedaCorreoPrecioCodProductoPrecioPrecioAnteriorCodCategoria_NombreFotoCodAmanoz");

            entity.HasIndex(e => new { e.Busqueda, e.CorreoPrecio, e.CodigoCategoria, e.Precio, e.PrecioAnterior }, "IDX_Producto_BusquedaCorreoPrecioCodigoCategoriaPrecioAnterior_CodpordutNombreFotoCodAmazon");

            entity.HasIndex(e => e.Cantidad, "IDX_Producto_Cantidad");

            entity.HasIndex(e => new { e.Cantidad, e.Busqueda, e.FechaBusqueda }, "IDX_Producto_CantidadBusquedaFechaBusqueda_DiasEntrega");

            entity.HasIndex(e => new { e.Cantidad, e.Busqueda, e.FechaBusqueda }, "IDX_Producto_Cantidad_Busqueda_FechaBusqueda");

            entity.HasIndex(e => e.Cantidad, "IDX_Producto_Cantidad_CodigoUbicacionBodega");

            entity.HasIndex(e => e.Cantidad, "IDX_Producto_Cantidad_PrecioCodigoAmazoncodigoEstablecimientoPorcentajeComisionPrecioCompra");

            entity.HasIndex(e => new { e.CodigoCategoria, e.Busqueda, e.CodigoProducto }, "IDX_Producto_CategoriaBusquedaProducto");

            entity.HasIndex(e => new { e.CodigoAmazon, e.CodigoReferencia, e.Precio }, "IDX_Producto_CodAmazonCodReferenciaPrecio_CodProdctNombrePrecioCompraNoCompraInventario");

            entity.HasIndex(e => new { e.CodigoAmazon, e.CodigoProducto }, "IDX_Producto_CodAmazon_CodProducto_UPC");

            entity.HasIndex(e => new { e.CodigoCategoria, e.Busqueda }, "IDX_Producto_CodCatBusqueda_NombFotoPrecCantCombinadoReservaPrecVigAmzNombBusqDiasEntrega");

            entity.HasIndex(e => new { e.CodigoCategoria, e.CodigoEstablecimiento }, "IDX_Producto_CodCatCodEstablecimiento_NombreFotoPrecioCantidadCodAmazonReservaPrecioVigenteAmazonNombreBusqBusqDisponibleApi");

            entity.HasIndex(e => new { e.CodigoCategoria, e.Pagina, e.Foto }, "IDX_Producto_CodCatPaginaFoto_NombrePrecioCantidadProximoIn");

            entity.HasIndex(e => new { e.CodigoCategoria, e.Cantidad, e.Busqueda }, "IDX_Producto_CodCategoriaCantidadBusqueda_ReservaDisponibleApi");

            entity.HasIndex(e => new { e.CodigoCategoria, e.Cantidad, e.CodigoProducto, e.CodigoEstablecimiento, e.DisponibleApi, e.Precio, e.Disponibilidad, e.NoConsultarApi }, "IDX_Producto_CodCategoriaCantidadCodProductoCodEstablecimientoDisponibleApiPrecioDisponibilidadNoConsultarAPI");

            entity.HasIndex(e => e.CodigoCategoria, "IDX_Producto_CodCategoria_NombFotoPrecCantCodAmznReservaCodEstPrecVigAmznNombBusqDispApiDiasEnt");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.Cantidad, e.CodigoProducto, e.Upc }, "IDX_Producto_CodEstableciemientoCantidadCodProductoUPC_NombrePrecio");

            entity.HasIndex(e => new { e.CodigoProducto, e.CodigoAmazon }, "IDX_Producto_CodProductoCodAmazon");

            entity.HasIndex(e => new { e.CodigoReferencia, e.CodigoAmazon, e.CodigoProducto, e.Upc }, "IDX_Producto_CodReferenciaCodAmazonCodProductoUPS");

            entity.HasIndex(e => new { e.CodigoReferencia, e.CodigoProducto, e.CodigoAmazon, e.Precio }, "IDX_Producto_CodReferenciaCodProductoCodAmanozPrecio_NombreCantidad,PrecCompraNoCompraInvent");

            entity.HasIndex(e => new { e.CodigoReferencia, e.CodigoProducto, e.CodigoCategoria, e.Busqueda }, "IDX_Producto_CodReferenciaCodProductoCodCategoriaBusqueda_NombrePaginaFotoPrecioCantidadReservaDisponibleApiDiasEntrega");

            entity.HasIndex(e => e.CodigoCategoria, "IDX_Producto_CodigoCategoria");

            entity.HasIndex(e => e.CodigoCategoria, "IDX_Producto_CodigoCategoria_NombreFotoPrecioCantidadCodAmazonProximoIngresoCombinadoReservaBusquedaDisponibleApiDiasEntrega");

            entity.HasIndex(e => e.CodigoCategoria, "IDX_Producto_CodigoCategoria_NombrePaginaCodigoAmazonNodos");

            entity.HasIndex(e => e.CodigoEstablecimiento, "IDX_Producto_CodigoEstablecimiento");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.Cantidad, e.Peso }, "IDX_Producto_CodigoEstablecimientoCantidadPeso");

            entity.HasIndex(e => new { e.CodigoEstablecimiento, e.Cantidad }, "IDX_Producto_CodigoEstablecimientoCantidad_CodigoReferencia");

            entity.HasIndex(e => e.CodigoEstablecimiento, "IDX_Producto_CodigoEstablecimiento_CodigoAmazon");

            entity.HasIndex(e => e.CodigoEstablecimiento, "IDX_Producto_CodigoEstablecimiento_CodigoCategoriaBusquedaDisponibleApiDiasEntrega");

            entity.HasIndex(e => e.CodigoEstablecimiento, "IDX_Producto_CodigoEstablecimiento_CodigoCategoriaNombreFotoPrecioCantidadCodigoAmazonCaracteristicasDescripcionfoto11");

            entity.HasIndex(e => e.CodigoEstablecimiento, "IDX_Producto_CodigoEstablecimiento_DisponibleApiFechaDisponibleApi");

            entity.HasIndex(e => new { e.CodigoProducto, e.CodigoCategoria }, "IDX_Producto_CodigoProductoCodigoCategoria_NombreFoto");

            entity.HasIndex(e => e.CodigoReferencia, "IDX_Producto_CodigoReferencia");

            entity.HasIndex(e => e.CodigoUbicacionBodega, "IDX_Producto_CodigoUbicacionBodega");

            entity.HasIndex(e => e.CodigoUbicacionBodega, "IDX_Producto_CodigoUbicacionBodega_FotoCantidadUPC");

            entity.HasIndex(e => e.CodigoUsuario, "IDX_Producto_CodigoUsuario_VideoFechaCreacion");

            entity.HasIndex(e => e.DescripcionTraducida, "IDX_Producto_DescripcionTraducida");

            entity.HasIndex(e => e.DiasEntrega, "IDX_Producto_DiasEntrega");

            entity.HasIndex(e => e.DisponibleApi, "IDX_Producto_DisponibleAPI");

            entity.HasIndex(e => new { e.DisponibleApi, e.CodigoProducto, e.Busqueda, e.CodigoCategoria }, "IDX_Producto_DisponibleApiCodProductoBusqCodCat_NombreFotoPrecioCantiCodAmfot11fot12fot13ResePrecioVigAmNombreBusq:");

            entity.HasIndex(e => e.DisponibleApi, "IDX_Producto_DisponibleApi_FechaDisponibleApi");

            entity.HasIndex(e => e.FechaBusqueda, "IDX_Producto_FechaBusqueda");

            entity.HasIndex(e => e.Mostrar, "IDX_Producto_Mostrar");

            entity.HasIndex(e => e.NoComprarInventario, "IDX_Producto_NoComprarInventario");

            entity.HasIndex(e => e.Nombre, "IDX_Producto_Nombre");

            entity.HasIndex(e => e.CodigoProducto, "IDX_Producto_NombreBusqueda").IsUnique();

            entity.HasIndex(e => e.CodigoProducto, "IDX_Producto_NombreEnIngles");

            entity.HasIndex(e => e.PrecioNormal, "IDX_Producto_PrecioNormal");

            entity.HasIndex(e => e.Precio, "IDX_Producto_Precio_NombreCantidadCodigoAmazon");

            entity.HasIndex(e => e.Reserva, "IDX_Producto_Reserva");

            entity.HasIndex(e => new { e.Upc, e.CodigoAmazon, e.CodigoProducto }, "IDX_Producto_UPCCodAmazonCodProducto");

            entity.HasIndex(e => new { e.Upc, e.CodigoUbicacionBodega }, "IDX_Producto_UPCCodUbicacionBodega");

            entity.HasIndex(e => e.Upc, "IDX_Producto_UPC_CodProductoCodAmazonCodReferencia");

            entity.HasIndex(e => new { e.Upc, e.CodigoReferencia, e.Cantidad, e.CodigoProducto }, "IDX_Producto_UPC_CodigoReferenciaCantidadCodProducto");

            entity.HasIndex(e => e.Upc, "IDX_Producto_Upc");

            entity.HasIndex(e => e.Busqueda, "IDX_Producto_busqueda_CodigoCategoriaCantidad");

            entity.HasIndex(e => e.CodigoAmazonVariaciones, "IXD_Producto_Variaciones");

            entity.HasIndex(e => e.CodigoEstablecimiento, "Producto_CodigoEstablecimiento_CodigoCategoriaCantidadReservaDisponibleApiFechaDisponibleApi");

            entity.HasIndex(e => new { e.Upc, e.CodigoProducto }, "_dta_index_Producto_6_1132527855__K29_K1");

            entity.HasIndex(e => new { e.CodigoCategoria, e.Cantidad }, "_dta_index_Producto_6_1132527855__K2_K7_28");

            entity.HasIndex(e => e.CodigoUbicacionBodega, "_dta_index_Producto_6_1132527855__K57_29");

            entity.HasIndex(e => new { e.Busqueda, e.Cantidad, e.CodigoProducto, e.Precio, e.CodigoCategoria }, "_dta_index_Producto_6_1132527855__K61D_K7_K1_K6_K2_3_5_30").IsDescending(true, false, false, false, false);

            entity.HasIndex(e => new { e.Busqueda, e.Cantidad, e.CodigoCategoria }, "_dta_index_Producto_6_1132527855__K61_K7_K2_28");

            entity.HasIndex(e => new { e.Cantidad, e.CodigoProducto, e.Busqueda, e.CodigoCategoria }, "_dta_index_Producto_6_1132527855__K7D_K1_K61_K2_3_5_6_8_15_16_17_28_53_60_8066").IsDescending(true, false, false, false);

            entity.HasIndex(e => new { e.CodigoAmazon, e.CodigoProducto }, "_dta_index_Producto_6_1132527855__K8_K1_34");

            entity.Property(e => e.Caracteristicas).IsUnicode(false);
            entity.Property(e => e.CaracteristicasEnIngles).IsUnicode(false);
            entity.Property(e => e.CodigoAmazon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodigoAmazonVariaciones)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReferencia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ColorVariaciones)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.DescripcionEnIngles).IsUnicode(false);
            entity.Property(e => e.FechaBusqueda).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDisponibleApi).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaFin).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaInicio).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificaCategoriaManual).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaPrecio).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUbicacionBodega).HasColumnType("datetime");
            entity.Property(e => e.FechaUsuarioModificaPrecio).HasColumnType("smalldatetime");
            entity.Property(e => e.Foto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Foto11)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto11");
            entity.Property(e => e.Foto12)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto12");
            entity.Property(e => e.Foto13)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto13");
            entity.Property(e => e.Foto21)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto21");
            entity.Property(e => e.Foto22)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto22");
            entity.Property(e => e.Foto23)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto23");
            entity.Property(e => e.Foto31)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto31");
            entity.Property(e => e.Foto32)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto32");
            entity.Property(e => e.Foto33)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto33");
            entity.Property(e => e.Foto41)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto41");
            entity.Property(e => e.Foto42)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto42");
            entity.Property(e => e.Foto43)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto43");
            entity.Property(e => e.NoConsultarApi).HasColumnName("NoConsultarAPI");
            entity.Property(e => e.Nombre)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.NombreEnIngles)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.NombreRobot)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Pagina)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeComision).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeComisionPedido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioAnterior).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioNormal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PrecioProveedor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioSugerido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProximoIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.Revision)
                .HasMaxLength(750)
                .IsUnicode(false);
            entity.Property(e => e.Size)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.Upc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UPC");
            entity.Property(e => e.Video)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("video");

            entity.HasOne(d => d.CodigoCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CodigoCategoria)
                .HasConstraintName("FK_Producto_Categoria");

            entity.HasOne(d => d.CodigoContenidoAdicionalNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CodigoContenidoAdicional)
                .HasConstraintName("FK_Producto_ContenidoAdicional");

            entity.HasOne(d => d.CodigoUbicacionBodegaNavigation).WithMany(p => p.ProductoCodigoUbicacionBodegaNavigations)
                .HasForeignKey(d => d.CodigoUbicacionBodega)
                .HasConstraintName("FK_Producto_UbicacionBodega");

            entity.HasOne(d => d.CodigoUbicacionBodegaAnteriorNavigation).WithMany(p => p.ProductoCodigoUbicacionBodegaAnteriorNavigations)
                .HasForeignKey(d => d.CodigoUbicacionBodegaAnterior)
                .HasConstraintName("FK_Producto_UbicacionBodegaAnterior");

            entity.HasOne(d => d.CodigoUbicacionDespachoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CodigoUbicacionDespacho)
                .HasConstraintName("FK__Producto__Codigo__295966DE");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.ProductoCodigoUsuarioNavigations)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_Producto_Usuario");

            entity.HasOne(d => d.CodigoUsuarioModificaCategoriaManualNavigation).WithMany(p => p.ProductoCodigoUsuarioModificaCategoriaManualNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificaCategoriaManual)
                .HasConstraintName("FK_Producto_CodigoUsuarioModificaCategoriaManual");

            entity.HasOne(d => d.CodigoUsuarioModificaPrecioNavigation).WithMany(p => p.ProductoCodigoUsuarioModificaPrecioNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificaPrecio)
                .HasConstraintName("FK_CodigoUsuarioModificaPrecio");

            entity.HasOne(d => d.CodigoUsuarioUbicacionBodegaNavigation).WithMany(p => p.ProductoCodigoUsuarioUbicacionBodegaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioUbicacionBodega)
                .HasConstraintName("FK_Usuario_CodigoUsuario_CodigoUsuarioUbicacionBodega");

            entity.HasMany(d => d.CodigoProductoRelacionados).WithMany(p => p.CodigoProductos)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoOpcional",
                    r => r.HasOne<Producto>().WithMany()
                        .HasForeignKey("CodigoProductoRelacionado")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoOpcional_ProductoRelacionado"),
                    l => l.HasOne<Producto>().WithMany()
                        .HasForeignKey("CodigoProducto")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoOpcional_Producto"),
                    j =>
                    {
                        j.HasKey("CodigoProducto", "CodigoProductoRelacionado").HasName("PK_Producto_Opcional");
                        j.ToTable("ProductoOpcional");
                    });

            entity.HasMany(d => d.CodigoProductos).WithMany(p => p.CodigoProductoRelacionados)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoOpcional",
                    r => r.HasOne<Producto>().WithMany()
                        .HasForeignKey("CodigoProducto")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoOpcional_Producto"),
                    l => l.HasOne<Producto>().WithMany()
                        .HasForeignKey("CodigoProductoRelacionado")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoOpcional_ProductoRelacionado"),
                    j =>
                    {
                        j.HasKey("CodigoProducto", "CodigoProductoRelacionado").HasName("PK_Producto_Opcional");
                        j.ToTable("ProductoOpcional");
                    });

            entity.HasMany(d => d.CodigoValorAtributos).WithMany(p => p.CodigoProductos)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoValorAtributo",
                    r => r.HasOne<ValorAtributo>().WithMany()
                        .HasForeignKey("CodigoValorAtributo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ValorAtributo_ProductoValorAtributo"),
                    l => l.HasOne<Producto>().WithMany()
                        .HasForeignKey("CodigoProducto")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Producto_ProductoValorAtributo"),
                    j =>
                    {
                        j.HasKey("CodigoProducto", "CodigoValorAtributo").HasName("PK_ProductoAtributo");
                        j.ToTable("ProductoValorAtributo");
                    });
        });

        modelBuilder.Entity<ProductoCaby>(entity =>
        {
            entity.HasKey(e => new { e.CodigoCaby, e.CodigoProducto }).HasName("PK_CodigoCaby_CodigoProducto");

            entity.ToTable("ProductoCaby");

            entity.HasIndex(e => e.CodigoProducto, "UQ__Producto__785B009FEAAC4096").IsUnique();

            entity.Property(e => e.FechaUsuarioAsociaCaby).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioModificaCaby).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoCabyNavigation).WithMany(p => p.ProductoCabies)
                .HasForeignKey(d => d.CodigoCaby)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoCaby_CodigoCaby");

            entity.HasOne(d => d.CodigoProductoNavigation).WithOne(p => p.ProductoCaby)
                .HasForeignKey<ProductoCaby>(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoCaby_CodigoProducto");

            entity.HasOne(d => d.CodigoUsuarioAsociaCabyNavigation).WithMany(p => p.ProductoCabyCodigoUsuarioAsociaCabyNavigations)
                .HasForeignKey(d => d.CodigoUsuarioAsociaCaby)
                .HasConstraintName("FK_ProductoCaby_CodigoUsuarioAsociaCaby");

            entity.HasOne(d => d.CodigoUsuarioModificaCabyNavigation).WithMany(p => p.ProductoCabyCodigoUsuarioModificaCabyNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificaCaby)
                .HasConstraintName("FK_ProductoCaby_CodigoUsuarioModificaCaby");
        });

        modelBuilder.Entity<ProductoCombinado>(entity =>
        {
            entity.HasKey(e => new { e.CodigoProducto, e.CodigoProductoCombinado }).HasName("PK_Producto_Combinado");

            entity.ToTable("ProductoCombinado");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.ProductoCombinados)
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoCombinado_Producto");
        });

        modelBuilder.Entity<ProductoElementoRobot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductoElementoRobot");

            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoElementoRobotNavigation).WithMany()
                .HasForeignKey(d => d.CodigoElementoRobot)
                .HasConstraintName("FK__ProductoE__Codig__0CA5D9DE");
        });

        modelBuilder.Entity<ProductoFacebook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductoFacebook");
        });

        modelBuilder.Entity<ProductoHistorico>(entity =>
        {
            entity.HasKey(e => e.CodigoProducto);

            entity.ToTable("ProductoHistorico");

            entity.Property(e => e.CodigoProducto).ValueGeneratedNever();
            entity.Property(e => e.Caracteristicas).IsUnicode(false);
            entity.Property(e => e.CaracteristicasEnIngles).IsUnicode(false);
            entity.Property(e => e.CodigoAmazon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodigoAmazonVariaciones)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReferencia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ColorVariaciones)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.DescripcionEnIngles).IsUnicode(false);
            entity.Property(e => e.FechaAnuncio).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaBusqueda).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDisponibleApi).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaFin).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaInicio).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaPrecio).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUbicacionBodega).HasColumnType("datetime");
            entity.Property(e => e.FechaUsuarioModificaPrecio).HasColumnType("smalldatetime");
            entity.Property(e => e.Foto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Foto11)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto11");
            entity.Property(e => e.Foto12)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto12");
            entity.Property(e => e.Foto13)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto13");
            entity.Property(e => e.Foto21)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto21");
            entity.Property(e => e.Foto22)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto22");
            entity.Property(e => e.Foto23)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto23");
            entity.Property(e => e.Foto31)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto31");
            entity.Property(e => e.Foto32)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto32");
            entity.Property(e => e.Foto33)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto33");
            entity.Property(e => e.Foto41)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto41");
            entity.Property(e => e.Foto42)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto42");
            entity.Property(e => e.Foto43)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("foto43");
            entity.Property(e => e.GrupoStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NoConsultarApi).HasColumnName("NoConsultarAPI");
            entity.Property(e => e.Nombre)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.NombreBusqueda)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.NombreEnIngles)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.NombreRobot)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Pagina)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeComision).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeComisionPedido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioAnterior).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioNormal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PrecioProveedor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioSugerido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProximoIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.Revision)
                .HasMaxLength(750)
                .IsUnicode(false);
            entity.Property(e => e.Size)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Upc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UPC");
            entity.Property(e => e.Video)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("video");
        });

        modelBuilder.Entity<ProductoNoVigente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductoNoVigente");

            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Resultado)
                .HasMaxLength(512)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductoServicio>(entity =>
        {
            entity.HasKey(e => new { e.CodigoProducto, e.CodigoServicio }).HasName("PK_Producto_servicio_CodigoProducto_CodigoServicio");

            entity.ToTable("ProductoServicio");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.ProductoServicios)
                .HasForeignKey(d => d.CodigoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoServicio_CodigoProducto");

            entity.HasOne(d => d.CodigoServicioNavigation).WithMany(p => p.ProductoServicios)
                .HasForeignKey(d => d.CodigoServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoServicio_CodigoServicio");
        });

        modelBuilder.Entity<Promocion>(entity =>
        {
            entity.HasKey(e => e.CodigoPromocion).HasName("PK__Promocio__6121574A32AB8735");

            entity.ToTable("Promocion");

            entity.HasIndex(e => new { e.CodigoEstadoPromocion, e.PrecioFinalizacion }, "IDX_Promocion_CodEstPromPrecioFinalizacion_CodProductoFecha");

            entity.HasIndex(e => new { e.CodigoProducto, e.PrecioFinalizacion, e.HorasCorreo }, "IDX_Promocion_CodProdPrecFinalizacionHorasCorreo");

            entity.HasIndex(e => e.CodigoTipoPromocion, "IDX_Promocion_CodigoTipoPromocion_CodigoProductoFecha");

            entity.HasIndex(e => e.CodigoVenta, "IDX_Promocion_CodigoVenta");

            entity.HasIndex(e => new { e.Fecha, e.CodigoEstadoPromocion, e.PrecioFinalizacion }, "IDX_Promocion_FechaCodEstadoPromocionPrecioFinalizacion");

            entity.Property(e => e.CodigoVenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Ganador)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Hora)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.NombreEnIngles)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioFinalizacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Titulo)
                .HasMaxLength(700)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoEstadoPromocionNavigation).WithMany(p => p.Promocions)
                .HasForeignKey(d => d.CodigoEstadoPromocion)
                .HasConstraintName("FK_Promocion_EstadoPromocion");

            entity.HasOne(d => d.CodigoTipoPromocionNavigation).WithMany(p => p.Promocions).HasForeignKey(d => d.CodigoTipoPromocion);

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.PromocionCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .HasConstraintName("FK_Promocion_Usuario_Creacion");

            entity.HasOne(d => d.CodigoUsuarioFinalizaNavigation).WithMany(p => p.PromocionCodigoUsuarioFinalizaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioFinaliza)
                .HasConstraintName("FK_Promocion_CodigoUsuario_CodigoUsuarioFinaliza");

            entity.HasOne(d => d.CodigoUsuarioModificaNavigation).WithMany(p => p.PromocionCodigoUsuarioModificaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModifica)
                .HasConstraintName("FK_Promocion_Usuario_Modificacion");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.CodigoProveedor).HasName("PK__Proveedo__137549F5252734BD");

            entity.ToTable("Proveedor");

            entity.HasIndex(e => e.Nit, "IDX_Proveedor_NIT");

            entity.Property(e => e.AgenteRetenedor).HasDefaultValue(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaUsuarioModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioRegistro).HasColumnType("smalldatetime");
            entity.Property(e => e.Nit)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(700)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoEstablecimientoNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.CodigoEstablecimiento)
                .HasConstraintName("FK_Proveedor_Establecimiento");

            entity.HasOne(d => d.CodigoRegimenNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.CodigoRegimen)
                .HasConstraintName("FK_CodigoRegimen");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.ProveedorCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_Proveedor_CodigoUsuarioModificacion");

            entity.HasOne(d => d.CodigoUsuarioRegistroNavigation).WithMany(p => p.ProveedorCodigoUsuarioRegistroNavigations)
                .HasForeignKey(d => d.CodigoUsuarioRegistro)
                .HasConstraintName("FK_Proveedor_CodigoUsuarioRegistro");
        });

        modelBuilder.Entity<RazonAnulacionVentum>(entity =>
        {
            entity.HasKey(e => e.CodigoRazonAnulacionVenta).HasName("PK__RazonAnu__4625E0167962750B");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEliminacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.RazonAnulacionVentumCodigoUsuarioCreacionNavigations).HasForeignKey(d => d.CodigoUsuarioCreacion);

            entity.HasOne(d => d.CodigoUsuarioEliminacionNavigation).WithMany(p => p.RazonAnulacionVentumCodigoUsuarioEliminacionNavigations).HasForeignKey(d => d.CodigoUsuarioEliminacion);

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.RazonAnulacionVentumCodigoUsuarioModificacionNavigations).HasForeignKey(d => d.CodigoUsuarioModificacion);
        });

        modelBuilder.Entity<RedCrediticium>(entity =>
        {
            entity.HasKey(e => e.CodigoRedCrediticia);

            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PermitirCobroDeUnaCuota).HasDefaultValue(false);
            entity.Property(e => e.PermitirCobroDeVariasCuotas).HasDefaultValue(false);

            entity.HasOne(d => d.CodigoCuentaNavigation).WithMany(p => p.RedCrediticia)
                .HasForeignKey(d => d.CodigoCuenta)
                .HasConstraintName("FK_RedCrediticia_CuentaDeposito");

            entity.HasOne(d => d.CodigoCuentaPorCobrarNavigation).WithMany(p => p.RedCrediticia)
                .HasForeignKey(d => d.CodigoCuentaPorCobrar)
                .HasConstraintName("FK_RedCrediticia_CuentaPorCobrar");
        });

        modelBuilder.Entity<Regiman>(entity =>
        {
            entity.HasKey(e => e.CodigoRegimen);

            entity.Property(e => e.Nombre)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RegimenFactura>(entity =>
        {
            entity.HasKey(e => e.CodigoRegimenFactura).HasName("PK__RegimenF__EC28ED31D38B9FBA");

            entity.ToTable("RegimenFactura");

            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Resena>(entity =>
        {
            entity.HasKey(e => e.CodigoResena);

            entity.ToTable("Resena");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Resolucion>(entity =>
        {
            entity.HasKey(e => e.CodigoResolucion);

            entity.ToTable("Resolucion");

            entity.Property(e => e.FechaResolucion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.Resolucion1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Resolucion");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoClaseDocumentoNavigation).WithMany(p => p.Resolucions)
                .HasForeignKey(d => d.CodigoClaseDocumento)
                .HasConstraintName("FK_Resolucion_ClaseDocumenot");

            entity.HasOne(d => d.CodigoTipoRegimenFacturacionNavigation).WithMany(p => p.Resolucions)
                .HasForeignKey(d => d.CodigoTipoRegimenFacturacion)
                .HasConstraintName("FK_Resolucion_TipoRegimenFacturacion");
        });

        modelBuilder.Entity<RespuestaComun>(entity =>
        {
            entity.HasKey(e => e.CodigoRespuestaComun).HasName("PK__Respuest__9B25A20C73852659");

            entity.ToTable("RespuestaComun");

            entity.Property(e => e.CodigoRespuestaComun).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Texto).IsUnicode(false);
        });

        modelBuilder.Entity<RevisionProducto>(entity =>
        {
            entity.HasKey(e => e.CodigoRevisionProducto).HasName("PK__Revision__FA50C34685905289");

            entity.ToTable("RevisionProducto");

            entity.HasIndex(e => new { e.CodigoProducto, e.CodigoEstadoRevision }, "IDX_RevisionProducto_CodigoProductoCodigoEstadoRevision");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(750)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoEstadoRevisionNavigation).WithMany(p => p.RevisionProductos)
                .HasForeignKey(d => d.CodigoEstadoRevision)
                .HasConstraintName("FK_RevisionProducto_EstadoRevision");

            entity.HasOne(d => d.CodigoPenalizacionNavigation).WithMany(p => p.RevisionProductos)
                .HasForeignKey(d => d.CodigoPenalizacion)
                .HasConstraintName("FK_RevisionProducto_Penalizacion");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.RevisionProductos)
                .HasForeignKey(d => d.CodigoProducto)
                .HasConstraintName("FK_RevisionProducto_Producto");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.RevisionProductosNavigation)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_RevisionProducto_Usuario");
        });

        modelBuilder.Entity<Seccion>(entity =>
        {
            entity.HasKey(e => e.CodigoSeccion).HasName("PK__Seccion__2FA6E61A249A28C5");

            entity.ToTable("Seccion");

            entity.Property(e => e.Fondo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Foto)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Html)
                .IsUnicode(false)
                .HasColumnName("HTML");
            entity.Property(e => e.Texto).IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.CodigoServicio).HasName("PK_Servicio_CodigoServicio");

            entity.ToTable("Servicio");

            entity.Property(e => e.AfectaMovimiento).HasDefaultValue(true);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.CodigoCuentaContableNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.CodigoCuentaContable)
                .HasConstraintName("FK_Servicio_CodigoCuentaContable");
        });

        modelBuilder.Entity<SolicitudContrasena>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__Solicitu__CC87E127662B2B3B");

            entity.ToTable("Solicitud_Contrasena");

            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Estado)
                .HasDefaultValue((byte)0)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Operador)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
            entity.Property(e => e.Usuario).HasColumnName("USUARIO");

            entity.HasOne(d => d.CodigoClienteNavigation).WithMany(p => p.SolicitudContrasenas)
                .HasForeignKey(d => d.CodigoCliente)
                .HasConstraintName("FK_Solicitud_Contrasena_Cliente");
        });

        modelBuilder.Entity<SolicitudDocumentoTarjetum>(entity =>
        {
            entity.HasKey(e => e.CodigoSolicitudDocumentoTarjeta).HasName("PK__Solicitu__5757DAC19092B201");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.SolicitudDocumentoTarjeta)
                .HasForeignKey(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_SolicitudDocumentoTarjeta_Factura");
        });

        modelBuilder.Entity<Subseccion>(entity =>
        {
            entity.HasKey(e => e.CodigoSubseccion).HasName("PK__Subsecci__C2849C3446BFE052");

            entity.ToTable("Subseccion");

            entity.Property(e => e.Fondo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Foto)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Html)
                .IsUnicode(false)
                .HasColumnName("HTML");
            entity.Property(e => e.Texto).IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoSeccionNavigation).WithMany(p => p.Subseccions)
                .HasForeignKey(d => d.CodigoSeccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Seccion_Subseccion_CodigoSeccion");
        });

        modelBuilder.Entity<Sugerencium>(entity =>
        {
            entity.HasKey(e => e.CodigoSugerencia);

            entity.Property(e => e.CodigoSugerencia).ValueGeneratedNever();
            entity.Property(e => e.CodigoAmazon)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Notificada).HasColumnType("smalldatetime");
            entity.Property(e => e.PrecioCosto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioSugerido).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Suscripcion>(entity =>
        {
            entity.HasKey(e => e.CodigoSuscripcion).HasName("PK__Suscripc__DEC952FDD67DCCA1");

            entity.ToTable("Suscripcion");

            entity.HasIndex(e => e.Correo, "IDX_Suscripcion_Correo");

            entity.HasIndex(e => e.Suscrito, "_dta_index_Suscripcion_6_683149479__K3_1_2");

            entity.Property(e => e.Correo)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoMedioDesuscripcionNavigation).WithMany(p => p.Suscripcions)
                .HasForeignKey(d => d.CodigoMedioDesuscripcion)
                .HasConstraintName("FK_Suscripcion_CodigoMedioDesuscripcion");

            entity.HasOne(d => d.CodigoMedioSuscripcionNavigation).WithMany(p => p.Suscripcions)
                .HasForeignKey(d => d.CodigoMedioSuscripcion)
                .HasConstraintName("FK_Suscripcion_MedioSuscripcion");
        });

        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.CodigoTarea).HasName("PK__Tarea__38856C5C2B97D049");

            entity.ToTable("Tarea");

            entity.HasIndex(e => new { e.CodigoUsuarioSupervisor, e.Revision }, "IDX_TareaCodigoUsuarioSuperRevision_UltimaModInactivo");

            entity.HasIndex(e => new { e.CodigoUsuarioSupervisor, e.Inactivo, e.CodigoUsuario, e.Notificacion, e.NotificacionSupervisor, e.CodigoTarea, e.Prioridad, e.Nombre, e.FechaCreacion, e.Horas }, "IDX_Tarea_CodUsSupervisorInactivoCodUsuarioNotificacionNotiSupervisorPrioridadNombreFechaCreacioHoras");

            entity.HasIndex(e => e.CodigoUsuario, "IDX_Tarea_CodigoUsuario_FechCreaPriNombreNotiHorasUltModiCodigoUsuarioSupervisorInactivoUltimaModificacionCreador");

            entity.HasIndex(e => e.Revision, "IDX_Tarea_Revision_CodUsuDescFecCreacionPrioridadNombHorasUltimaModCodUsuarioSupervInactivoUltimaModCreador");

            entity.HasIndex(e => new { e.CodigoTarea, e.CodigoUsuario, e.CodigoUsuarioSupervisor, e.Inactivo, e.FechaCreacion }, "_dta_index_Tarea_6_795406940__K1_K2_K10_K12_K4_5_6_7_8_9_19");

            entity.Property(e => e.CodigoTarea).ValueGeneratedNever();
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaDeEntrega).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");
            entity.Property(e => e.Horas).HasColumnType("numeric(5, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.UltimaModificacion).HasColumnType("datetime");
            entity.Property(e => e.UltimaModificacionCreador).HasColumnType("datetime");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.TareaCodigoUsuarioNavigations)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_Tarea_Usuario");

            entity.HasOne(d => d.CodigoUsuarioEliminacionNavigation).WithMany(p => p.TareaCodigoUsuarioEliminacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEliminacion)
                .HasConstraintName("FK__Tarea__CodigoUsu__75A9F463");

            entity.HasOne(d => d.CodigoUsuarioSupervisorNavigation).WithMany(p => p.TareaCodigoUsuarioSupervisorNavigations)
                .HasForeignKey(d => d.CodigoUsuarioSupervisor)
                .HasConstraintName("FK__Tarea__CodigoUsu__74B5D02A");
        });

        modelBuilder.Entity<TareaUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TareaUsuario");

            entity.HasIndex(e => new { e.CodigoTarea, e.EsUsuarioPrincipal, e.CodigoUsuario, e.FechaFinalizacion, e.FechaAsignacion, e.Notificacion, e.FechaUltimaModificacion }, "IDX_TareaUsuario_CodTareaEsUsuarioPrincialCodUsuarioFechaFinalFechaAsignacionNotificacionFechaUltimaModificacion");

            entity.HasIndex(e => new { e.CodigoTarea, e.FechaAsignacion, e.FechaFinalizacion, e.Notificacion, e.CodigoUsuario }, "IDX_TareaUsuario_CodTareaFechaAsifnacionFechaFinalNotificacionCodUsuario_FechaUltimaModificacionEsUsuarioPrincipal");

            entity.HasIndex(e => new { e.CodigoTarea, e.FechaFinalizacion }, "IDX_TareaUsuario_CodTareaFechaFinalizacion");

            entity.HasIndex(e => new { e.CodigoTarea, e.FechaUltimaModificacion, e.EsUsuarioPrincipal }, "IDX_TareaUsuario_CodTareaFechaUltmaModificacionEsUsuarioPrincipal");

            entity.HasIndex(e => new { e.CodigoTarea, e.Notificacion, e.CodigoUsuario, e.FechaAsignacion }, "IDX_TareaUsuario_CodTareaNotificacionCodUsuarioFechaAsignacion");

            entity.HasIndex(e => new { e.CodigoUsuario, e.EsUsuarioPrincipal, e.CodigoTarea, e.FechaFinalizacion, e.FechaAsignacion, e.Notificacion, e.FechaUltimaModificacion }, "IDX_TareaUsuario_CodUsuarioEsUsuarioPrincipalCodFechaFinalFechaAsigNotificacionFechaUltomaModif");

            entity.Property(e => e.FechaAsignacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUltimaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Secuencia).HasColumnType("decimal(16, 2)");

            entity.HasOne(d => d.CodigoTareaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoTarea)
                .HasConstraintName("FK_TareaUsuario_Tarea");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_TareaUsuario_Usuario");
        });

        modelBuilder.Entity<TasaDeCambio>(entity =>
        {
            entity.HasKey(e => e.Fecha).HasName("PK__TasaDeCa__B30C8A5F1BB7CAC1");

            entity.ToTable("TasaDeCambio");

            entity.Property(e => e.Valor).HasColumnType("decimal(14, 5)");
        });

        modelBuilder.Entity<Tema>(entity =>
        {
            entity.HasKey(e => e.CodigoTema).HasName("PK__Tema__39A29D0D4BC009EC");

            entity.ToTable("Tema");

            entity.HasIndex(e => e.CodigoUsuarioEncargado, "IDX_Tema_CodigoUsuarioEncargado_FechaModificacion");

            entity.HasIndex(e => new { e.EstadoDocumentacion, e.CodigoTema, e.FechaModificacion }, "IDX_Tema_EstadoDocumentacionCodigoTemaFechaModificacion");

            entity.Property(e => e.CodigoTema).ValueGeneratedNever();
            entity.Property(e => e.EstadoDocumentacion).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEliminacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NombreContenidoBucket)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoTemaPadreNavigation).WithMany(p => p.InverseCodigoTemaPadreNavigation)
                .HasForeignKey(d => d.CodigoTemaPadre)
                .HasConstraintName("FK_CodigoTemaTema");

            entity.HasOne(d => d.CodigoUsuarioEliminaNavigation).WithMany(p => p.TemaCodigoUsuarioEliminaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioElimina)
                .HasConstraintName("CodigoUsuarioElimina");

            entity.HasOne(d => d.CodigoUsuarioEncargadoNavigation).WithMany(p => p.TemaCodigoUsuarioEncargadoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEncargado)
                .HasConstraintName("FK_CodigoUsuarioEncargadoTema");

            entity.HasOne(d => d.CodigoUsuarioUltimaModificacionNavigation).WithMany(p => p.TemaCodigoUsuarioUltimaModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioUltimaModificacion)
                .HasConstraintName("FK_CodigoUsuarioUltimaModificacionTema");
        });

        modelBuilder.Entity<Temp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp");

            entity.Property(e => e.Codigoamazon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("codigoamazon");
            entity.Property(e => e.Codigoproducto)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigoproducto");
        });

        modelBuilder.Entity<TempCobro>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__TempCobr__06370DAD621CF8AD");

            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Datos).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<TipoAplicacionExterna>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoAplicacionExterna);

            entity.ToTable("TipoAplicacionExterna");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoClaseTipoAplicacionExternaNavigation).WithMany(p => p.TipoAplicacionExternas)
                .HasForeignKey(d => d.CodigoClaseTipoAplicacionExterna)
                .HasConstraintName("FK_TipoAplicacionExterna_CodigoClaseTipoAplicacionExterna");
        });

        modelBuilder.Entity<TipoCombustible>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoCombustible).HasName("PK__TipoComb__B1E3B23CCF7B1D52");

            entity.ToTable("TipoCombustible");

            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TipoContenidoDinamico>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoContenidoDinamico);

            entity.ToTable("TipoContenidoDinamico");

            entity.Property(e => e.CodigoTipoContenidoDinamico).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoContrato>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoContrato).HasName("PK__TipoCont__F46C49C2D72DDD8F");

            entity.ToTable("TipoContrato");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCuentum>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoCuenta).HasName("PK__TipoCuen__0FE05A25AE12FE82");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDatoTest>(entity =>
        {
            entity.HasKey(e => e.IdTipoDato).HasName("PK__TipoDato__C8C67CEBAA49BE9F");

            entity.ToTable("TipoDatoTest");

            entity.Property(e => e.IdTipoDato).HasColumnName("idTipoDato");
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.Fecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<TipoDeAnuncio>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoDeAnuncio).HasName("PK__TipoDeAn__5051786EAA5366D7");

            entity.ToTable("TipoDeAnuncio");

            entity.Property(e => e.Alto).HasDefaultValue(0);
            entity.Property(e => e.Ancho).HasDefaultValue(0);
            entity.Property(e => e.Cpcminimo).HasColumnName("CPCMinimo");
            entity.Property(e => e.EsImagen).HasDefaultValue(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.TipoDeAnuncios)
                .HasForeignKey(d => d.CodigoProducto)
                .HasConstraintName("FK__Producto_TipoDeAnuncio");
        });

        modelBuilder.Entity<TipoDeGasto>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoDeGasto);

            entity.ToTable("TipoDeGasto");

            entity.Property(e => e.AsociaGuias).HasDefaultValue(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vigente).HasDefaultValue(true);

            entity.HasOne(d => d.CodigoCuentaContableNavigation).WithMany(p => p.TipoDeGastos)
                .HasForeignKey(d => d.CodigoCuentaContable)
                .HasConstraintName("FK__TipoDeGas__Codig__5B83456E");
        });

        modelBuilder.Entity<TipoDeTarjetum>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoDeTarjeta);

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDispositivo>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoDispositivo).HasName("PK__TipoDisp__A464F50BFA378792");

            entity.ToTable("TipoDispositivo");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoImpresion).HasDefaultValue(false);
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoDocumento).HasName("PK_CodigoTipoDocumento");

            entity.ToTable("TipoDocumento");

            entity.Property(e => e.CodigoTipoDocumento).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoError>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoError).HasName("PK__TipoErro__EA72E20179C80F94");

            entity.ToTable("TipoError");

            entity.Property(e => e.CodigoTipoError).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoEscenarioContable>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoEscenarioContable).HasName("PK__TipoEsce__7E44A0A95A84FF94");

            entity.ToTable("TipoEscenarioContable");

            entity.Property(e => e.Algoritmo)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(450)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.PermiteMultiplesEscenarios).HasDefaultValue(false);
        });

        modelBuilder.Entity<TipoGarantium>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoGarantia).HasName("PK__TipoGara__1FF74AB0451ADDEF");

            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoGuium>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoGuia).HasName("PK__TipoGuia__7B2DF172651F1C7A");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoHistorico>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoHistorico).HasName("PK_CodigoTipoHistorico");

            entity.ToTable("TipoHistorico");

            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoIngreso>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoIngreso).HasName("PK__TipoIngr__1DC3007C7C0F4C1D");

            entity.ToTable("TipoIngreso");

            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoCuentaContableNavigation).WithMany(p => p.TipoIngresos)
                .HasForeignKey(d => d.CodigoCuentaContable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoIngreso_CodigoCuentaContable");
        });

        modelBuilder.Entity<TipoJornadum>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoJornada).HasName("PK__TipoJorn__EF23C164EF496835");

            entity.Property(e => e.Nombre)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoLicenciaVacacione>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoLicenciaVacaciones).HasName("PK__TipoLice__57F3EF7B93DBA556");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaActivo).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaModifica).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoUsuarioActivoNavigation).WithMany(p => p.TipoLicenciaVacacioneCodigoUsuarioActivoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioActivo)
                .HasConstraintName("FK_TipoLicenciaVacaciones_CodigoUsuarioActivo");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.TipoLicenciaVacacioneCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoLicenciaVacaciones_CodigoUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioModificaNavigation).WithMany(p => p.TipoLicenciaVacacioneCodigoUsuarioModificaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModifica)
                .HasConstraintName("FK_TipoLicenciaVacaciones_CodigoUsuarioModifica");
        });

        modelBuilder.Entity<TipoMovimiento>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoMovimiento);

            entity.ToTable("TipoMovimiento");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPreguntum>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoPregunta).HasName("PK__TipoPreg__3DD03A796CA31EA0");

            entity.Property(e => e.CodigoTipoPregunta).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPromocion>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoPromocion).HasName("PK__TipoProm__ACF994CE544AD835");

            entity.ToTable("TipoPromocion");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoReclamoPaquete>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoReclamoPaquete).HasName("PK__TipoRecl__7DB2471C6E833B84");

            entity.ToTable("TipoReclamoPaquete");

            entity.Property(e => e.Nombre)
                .HasMaxLength(700)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoRegimenFacturacion>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoRegimenFacturacion).HasName("PK__TipoRegi__DAC08925CB9C7CF3");

            entity.ToTable("TipoRegimenFacturacion");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoTransaccion>(entity =>
        {
            entity.HasKey(e => e.CodigoTipoTransaccion);

            entity.ToTable("TipoTransaccion");

            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoFormaDePagoNavigation).WithMany(p => p.TipoTransaccions)
                .HasForeignKey(d => d.CodigoFormaDePago)
                .HasConstraintName("FK_TipoTransaccion_FormaDePago");
        });

        modelBuilder.Entity<TmpCargareembolso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_Cargareembolso");

            entity.Property(e => e.FechaOperacion).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tarjeta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmpCategoriaEliminadum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_CategoriaEliminada");

            entity.HasIndex(e => e.CodigoCategoria, "UQ__tmp_Cate__2B9993AE0BE8F189").IsUnique();

            entity.Property(e => e.CodigoCategoria).HasColumnName("codigoCategoria");
            entity.Property(e => e.FechaEliminacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("fechaEliminacion");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmpDepositoEmpresaEntrega>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_DepositoEmpresaEntrega");

            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");
            entity.Property(e => e.MontoDeposito).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NumeroAutorizacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmpPedido>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Pedido");

            entity.Property(e => e.AsinIsbn)
                .HasMaxLength(100)
                .HasColumnName("ASIN/ISBN");
            entity.Property(e => e.BuyerName)
                .HasMaxLength(100)
                .HasColumnName("Buyer Name");
            entity.Property(e => e.CarrierNameTrackingNumber)
                .HasMaxLength(510)
                .HasColumnName("Carrier Name & Tracking Number");
            entity.Property(e => e.Category).HasMaxLength(510);
            entity.Property(e => e.Cifaduana)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("CIFAduana");
            entity.Property(e => e.CodigoReferencia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Condition).HasMaxLength(100);
            entity.Property(e => e.Currency).HasMaxLength(100);
            entity.Property(e => e.ExternalItemNumber)
                .HasMaxLength(100)
                .HasColumnName("External Item Number");
            entity.Property(e => e.Foto1).HasMaxLength(250);
            entity.Property(e => e.Foto2).HasMaxLength(250);
            entity.Property(e => e.Foto3).HasMaxLength(250);
            entity.Property(e => e.ItemSubtotal)
                .HasMaxLength(100)
                .HasColumnName("Item Subtotal");
            entity.Property(e => e.ItemSubtotalTax)
                .HasMaxLength(100)
                .HasColumnName("Item Subtotal Tax");
            entity.Property(e => e.MontoArancel).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoFlete).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoIva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MontoIVA");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1020)
                .IsUnicode(false);
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("Order Date");
            entity.Property(e => e.OrderId)
                .HasMaxLength(100)
                .HasColumnName("Order ID");
            entity.Property(e => e.OrderingCustomerEmail)
                .HasMaxLength(100)
                .HasColumnName("Ordering Customer Email");
            entity.Property(e => e.OriginalListPrice)
                .HasMaxLength(100)
                .HasColumnName("Original List Price");
            entity.Property(e => e.Pagina)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PaymentInstrumentType)
                .HasMaxLength(100)
                .HasColumnName("Payment Instrument Type");
            entity.Property(e => e.PerUnitPrice)
                .HasMaxLength(100)
                .HasColumnName("Per Unit Price");
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PrecioAnterior).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(100)
                .HasColumnName("Purchase Order Number");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("datetime")
                .HasColumnName("Release Date");
            entity.Property(e => e.Seller).HasMaxLength(510);
            entity.Property(e => e.ShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("Shipment Date");
            entity.Property(e => e.ShipmentOrderCondition)
                .HasMaxLength(100)
                .HasColumnName("Shipment/Order Condition");
            entity.Property(e => e.ShippingAddressCity)
                .HasMaxLength(100)
                .HasColumnName("Shipping Address City");
            entity.Property(e => e.ShippingAddressName)
                .HasMaxLength(510)
                .HasColumnName("Shipping Address Name");
            entity.Property(e => e.ShippingAddressState)
                .HasMaxLength(100)
                .HasColumnName("Shipping Address State");
            entity.Property(e => e.ShippingAddressStreet1)
                .HasMaxLength(510)
                .HasColumnName("Shipping Address Street 1");
            entity.Property(e => e.ShippingAddressStreet2)
                .HasMaxLength(510)
                .HasColumnName("Shipping Address Street 2");
            entity.Property(e => e.ShippingAddressZip)
                .HasMaxLength(100)
                .HasColumnName("Shipping Address Zip");
            entity.Property(e => e.Signature).HasMaxLength(100);
            entity.Property(e => e.Title)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.Upc)
                .HasMaxLength(255)
                .HasColumnName("UPC");
            entity.Property(e => e.UrlOrden)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Website).HasMaxLength(255);
        });

        modelBuilder.Entity<TmpPedidoEstablecimiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Pedido_Establecimiento");

            entity.Property(e => e.AsinIsbn)
                .HasMaxLength(100)
                .HasColumnName("ASIN/ISBN");
            entity.Property(e => e.CarrierNameTrackingNumber)
                .HasMaxLength(255)
                .HasColumnName("Carrier Name & Tracking Number");
            entity.Property(e => e.Category).HasMaxLength(510);
            entity.Property(e => e.CodigoEstablecimiento).HasMaxLength(100);
            entity.Property(e => e.CodigoReferencia).HasMaxLength(100);
            entity.Property(e => e.EnglishName).HasMaxLength(750);
            entity.Property(e => e.ItemSubtotal)
                .HasMaxLength(100)
                .HasColumnName("Item Subtotal");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("Order Date");
            entity.Property(e => e.OrderId)
                .HasMaxLength(100)
                .HasColumnName("Order ID");
            entity.Property(e => e.Pagina).HasMaxLength(255);
            entity.Property(e => e.PerUnitPrice)
                .HasMaxLength(100)
                .HasColumnName("Per Unit Price");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Seller).HasMaxLength(255);
            entity.Property(e => e.ShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("Shipment Date");
            entity.Property(e => e.Title).HasMaxLength(700);
            entity.Property(e => e.Upc)
                .HasMaxLength(255)
                .HasColumnName("UPC");
        });

        modelBuilder.Entity<TmpPromo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Promo");

            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmpReembolso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Reembolso");

            entity.Property(e => e.AsinIsbn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ASIN/ISBN");
            entity.Property(e => e.BuyerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Buyer Name");
            entity.Property(e => e.Category)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Group Name");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Order Date");
            entity.Property(e => e.OrderId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Order ID");
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Purchase Order Number");
            entity.Property(e => e.Quantity)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RefundAmount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Refund Amount");
            entity.Property(e => e.RefundCondition)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Refund Condition");
            entity.Property(e => e.RefundDate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Refund Date");
            entity.Property(e => e.RefundReason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Refund Reason");
            entity.Property(e => e.RefundTaxAmount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Refund Tax Amount");
            entity.Property(e => e.Seller)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SellerCredentials)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Seller Credentials");
            entity.Property(e => e.TaxExemptionApplied)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tax Exemption Applied");
            entity.Property(e => e.Title)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Traduccione>(entity =>
        {
            entity.HasKey(e => e.CadenaTraducir).HasName("pk_Traducciones");

            entity.Property(e => e.CadenaTraducir)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Traduccion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Transaccion>(entity =>
        {
            entity.HasKey(e => e.CodigoTransaccion).HasName("PK__Transacc__A7EC8DDF24285DB4");

            entity.ToTable("Transaccion");

            entity.HasIndex(e => new { e.Estado, e.Fecha, e.CodigoTipoTransaccion, e.CuentaDestino, e.CodigoCobro }, "IDX_TransaccionEstadoFechaCodTipoTransaccionCuentaDestinoCodCobro_CodTranCuentaOriMonto");

            entity.HasIndex(e => new { e.CodigoCobro, e.CodigoGasto, e.Estado, e.CodigoTipoTransaccion, e.Fecha, e.CuentaDestino, e.CuentaOrigen }, "IDX_Transaccion_CodCobroCodGastoEstadoCodTipoTranscFechaCuentaDestinoCuentaOrigen_CodTransacMonto");

            entity.HasIndex(e => new { e.CodigoCobro, e.CodigoTransaccion }, "IDX_Transaccion_CodCobroCodTransaccion_CodTipoTransacccion");

            entity.HasIndex(e => new { e.CodigoGasto, e.Fecha, e.Estado, e.CodigoTransaccion, e.CuentaOrigen }, "IDX_Transaccion_CodGastoFechaEstadoCodTransaccionCuentaOrigen");

            entity.HasIndex(e => e.CodigoCobro, "IDX_Transaccion_CodigoCobro");

            entity.HasIndex(e => new { e.CodigoCobro, e.CodigoGasto, e.Estado, e.CodigoPolizaContable, e.Fecha }, "IDX_Transaccion_CodigoCobroCodigoGastoEstadoCodigoPolizaContableFecha");

            entity.HasIndex(e => new { e.CodigoCobro, e.CodigoGasto, e.Estado, e.CodigoTipoTransaccion, e.CodigoPolizaContable, e.Fecha }, "IDX_Transaccion_CodigoCobroCodigoGastoEstadoCodigoTipoTransaccionCodigoPolizaContableFecha_CuentaOrigenCuentaDestinoMonto");

            entity.HasIndex(e => new { e.CodigoPolizaContable, e.CodigoTransaccion, e.Fecha }, "IDX_Transaccion_CodigoDeTransaccionCodigoPolizaContableFecha_TipoCambio");

            entity.HasIndex(e => e.CodigoEstadoTransferencia, "IDX_Transaccion_CodigoEstadoTransferencia_CuentaOrigenCuentaDestinoFechaIngreso");

            entity.HasIndex(e => e.CodigoGasto, "IDX_Transaccion_CodigoGasto");

            entity.HasIndex(e => e.CodigoPedido, "IDX_Transaccion_CodigoPedido");

            entity.HasIndex(e => e.CodigoPolizaContable, "IDX_Transaccion_CodigoPolizaContable");

            entity.HasIndex(e => e.CodigoTipoTransaccion, "IDX_Transaccion_CodigoTipoTransaccion_CodigoCobro");

            entity.HasIndex(e => e.CodigoTipoTransaccion, "IDX_Transaccion_CodigoTipoTransaccion_CuentaOrigenCuentaDestinoMontoCodigoCobro");

            entity.HasIndex(e => e.CodigoTransaccion, "IDX_Transaccion_CodigoTransaccion_CodigoCobro");

            entity.HasIndex(e => e.CuentaDestino, "IDX_Transaccion_CuentaDestino");

            entity.HasIndex(e => new { e.CuentaDestino, e.Estado, e.CodigoPolizaContable }, "IDX_Transaccion_CuentaDestinoEstadoCodigoPolizaContable_CuentaOrigenFechaMontoCodigoGasto");

            entity.HasIndex(e => e.CuentaOrigen, "IDX_Transaccion_CuentaOrigen");

            entity.HasIndex(e => new { e.CuentaOrigen, e.Estado }, "IDX_Transaccion_CuentaOrigenEstado_CuentaDestinoFechaMontoCodUsuarioCodCobroCodGastoNumeroCheque");

            entity.HasIndex(e => new { e.Estado, e.CodigoGasto, e.CodigoCobro, e.CodigoPolizaContable, e.Fecha, e.CuentaDestino, e.CodigoTipoIngreso }, "IDX_Transaccion_EstadoCodGastoCodCobroCodPolizaContableFechaCuentaDestinoCodTipoIngr_CodTransCuetaOrgMtCodTipoTrancTipCa");

            entity.HasIndex(e => new { e.Estado, e.CodigoTipoTransaccion, e.Fecha, e.CuentaOrigen, e.CodigoCobro }, "IDX_Transaccion_EstadoCodTipoTransaccionFechaCuentaOrigenCodCobro_CodTransaccionCuentaDestinoMonto");

            entity.HasIndex(e => new { e.Estado, e.CodigoTipoTransaccion, e.Fecha }, "IDX_Transaccion_EstadoCodTipoTransaccionFecha_CuentaOrigenCuentaDestinoMontoCodUsuarioCodCobroCodGastoNumeroDeChequeTipoCambio");

            entity.HasIndex(e => new { e.Estado, e.CodigoEstadoTransferencia }, "IDX_Transaccion_EstadoCodigoEstadoTransferencia_CuentaOrigenCuentaDestinoFecha");

            entity.HasIndex(e => new { e.Estado, e.CodigoPolizaContable, e.CodigoTipoTransaccion }, "IDX_Transaccion_EstadoCodigoPolizaContableCodigoTipoTransaccion_CuentaOrigenCuentaDestinoMontoCodigoCobro");

            entity.HasIndex(e => new { e.Estado, e.CodigoTipoTransaccion, e.Fecha, e.Monto }, "IDX_Transaccion_EstadoCodigoTipoTransFechaMonto_CuentaDestinoCodigoPedido");

            entity.HasIndex(e => new { e.Estado, e.CodigoTipoTransaccion, e.NumeroReferenciaOrigen }, "IDX_Transaccion_EstadoCodigoTipoTransaccionNumeroReferencia_CuentaOrigenCuentaDestino");

            entity.HasIndex(e => new { e.Estado, e.CodigoTipoTransaccion, e.CodigoPolizaContable }, "IDX_Transaccion_EstadoCofigoTipoTransaccionCodigoPolizaContable_CuentaOrigenCuentaDestinoMonotCodigoCobro");

            entity.HasIndex(e => new { e.Estado, e.CuentaDestino, e.CodigoPolizaContable, e.CodigoGasto, e.CuentaOrigen }, "IDX_Transaccion_EstadoCuentaDestinoCodPolizaContableCodGastoCuentaOrigen_CodTransaccionMonto");

            entity.HasIndex(e => new { e.Estado, e.Fecha, e.CuentaDestino, e.CuentaOrigen, e.CodigoUsuario, e.CodigoGasto, e.CodigoTipoTransaccion, e.CodigoCobro }, "IDX_Transaccion_EstadoFechaCuentaDesCuentaOregCodUsuarioCodGastoCodTipoTransacCodCobro_CodTransacMontoNumDChequeTipoCambioNumRef");

            entity.HasIndex(e => new { e.Estado, e.FechaIngreso }, "IDX_Transaccion_EstadoFechaIngreso_CodigoGasto");

            entity.HasIndex(e => e.Estado, "IDX_Transaccion_Estado_CodigoGastoFechaIngreso");

            entity.HasIndex(e => new { e.Monto, e.Estado, e.CodigoTransaccion, e.CuentaDestino }, "IDX_Transaccion_MontoEstadoCodTransaccionCuentadestido");

            entity.Property(e => e.CodigoTransaccion).ValueGeneratedNever();
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioModificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NumeroDeCheque)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.NumeroReferenciaDestino)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.NumeroReferenciaOrigen)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.CodigoCobroNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.CodigoCobro)
                .HasConstraintName("FK_Transaccion_Cobro");

            entity.HasOne(d => d.CodigoEstadoTransferenciaNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.CodigoEstadoTransferencia)
                .HasConstraintName("FK_Transaccion_CodigoEstadoTransferencia");

            entity.HasOne(d => d.CodigoGastoNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.CodigoGasto)
                .HasConstraintName("FK_Transaccion_Gasto");

            entity.HasOne(d => d.CodigoPedidoNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.CodigoPedido)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Transaccion_Pedido");

            entity.HasOne(d => d.CodigoPolizaContableNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.CodigoPolizaContable)
                .HasConstraintName("FK_Transaccion_PolizaContable");

            entity.HasOne(d => d.CodigoTipoIngresoNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.CodigoTipoIngreso)
                .HasConstraintName("FK_Transaccion_CodigoTipoIngreso");

            entity.HasOne(d => d.CodigoTipoTransaccionNavigation).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.CodigoTipoTransaccion)
                .HasConstraintName("FK_Transaccion_TipoTransaccion");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.TransaccionCodigoUsuarioNavigations)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_Transaccion_Usuario");

            entity.HasOne(d => d.CodigoUsuarioModificacionNavigation).WithMany(p => p.TransaccionCodigoUsuarioModificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificacion)
                .HasConstraintName("FK_Transaccion_CodigoUsuarioModificacion");

            entity.HasOne(d => d.CuentaDestinoNavigation).WithMany(p => p.TransaccionCuentaDestinoNavigations)
                .HasForeignKey(d => d.CuentaDestino)
                .HasConstraintName("FK_Transaccion_CuentaDestino");

            entity.HasOne(d => d.CuentaOrigenNavigation).WithMany(p => p.TransaccionCuentaOrigenNavigations)
                .HasForeignKey(d => d.CuentaOrigen)
                .HasConstraintName("FK_Transaccion_CuentaOrigen");
        });

        modelBuilder.Entity<UbicacionBodega>(entity =>
        {
            entity.HasKey(e => e.CodigoUbicacionBodega);

            entity.ToTable("UbicacionBodega");

            entity.HasIndex(e => e.Nombre, "IDX_UbicacionBodega_Nombre").IsUnique();

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UbicacionDespacho>(entity =>
        {
            entity.HasKey(e => e.CodigoUbicacionDespacho).HasName("PK__Ubicacio__5FFA0DFEB49BF27B");

            entity.ToTable("UbicacionDespacho");

            entity.Property(e => e.Nombre)
                .HasMaxLength(51)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UbicacionTemporalDespacho>(entity =>
        {
            entity.HasKey(e => e.CodigoUbicacionTemporalDespacho).HasName("PK__Ubicacio__3214EC27363C2C4B");

            entity.ToTable("UbicacionTemporalDespacho");

            entity.HasIndex(e => new { e.CodigoUbicacionDespacho, e.FechaDesubicacion }, "IDX_UbicacionTemporalDespacho_CodigoUbicacion_FechaDesubicacion");

            entity.HasIndex(e => new { e.CodigoVenta, e.FechaDesubicacion, e.FechaUbicacion }, "IDX_UbicacionTemporalDespacho_CodigoVentaFechaDesubicacionFechaUbicacion");

            entity.HasIndex(e => new { e.FechaDesubicacion, e.FechaUbicacion }, "IDX_UbicacionTemporalDespacho_FechaDesubicacionFechaUbicacion_CodigoUbicacionUsuarioUbicacion");

            entity.Property(e => e.FechaDesubicacion).HasColumnType("datetime");
            entity.Property(e => e.FechaUbicacion).HasColumnType("datetime");
            entity.Property(e => e.Upc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UPC");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.CodigoUsuario);

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.CodigoUsuario, "IDX_Codigo_Usuario");

            entity.HasIndex(e => e.CodigoUsuario, "_dta_index_Usuario_6_373576369__K1_2");

            entity.Property(e => e.CodigoUsuario).ValueGeneratedNever();
            entity.Property(e => e.AccesoRemoto).HasDefaultValue(false);
            entity.Property(e => e.AnulaFactura).HasDefaultValue(false);
            entity.Property(e => e.AsignarAnomalia).HasDefaultValue(false);
            entity.Property(e => e.CamposModificados)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodigoEstadoCivil).HasDefaultValue(0);
            entity.Property(e => e.CodigoGradoUniversitario).HasDefaultValue(0);
            entity.Property(e => e.CodigoTipoContrato).HasDefaultValue(0);
            entity.Property(e => e.ContactoEmergencia)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CorreoEmpresarial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DatosPrivados).HasDefaultValue(false);
            entity.Property(e => e.DepartamentoDpiExtendido)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DepartamentoNacimiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DepartamentoResidencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DescriptorDePuesto)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DispositivoEntrega)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.Dpi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DPI");
            entity.Property(e => e.EliminaTransaccionConciliacionBancaria).HasDefaultValue(false);
            entity.Property(e => e.EstadoUsuarioExterno).HasDefaultValue(false);
            entity.Property(e => e.ExpiraPassword).HasDefaultValue(true);
            entity.Property(e => e.FechaDeBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaDeNacimiento).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacionPassword).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacionPermiso).HasColumnType("datetime");
            entity.Property(e => e.GestionaAccesoServicio)
                .HasDefaultValue(false)
                .HasColumnName("gestionaAccesoServicio");
            entity.Property(e => e.HoraAlmuerzo).HasDefaultValue(60);
            entity.Property(e => e.Horario)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Igss)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Irtra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JornadaCompleta).HasDefaultValue(true);
            entity.Property(e => e.Licencia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Metricas).HasDefaultValue(false);
            entity.Property(e => e.ModificaCaby).HasDefaultValue(false);
            entity.Property(e => e.ModificaCuentaCompra).HasDefaultValue(false);
            entity.Property(e => e.ModificaDatosGuia).HasDefaultValue(false);
            entity.Property(e => e.ModificaFormaPago).HasDefaultValue(false);
            entity.Property(e => e.ModificaFormaPagoDireccion)
                .IsRequired()
                .HasDefaultValueSql("('0')");
            entity.Property(e => e.ModificaObservacionDeEntrega).HasDefaultValue(false);
            entity.Property(e => e.ModificaPaquete).HasDefaultValue(false);
            entity.Property(e => e.ModificaParametro).HasDefaultValue(false);
            entity.Property(e => e.ModificaPrecio).HasDefaultValue(false);
            entity.Property(e => e.ModificaVacaciones).HasColumnName("modificaVacaciones");
            entity.Property(e => e.ModificaVales).HasDefaultValue(false);
            entity.Property(e => e.MotivoBaja)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MunicipioDpiExtendido)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MunicipioNacimiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MunicipioResidencia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PermisoModificarImportadores)
                .HasDefaultValue(false)
                .HasColumnName("permisoModificarImportadores");
            entity.Property(e => e.ProductoCombinado).HasDefaultValue(false);
            entity.Property(e => e.Profesion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PuestoDeTrabajoClave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuestoDeTrabajoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RedSocialDeTrabajo)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.RevisionAjusteCuenta).HasDefaultValue(false);
            entity.Property(e => e.Telefono1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telefono2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Usuario");

            entity.HasOne(d => d.CodigoBancoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.CodigoBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__CodigoB__5CC9CC8A");

            entity.HasOne(d => d.CodigoDepartamentoEmpresaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.CodigoDepartamentoEmpresa)
                .HasConstraintName("FK__Usuario__CodigoD__3EC4FC02");

            entity.HasOne(d => d.CodigoEstadoCivilNavigation).WithMany(p => p.Usuarios).HasForeignKey(d => d.CodigoEstadoCivil);

            entity.HasOne(d => d.CodigoGradoUniversitarioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.CodigoGradoUniversitario)
                .HasConstraintName("FK_Usuario_GradoU_CodigoGradoU");

            entity.HasOne(d => d.CodigoPerfilDeImpresionNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.CodigoPerfilDeImpresion)
                .HasConstraintName("FK_Usuario_PerfilDeImpresion");

            entity.HasOne(d => d.CodigoTipoContratoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.CodigoTipoContrato)
                .HasConstraintName("FK_Usuario_TipoC");

            entity.HasOne(d => d.CodigoTipoJornadaNavigation).WithMany(p => p.Usuarios).HasForeignKey(d => d.CodigoTipoJornada);
        });

        modelBuilder.Entity<UsuarioAplicacionExterna>(entity =>
        {
            entity.HasKey(e => e.CodigoUsuarioAplicacionExterna);

            entity.ToTable("UsuarioAplicacionExterna");

            entity.HasIndex(e => new { e.CodigoUsuarioAplicacionExterna, e.CodigoAplicacionExterna }, "IDX_UsuarioAplicacionExterna_CodigoUsuarioExterna").HasFillFactor(100);

            entity.HasIndex(e => new { e.Usuario, e.CodigoAplicacionExterna }, "UsuarioAplicacionExterna_UN").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Codigo).HasMaxLength(512);
            entity.Property(e => e.FechaUsuarioCreacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioInactivo).HasColumnType("smalldatetime");
            entity.Property(e => e.Password).HasMaxLength(512);
            entity.Property(e => e.Usuario).HasMaxLength(512);

            entity.HasOne(d => d.CodigoAplicacionExternaNavigation).WithMany(p => p.UsuarioAplicacionExternas)
                .HasForeignKey(d => d.CodigoAplicacionExterna)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioAplicacionExterna_AplicacionExterna");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.UsuarioAplicacionExternas)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioAplicacionExterna_CodigoUsuarioCreacion");
        });

        modelBuilder.Entity<UsuarioAplicacionExternaCuentum>(entity =>
        {
            entity.HasNoKey();

            entity.HasOne(d => d.CodigoCuentaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioAplicacionExternaCuenta");

            entity.HasOne(d => d.CodigoUsuarioAplicacionExternaNavigation).WithMany()
                .HasForeignKey(d => d.CodigoUsuarioAplicacionExterna)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioAplicacionExternaCuenta_UsuarioAplicacionExterna");
        });

        modelBuilder.Entity<UsuarioAplicacionExternaUsuario>(entity =>
        {
            entity.HasKey(e => new { e.CodigoUsuario, e.CodigoUsuarioAplicacionExterna }).HasName("PK_UsuarioAplicacionExternaUsuario_CodigoUsuarioAplicacionExternaUsuario");

            entity.ToTable("UsuarioAplicacionExternaUsuario");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioInactivo).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.UsuarioAplicacionExternaUsuarioCodigoUsuarioNavigations)
                .HasForeignKey(d => d.CodigoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioAplicacionExternaUsuario_Usuario");

            entity.HasOne(d => d.CodigoUsuarioAplicacionExternaNavigation).WithMany(p => p.UsuarioAplicacionExternaUsuarios)
                .HasForeignKey(d => d.CodigoUsuarioAplicacionExterna)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioAplicacionExternaUsuario_UsuarioAplicacionExterna");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.UsuarioAplicacionExternaUsuarioCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioAplicacionExternaUsuarioC_Usuario");

            entity.HasOne(d => d.CodigoUsuarioInactivoNavigation).WithMany(p => p.UsuarioAplicacionExternaUsuarioCodigoUsuarioInactivoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioInactivo)
                .HasConstraintName("FK_UsuarioAplicacionExternaUsuarioE_Usuario");
        });

        modelBuilder.Entity<VInventarioDispositivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_InventarioDispositivos");

            entity.Property(e => e.Departamento)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Dispositivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Upc).HasColumnName("UPC");
            entity.Property(e => e.Usuario)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vacacion>(entity =>
        {
            entity.HasKey(e => new { e.CodigoUsuario, e.FechaInicio });

            entity.ToTable("Vacacion");

            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaElimina).HasColumnType("datetime");
            entity.Property(e => e.MotivoEliminacion).HasColumnType("text");
            entity.Property(e => e.Observacion).HasColumnType("text");
            entity.Property(e => e.Penalizacion).HasDefaultValue(false);

            entity.HasOne(d => d.CodigoTipoLicenciaVacacionesNavigation).WithMany(p => p.Vacacions)
                .HasForeignKey(d => d.CodigoTipoLicenciaVacaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vacacion_CodigoTipo__799A1121");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.VacacionCodigoUsuarioNavigations)
                .HasForeignKey(d => d.CodigoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodigoUsuario");

            entity.HasOne(d => d.CodigoUsuarioCreacionNavigation).WithMany(p => p.VacacionCodigoUsuarioCreacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCreacion)
                .HasConstraintName("FK_VacacionUsuarioCreacion");

            entity.HasOne(d => d.CodigoUsuarioEliminaNavigation).WithMany(p => p.VacacionCodigoUsuarioEliminaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioElimina)
                .HasConstraintName("FK_VacacionUsuarioElimina");
        });

        modelBuilder.Entity<Vale>(entity =>
        {
            entity.HasKey(e => e.CodigoVale).HasName("PK_CodigoVale");

            entity.ToTable("Vale");

            entity.HasIndex(e => e.NumeroVale, "UK_NumeroDeVale").IsUnique();

            entity.Property(e => e.Estado).HasDefaultValue(false);
            entity.Property(e => e.Monto).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.NumeroVale)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ValorAtributo>(entity =>
        {
            entity.HasKey(e => e.CodigoValorAtributo).HasName("PK_ValorAtributo_1");

            entity.ToTable("ValorAtributo");

            entity.HasIndex(e => new { e.CodigoAtributo, e.Valor }, "IDX_CodigoAtributo_Valor").IsUnique();

            entity.Property(e => e.Valor).HasMaxLength(50);

            entity.HasOne(d => d.CodigoAtributoNavigation).WithMany(p => p.ValorAtributos)
                .HasForeignKey(d => d.CodigoAtributo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Atributo_ValorAtributo");
        });

        modelBuilder.Entity<VentaCaby>(entity =>
        {
            entity.HasKey(e => new { e.CodigoCaby, e.CodigoVenta }).HasName("PK_CodigoCaby_CodigoVenta");

            entity.ToTable("VentaCaby");

            entity.Property(e => e.HistoricoImpuestoCaby).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NombreCategoriaCaby)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoCabyNavigation).WithMany(p => p.VentaCabies)
                .HasForeignKey(d => d.CodigoCaby)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VentaCaby_CodigoCaby");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.VentaCabies)
                .HasForeignKey(d => d.CodigoVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VentaCaby_CodigoVenta");
        });

        modelBuilder.Entity<VentaPedido>(entity =>
        {
            entity.HasKey(e => new { e.CodigoVenta, e.CodigoPedido }).HasName("PK__VentaPed__556376945555A4F4");

            entity.ToTable("VentaPedido");

            entity.HasIndex(e => e.CodigoVenta, "IDX_VentaPedido_CodVenta_CodPedidaCantidad");

            entity.HasIndex(e => e.CodigoPedido, "VentaPedido_CodigoPedido");

            entity.HasIndex(e => e.CodigoVenta, "VentaPedido_CodigoVenta");

            entity.HasOne(d => d.CodigoPedidoNavigation).WithMany(p => p.VentaPedidos)
                .HasForeignKey(d => d.CodigoPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VentaPedido_Pedido");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.VentaPedidos)
                .HasForeignKey(d => d.CodigoVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VentaPedido_Venta");
        });

        modelBuilder.Entity<VentaPedidoInventario>(entity =>
        {
            entity.HasKey(e => new { e.CodigoVenta, e.CodigoPedido }).HasName("PK__VentaPed__556376944C4DD811");

            entity.ToTable("VentaPedidoInventario");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.VentaPedidoInventarios)
                .HasForeignKey(d => d.CodigoVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VentaPedidoInventario_Venta");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.CodigoVenta);

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.Fecha }, "IDX_CodigoEstadoDeVentaFecha_CodigoProductoMontoCodigoFactura");

            entity.HasIndex(e => new { e.CodigoCliente, e.CodigoVenta, e.CodigoEstadoEntrega, e.CodigoFactura, e.Fecha }, "IDX_Venta_CodClienteCodVentaCodEstadoEntregaCodFacturaFecha_CantidadCodProductoEnPreordenCodEstadoDeVenta");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoVenta, e.CodigoProducto }, "IDX_Venta_CodEstadoDeVentaCodVentaCodProducto_Cantidad");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.EsPedido, e.CodigoFactura }, "IDX_Venta_CodEstadoDeVentaEsPedidoCodFactura");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoFactura }, "IDX_Venta_CodEstadoVentaCodFac_CantCodProductoVerificado");

            entity.HasIndex(e => new { e.CodigoFactura, e.CodigoEstadoDeVenta, e.CodigoVenta }, "IDX_Venta_CodFacturaCodEstadoDeVentaCodVenta_ProductoVerificacdoEsPedido");

            entity.HasIndex(e => new { e.CodigoFactura, e.CodigoVenta, e.NombreCliente }, "IDX_Venta_CodFacturaCodVentaNombreCliente");

            entity.HasIndex(e => new { e.CodigoProducto, e.EnPreorden, e.Confirmada }, "IDX_Venta_CodProducto_EnPreordenConfirmada_FehcaCantidadCodFacturaMontoProveedor");

            entity.HasIndex(e => e.CodigoCliente, "IDX_Venta_CodigoCliente").IsDescending();

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoEstadoEntrega, e.Despachada, e.EsPedido, e.CodigoProducto, e.CodigoVenta, e.ProductoVerificado }, "IDX_Venta_CodigoEstadoDeVentaCodigoEstadoEntregaDespachadaEsPedidoCodigoProductoCodigoVentaProductoVerificado");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoEstadoEntrega }, "IDX_Venta_CodigoEstadoDeVentaCodigoEstadoEntrega_CantidadCodigoProductoEsPedidoDespachada");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoFactura }, "IDX_Venta_CodigoEstadoDeVentaCodigoFactura");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoFactura, e.CodigoEstadoEntrega }, "IDX_Venta_CodigoEstadoDeVentaCodigoFacturaCodigoEstadoEntrega");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoFactura, e.EsPedido, e.ProductoComprado }, "IDX_Venta_CodigoEstadoDeVentaCodigoFacturaEsPedidoProductoComprado");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoIncidenciaVenta }, "IDX_Venta_CodigoEstadoDeVentaCodigoIncidenciaVenta_FechaCodigoProducto");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoFactura }, "IDX_Venta_CodigoEstadoDeVentaCodigofactura_Fecha");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.EsPedido, e.Monto, e.ProductoVerificado, e.CodigoFactura }, "IDX_Venta_CodigoEstadoDeVentaEsPedidoMontoProductoVerificadoCodigoFactura_CodigoProducto");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.EsPedido, e.Despachada }, "IDX_Venta_CodigoEstadoDeVentaEspedidoDespachada_FechaCantidadCodigoProductoMontoObservacionesCodigoFacturaDiasAtraso");

            entity.HasIndex(e => e.CodigoEstadoDeVenta, "IDX_Venta_CodigoEstadoDeVenta_CantidadCodigoProductoMontoCodigoFacturaMontoproveedor");

            entity.HasIndex(e => e.CodigoEstadoDeVenta, "IDX_Venta_CodigoEstadoDeVenta_CodigoEstadoEntrega");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoFactura }, "IDX_Venta_CodigoEstadoDeVenta_CodigoFactura");

            entity.HasIndex(e => e.CodigoEstadoDeVenta, "IDX_Venta_CodigoEstadoDeVenta_FechaCodigoProductoCodigoCliente");

            entity.HasIndex(e => e.CodigoEstadoEntrega, "IDX_Venta_CodigoEstadoEntrega");

            entity.HasIndex(e => e.CodigoFactura, "IDX_Venta_CodigoFactura");

            entity.HasIndex(e => new { e.CodigoFactura, e.CodigoIncidenciaVenta, e.CodigoVenta }, "IDX_Venta_CodigoFacturaCodigoIncidenciaVentaCodigoVenta");

            entity.HasIndex(e => new { e.CodigoFormaDePago, e.CodigoEstadoDeVenta, e.CodigoCliente, e.Fecha, e.FechaConfirmacion }, "IDX_Venta_CodigoFormaDePagoCodigoEstadoDeVentaCodigoClienteFechaFechaConfirmacion");

            entity.HasIndex(e => e.CodigoPolizaArancel, "IDX_Venta_CodigoPolizaArancel");

            entity.HasIndex(e => e.CodigoPolizaInventario, "IDX_Venta_CodigoPolizaInventario");

            entity.HasIndex(e => e.CodigoProducto, "IDX_Venta_CodigoProducto");

            entity.HasIndex(e => new { e.Confirmada, e.CodigoCliente, e.CodigoVenta }, "IDX_Venta_Confimada_CodigoCliente_codigoventa");

            entity.HasIndex(e => e.Confirmada, "IDX_Venta_Confirmada").IsDescending();

            entity.HasIndex(e => new { e.Confirmada, e.CodigoEstadoDeVenta, e.CodigoFactura, e.Fecha }, "IDX_Venta_ConfirmadaCodEstadoDeVentaCodFacturaFecha");

            entity.HasIndex(e => new { e.Confirmada, e.CodigoEstadoDeVenta, e.CodigoFactura }, "IDX_Venta_ConfirmadaCodigoEstadoDeVentaCodigoFactura");

            entity.HasIndex(e => new { e.Confirmada, e.CodigoEstadoDeVenta }, "IDX_Venta_ConfirmadaCodigoEstadoDeVenta_CodigoFactura");

            entity.HasIndex(e => new { e.Confirmada, e.CodigoEstadoDeVenta }, "IDX_Venta_ConfirmadaCodigoEstadoDeVenta_CodigoFacturaFechaConfirmacion");

            entity.HasIndex(e => new { e.Confirmada, e.CodigoEstadoDeVenta }, "IDX_Venta_ConfirmadaCodigoEstadoDeVenta_CodigoProductoCodigoFactura");

            entity.HasIndex(e => new { e.Confirmada, e.CodigoEstadoDeVenta }, "IDX_Venta_ConfirmadaCodigoEstadoDeVenta_CodigoProductoProductoVerificadoDespachada");

            entity.HasIndex(e => new { e.Confirmada, e.CodigoEstadoEntrega, e.CodigoFactura, e.FechaEntrega }, "IDX_Venta_ConfirmadaCodigoEstadoEntregaCodigoFacturaFechaEntrega_CorreoCliente");

            entity.HasIndex(e => new { e.Confirmada, e.EnPreorden, e.CodigoEstadoDeVenta, e.CodigoFactura }, "IDX_Venta_ConfirmadaEnPreordenCodigoEstadoDeVentaCodigoFactura");

            entity.HasIndex(e => new { e.Confirmada, e.EnPreorden, e.Fecha }, "IDX_Venta_ConfirmadaEnPreordenFecha_CantidadCodProductoCodFacturaMontoProveedor");

            entity.HasIndex(e => new { e.Confirmada, e.EnPreorden }, "IDX_Venta_ConfirmadaEnPreorden_CantidadCodigoProductoMonto");

            entity.HasIndex(e => new { e.Confirmada, e.Monto, e.CodigoFactura }, "IDX_Venta_ConfirmadaMontoCodigoFactura");

            entity.HasIndex(e => e.CorreoCliente, "IDX_Venta_CorreoCliente");

            entity.HasIndex(e => new { e.EnPreorden, e.CodigoEstadoDeVenta, e.CodigoCliente, e.CodigoVenta, e.Fecha }, "IDX_Venta_EnPreordenCodigoEstadoDeVentaCodigoClienteCodigoVentaFecha");

            entity.HasIndex(e => e.EsPedido, "IDX_Venta_EsPedido").IsDescending();

            entity.HasIndex(e => new { e.EsPedido, e.CodigoFactura }, "IDX_Venta_EsPedidoCodigoFactura");

            entity.HasIndex(e => new { e.EsPedido, e.CodigoFactura, e.Confirmada, e.CodigoVenta }, "IDX_Venta_EsPedido_CodFacturaConfirmadaCodVenta_Cantidad");

            entity.HasIndex(e => new { e.EsPedido, e.Despachada, e.CodigoEstadoDeVenta }, "IDX_Venta_EspedidoDespachadaCodigoEstadoDeVenta_CodigoFactura");

            entity.HasIndex(e => e.CodigoEstadoDeVenta, "IDX_Venta_EstadoDeVenta");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.EsPedido, e.Despachada }, "IDX_Venta_EstadoPedidoEsPedidoDespachada_CodVentaCodProd");

            entity.HasIndex(e => e.Factura, "IDX_Venta_Factura");

            entity.HasIndex(e => e.Fecha, "IDX_Venta_Fecha").IsDescending();

            entity.HasIndex(e => e.FechaVerificacion, "IDX_Venta_FechaVerificacion_codigoFacturaUsuarioVerificacion");

            entity.HasIndex(e => e.Fecha, "IDX_Venta_Fecha_NombreClienteCantidadProductoCodigoProductoMontoEnPreordenCodigoEstadoDeVenta");

            entity.HasIndex(e => new { e.Monto, e.CodigoEstadoDeVenta }, "IDX_Venta_MontoCodigoEstadoDeVenta_CorreoClienteTelefono");

            entity.HasIndex(e => e.NombreCliente, "IDX_Venta_NombreCliente");

            entity.HasIndex(e => new { e.ProductoVerificado, e.CodigoFactura, e.CodigoVenta, e.CodigoEstadoDeVenta, e.EsPedido, e.CodigoProducto }, "IDX_Venta_ProductoVerificadoCodigoFacturaCodigoVentaCodigoEstadoDeVentaEsPedidoCodigoProducto_Cantidad");

            entity.HasIndex(e => new { e.UsuarioVerificacion, e.FechaVerificacion }, "IDX_Venta_UsuarioVerificacionFechaVerificacion_CodigoFactura");

            entity.HasIndex(e => new { e.Confirmada, e.CodigoEstadoDeVenta, e.EsPedido, e.CodigoIncidenciaVenta }, "Venta_ConfirmaCodigoEstadoDeVentaEsPedidoCodigoIncidenciaVenta_CodigoFacturaDiasAtrasoDiasEntrega");

            entity.HasIndex(e => new { e.Confirmada, e.CodigoEstadoDeVenta, e.CodigoFactura, e.CodigoVenta, e.EsPedido, e.CodigoIncidenciaVenta }, "_dta_index_Venta_6_1552426824__K13D_K39_K49_K1_K54_K79_80_89").IsDescending(true, false, false, false, false, false);

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoProducto, e.CodigoVenta, e.Fecha }, "_dta_index_Venta_6_1552426824__K39_K6_K1_K2");

            entity.HasIndex(e => new { e.CodigoEstadoDeVenta, e.CodigoEstadoEntrega, e.EsPedido, e.Despachada, e.CodigoVenta, e.Confirmada, e.DespachoProveedor, e.FechaDespachoProveedor }, "_dta_index_Venta_6_1552426824__K39_K70_K54_K56_K1_K13_K75_K74");

            entity.HasIndex(e => new { e.CodigoFactura, e.CodigoVenta, e.CodigoProducto, e.CodigoEstadoDeVenta, e.EsPedido, e.Despachada }, "_dta_index_Venta_6_1552426824__K49_K1_K6_K39_K54_K56");

            entity.HasIndex(e => new { e.CodigoFactura, e.CodigoEstadoDeVenta, e.EsPedido, e.Despachada, e.CodigoVenta }, "_dta_index_Venta_6_1552426824__K49_K39_K54_K56_K1");

            entity.HasIndex(e => new { e.EsPedido, e.CodigoProducto, e.CodigoVenta, e.CodigoEstadoDeVenta, e.Despachada, e.Cantidad }, "_dta_index_Venta_6_1552426824__K54D_K6_K1_K39_K56_K5").IsDescending(true, false, false, false, false, false);

            entity.HasIndex(e => new { e.Despachada, e.CodigoFactura, e.CodigoEstadoDeVenta, e.EsPedido, e.CodigoVenta, e.CodigoProducto }, "_dta_index_Venta_6_1552426824__K56_K49_K39_K54_K1_K6");

            entity.HasIndex(e => e.CodigoProducto, "_dta_index_Venta_6_1552426824__K6_2");

            entity.HasIndex(e => new { e.CodigoProducto, e.Confirmada, e.CorreoCliente }, "_dta_index_Venta_6_1552426824__K6_K13_K4_1_2");

            entity.Property(e => e.Autenticada)
                .IsRequired()
                .HasDefaultValueSql("('0')");
            entity.Property(e => e.BoletaDeposito)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClienteAnula).HasDefaultValue(false);
            entity.Property(e => e.CodigoSeguridad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodigoSms)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CodigoSMS");
            entity.Property(e => e.ComentarioVerificacion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CorreoCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DatosDeSeguridad)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.De)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Despacho)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.DireccionDeEntrega)
                .HasMaxLength(900)
                .IsUnicode(false);
            entity.Property(e => e.DireccionDeEntregaAnterior)
                .HasMaxLength(900)
                .IsUnicode(false);
            entity.Property(e => e.EmpaqueRegalo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Factura).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaClienteAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaConfirmacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDespachada).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDespachoProveedor).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaDesverificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaUsuarioModificaFormaPago).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FotoVerificacion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Llamada11)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Llamada12)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Llamada21)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LLamada21");
            entity.Property(e => e.Llamada22)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoCuota).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoProveedor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(900)
                .IsUnicode(false);
            entity.Property(e => e.NombreRecibido)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumeroAutorizacion)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.NumeroTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(900)
                .IsUnicode(false);
            entity.Property(e => e.Para)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductoComprado).HasDefaultValue(false);
            entity.Property(e => e.ReferenciaCobroTarjeta)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Telefonos)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalVenta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UbicacionEntrega).IsUnicode(false);
            entity.Property(e => e.VencimientoTarjeta)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoClienteNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoCliente)
                .HasConstraintName("FK_Venta_Cliente");

            entity.HasOne(d => d.CodigoEmpaqueDeRegaloNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoEmpaqueDeRegalo)
                .HasConstraintName("FK_Venta_EmpaqueDeRegalo");

            entity.HasOne(d => d.CodigoEstadoDeVentaNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoEstadoDeVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_EstadoDeVenta");

            entity.HasOne(d => d.CodigoEstadoEntregaNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoEstadoEntrega)
                .HasConstraintName("FK_Venta_EstadoEntrega");

            entity.HasOne(d => d.CodigoFacturaNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoFactura)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Venta_Factura");

            entity.HasOne(d => d.CodigoFormaDePagoNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoFormaDePago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_FormaDePago");

            entity.HasOne(d => d.CodigoIncidenciaVentaNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoIncidenciaVenta)
                .HasConstraintName("FK__Venta__CodigoInc__28275755");

            entity.HasOne(d => d.CodigoPolizaArancelNavigation).WithMany(p => p.VentumCodigoPolizaArancelNavigations)
                .HasForeignKey(d => d.CodigoPolizaArancel)
                .HasConstraintName("FK_CodigoPolizaArancel");

            entity.HasOne(d => d.CodigoPolizaInventarioNavigation).WithMany(p => p.VentumCodigoPolizaInventarioNavigations)
                .HasForeignKey(d => d.CodigoPolizaInventario)
                .HasConstraintName("FK_CodigoPolizaInventario");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoProducto)
                .HasConstraintName("FK_Venta_Producto");

            entity.HasOne(d => d.CodigoRazonAnulacionVentaNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoRazonAnulacionVenta)
                .HasConstraintName("FK_Venta_CodigoRazonAnulacionVenta");

            entity.HasOne(d => d.CodigoRedCrediticiaNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoRedCrediticia)
                .HasConstraintName("FK_Venta_RedCrediticia");

            entity.HasOne(d => d.CodigoTipoDeTarjetaNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoTipoDeTarjeta)
                .HasConstraintName("FK_Venta_TipoDeTarjeta");

            entity.HasOne(d => d.CodigoUbicacionDespachoNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CodigoUbicacionDespacho)
                .HasConstraintName("FK__Venta__CodigoUbi__10007375");

            entity.HasOne(d => d.CodigoUsuarioCambioPrecioNavigation).WithMany(p => p.VentumCodigoUsuarioCambioPrecioNavigations)
                .HasForeignKey(d => d.CodigoUsuarioCambioPrecio)
                .HasConstraintName("FK_VENTA_CodigoUsuario");

            entity.HasOne(d => d.CodigoUsuarioDesverificacionNavigation).WithMany(p => p.VentumCodigoUsuarioDesverificacionNavigations)
                .HasForeignKey(d => d.CodigoUsuarioDesverificacion)
                .HasConstraintName("FK_Venta_UsuarioDesverificacion");

            entity.HasOne(d => d.CodigoUsuarioEntregaNavigation).WithMany(p => p.VentumCodigoUsuarioEntregaNavigations)
                .HasForeignKey(d => d.CodigoUsuarioEntrega)
                .HasConstraintName("FK_CodigoUsuarioEntrega_Venta_Entrega");

            entity.HasOne(d => d.CodigoUsuarioModificaFormaPagoNavigation).WithMany(p => p.VentumCodigoUsuarioModificaFormaPagoNavigations)
                .HasForeignKey(d => d.CodigoUsuarioModificaFormaPago)
                .HasConstraintName("FK_UsuarioModificaFormaPago");

            entity.HasOne(d => d.UsuarioDepositoNavigation).WithMany(p => p.VentumUsuarioDepositoNavigations)
                .HasForeignKey(d => d.UsuarioDeposito)
                .HasConstraintName("FK_Venta_UsuarioDeposito");

            entity.HasOne(d => d.UsuarioTarjetaNavigation).WithMany(p => p.VentumUsuarioTarjetaNavigations)
                .HasForeignKey(d => d.UsuarioTarjeta)
                .HasConstraintName("FK_Venta_UsuarioTarjeta");

            entity.HasOne(d => d.UsuarioValidacionNavigation).WithMany(p => p.VentumUsuarioValidacionNavigations)
                .HasForeignKey(d => d.UsuarioValidacion)
                .HasConstraintName("FK__Venta__UsuarioVa__09947BB9");

            entity.HasOne(d => d.UsuarioVerificacionNavigation).WithMany(p => p.VentumUsuarioVerificacionNavigations)
                .HasForeignKey(d => d.UsuarioVerificacion)
                .HasConstraintName("FK__Venta__UsuarioVe__6475CD0A");
        });

        modelBuilder.Entity<VerificacionEmbarque>(entity =>
        {
            entity.HasKey(e => e.CodigoVerificacionEmbarque).HasName("PK__VerificacionEmbarque");

            entity.ToTable("VerificacionEmbarque");

            entity.HasIndex(e => e.CodigoDeRastreo, "IDX_VerificacionEmbarque_CodigoDeRastreo");

            entity.HasIndex(e => e.CodigoEmbarque, "IDX_VerificacionEmbarque_CodigoEmbarque");

            entity.HasIndex(e => e.CodigoPedido, "IDX_VerificacionEmbarque_CodigoPedido");

            entity.HasIndex(e => e.CodigoProducto, "IDX_VerificacionEmbarque_CodigoProducto");

            entity.HasIndex(e => e.Upc, "IDX_VerificacionEmbarque_UPC");

            entity.Property(e => e.CodigoDeRastreo)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.CodigoEmbarque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComentarioVerificacion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FotoVerificacion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Upc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPC");

            entity.HasOne(d => d.CodigoEmbarqueNavigation).WithMany(p => p.VerificacionEmbarques)
                .HasForeignKey(d => d.CodigoEmbarque)
                .HasConstraintName("FK_VerificacionEmbarque_Embarque");

            entity.HasOne(d => d.CodigoPedidoNavigation).WithMany(p => p.VerificacionEmbarques)
                .HasForeignKey(d => d.CodigoPedido)
                .HasConstraintName("FK_VerificacionEmbarque_Pedido");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.VerificacionEmbarques)
                .HasForeignKey(d => d.CodigoProducto)
                .HasConstraintName("FK_VerificacionEmbarque_Product");

            entity.HasOne(d => d.CodigoUsuarioNavigation).WithMany(p => p.VerificacionEmbarques)
                .HasForeignKey(d => d.CodigoUsuario)
                .HasConstraintName("FK_VerificacionEmbarque_Usuario");
        });

        modelBuilder.Entity<VerificacionEmpaque>(entity =>
        {
            entity.HasKey(e => e.CodigoVerificacionEmpaque).HasName("PK_VerificacionEmpaque_CodigoVerificaEmpaque");

            entity.ToTable("VerificacionEmpaque");

            entity.Property(e => e.FechaVerificacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Upc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UPC");

            entity.HasOne(d => d.CodigoUsuarioVerificacionNavigation).WithMany(p => p.VerificacionEmpaques)
                .HasForeignKey(d => d.CodigoUsuarioVerificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VerificacionEmpaque_CodigoUsuairo");

            entity.HasOne(d => d.CodigoVentaNavigation).WithMany(p => p.VerificacionEmpaques)
                .HasForeignKey(d => d.CodigoVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VerificacionEmpaque_CodigoVenta");
        });

        modelBuilder.Entity<VerificacionInventario>(entity =>
        {
            entity.HasKey(e => e.CodigoVerificacionInventario).HasName("PK__VerificacionInventario");

            entity.ToTable("VerificacionInventario");

            entity.HasIndex(e => e.CodigoProducto, "IDX_VerificacionCodigoProducto_CodigoInventarioCodigoUsuarioFecha");

            entity.HasIndex(e => new { e.CodigoInventario, e.Upc }, "IDX_VerificacionInventario_CodigoInventario-UPC");

            entity.HasIndex(e => new { e.CodigoInventario, e.CodigoProducto }, "IDX_VerificacionInventario_CodigoInventarioCodigoProducto");

            entity.HasIndex(e => new { e.CodigoInventario, e.CodigoUsuario }, "IDX_VerificacionInventario_CodigoInventarioCodigoUsuario_UPCFecha");

            entity.HasIndex(e => e.CodigoInventario, "IDX_VerificacionInventario_CodigoInventario_UPCCodigoUsuarioFechaCodigoProducto");

            entity.HasIndex(e => e.CodigoUsuario, "IDX_VerificacionInventario_CodigoUsuario_CodigInventarioUPCFecha");

            entity.HasIndex(e => e.Upc, "VerificacionInventario_UPC");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Upc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPC");

            entity.HasOne(d => d.CodigoInventarioNavigation).WithMany(p => p.VerificacionInventarios)
                .HasForeignKey(d => d.CodigoInventario)
                .HasConstraintName("FK__Inventario_CodigoInventario");

            entity.HasOne(d => d.CodigoProductoNavigation).WithMany(p => p.VerificacionInventarios)
                .HasForeignKey(d => d.CodigoProducto)
                .HasConstraintName("FK_CodigoProducto_Producto");
        });

        modelBuilder.Entity<VerificacionInventarioUbicacion>(entity =>
        {
            entity.HasKey(e => e.CodigoVerificacionInventarioUbicacion).HasName("PK__Verifica__796EBF291A430B6C");

            entity.ToTable("VerificacionInventarioUbicacion");

            entity.HasIndex(e => e.CodigoInventario, "IDX_VerificacionInventarioUbicacion_CodigoInventario_CodigoUbicacion");

            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CodigoInventarioNavigation).WithMany(p => p.VerificacionInventarioUbicacions)
                .HasForeignKey(d => d.CodigoInventario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Inventario");

            entity.HasOne(d => d.CodigoUbicacionNavigation).WithMany(p => p.VerificacionInventarioUbicacions)
                .HasForeignKey(d => d.CodigoUbicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_UbicacionBodega");
        });

        modelBuilder.Entity<VwSalidaDispositivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSalidaDispositivos");

            entity.Property(e => e.Asignado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Serie)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwServicioPagoEfectivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ServicioPagoEfectivo");

            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Revision)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Webhook>(entity =>
        {
            entity.HasKey(e => e.CodigoWebhook).HasName("PK_Webhook_CodigoWebhook");

            entity.ToTable("Webhook");

            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Url).IsUnicode(false);
        });

        modelBuilder.Entity<ZonaRoja>(entity =>
        {
            entity.HasKey(e => e.CodigoZonaRoja).HasName("PK__ZonaRoja__311ACF5062BEB358");

            entity.ToTable("ZonaRoja");

            entity.Property(e => e.Lugar)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(700)
                .IsUnicode(false);

            entity.HasOne(d => d.CodigoMunicipioNavigation).WithMany(p => p.ZonaRojas)
                .HasForeignKey(d => d.CodigoMunicipio)
                .HasConstraintName("FK__ZonaRoja__Codigo__71E35F0F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

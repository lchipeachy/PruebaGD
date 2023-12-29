using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Usuario
{
    public int CodigoUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Usuario1 { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Conectado { get; set; }

    public int? CodigoPerfilDeImpresion { get; set; }

    public int Reembolso { get; set; }

    public int Cobro { get; set; }

    public bool ModificaPedido { get; set; }

    public bool RevisionProductos { get; set; }

    public bool Bancos { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaInicio { get; set; }

    public bool? ModificaUsuarios { get; set; }

    public bool? GestionaPedido { get; set; }

    public bool? RevisionGastos { get; set; }

    public bool? MostrarTarjetaCredito { get; set; }

    public string? Horario { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono1 { get; set; }

    public string? Telefono2 { get; set; }

    public string? ContactoEmergencia { get; set; }

    public bool? ModificaDispositivo { get; set; }

    public int? CodigoDepartamentoEmpresa { get; set; }

    public bool? ModificaCantidadProducto { get; set; }

    public bool CierreContable { get; set; }

    public bool ReversionContable { get; set; }

    public bool? ModificaVacaciones { get; set; }

    public string? DispositivoEntrega { get; set; }

    public bool? MensajeroExterno { get; set; }

    public bool? ModificaPaquete { get; set; }

    public bool? ModificaParametro { get; set; }

    public bool? ModificaPrecio { get; set; }

    public TimeOnly? HoraEntrada { get; set; }

    public TimeOnly? HoraSalida { get; set; }

    public bool? ModificaCuentaCompra { get; set; }

    public bool? AccesoRemoto { get; set; }

    public string? PuestoDeTrabajoNombre { get; set; }

    public string? PuestoDeTrabajoClave { get; set; }

    public bool? Metricas { get; set; }

    public bool? EstadoUsuarioExterno { get; set; }

    public bool? ProductoCombinado { get; set; }

    public DateTime? FechaModificacionPassword { get; set; }

    public bool? ModificaObservacionDeEntrega { get; set; }

    public string? DescriptorDePuesto { get; set; }

    public bool? AsignarAnomalia { get; set; }

    public DateTime? FechaDeBaja { get; set; }

    public string? Dpi { get; set; }

    public DateTime? FechaDeNacimiento { get; set; }

    public string? Profesion { get; set; }

    public bool? DatosPrivados { get; set; }

    public bool? AnulaFactura { get; set; }

    public int HoraAlmuerzo { get; set; }

    public bool? ModificaVales { get; set; }

    public bool JornadaCompleta { get; set; }

    public bool? PermisoModificarImportadores { get; set; }

    public string? Correo { get; set; }

    public int Genero { get; set; }

    public int? CodigoEstadoCivil { get; set; }

    public bool ModificaMensajeroExterno { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Pais { get; set; }

    public string? DepartamentoNacimiento { get; set; }

    public string? MunicipioNacimiento { get; set; }

    public string? MotivoBaja { get; set; }

    public string? DepartamentoResidencia { get; set; }

    public string? MunicipioResidencia { get; set; }

    public int? CodigoGradoUniversitario { get; set; }

    public int Reingreso { get; set; }

    public TimeOnly? HorarioSalidaAlmuerzo { get; set; }

    public TimeOnly? HorarioEntradaAlmuerzo { get; set; }

    public DateOnly? FechaSuscripcionContrato { get; set; }

    public string? Cargo { get; set; }

    public string? Nit { get; set; }

    public string? Irtra { get; set; }

    public DateOnly? VencimientoIrtra { get; set; }

    public string? Licencia { get; set; }

    public string? Igss { get; set; }

    public int AntecedentesPenales { get; set; }

    public int AntecedentesPoliciacos { get; set; }

    public int? CodigoTipoContrato { get; set; }

    public string? DepartamentoDpiExtendido { get; set; }

    public string? MunicipioDpiExtendido { get; set; }

    public int CodigoBanco { get; set; }

    public long? Cuenta { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public int? CodigoUsuarioModificacionPermiso { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public DateTime? FechaModificacionPermiso { get; set; }

    public string? CamposModificados { get; set; }

    public bool AdministrarDocumento { get; set; }

    public bool ModificaEstablecimiento { get; set; }

    public bool ModificaServicio { get; set; }

    public bool ExpiraPassword { get; set; }

    public int? CodigoTipoJornada { get; set; }

    public bool GeneraCorreoIngreso { get; set; }

    public bool ModificaTipoLicenciaVacaciones { get; set; }

    public bool GestionaPromocion { get; set; }

    public bool? ModificaFormaPagoDireccion { get; set; }

    public string? RedSocialDeTrabajo { get; set; }

    public string? CorreoEmpresarial { get; set; }

    public bool DesverificaProductoVenta { get; set; }

    public bool ModificaEmpresaEntrega { get; set; }

    public bool? EliminaTransaccionConciliacionBancaria { get; set; }

    public bool? ModificaCaby { get; set; }

    public bool? ModificaDatosGuia { get; set; }

    public bool? ModificaFormaPago { get; set; }

    public bool? RevisionAjusteCuenta { get; set; }

    public bool? GestionaAccesoServicio { get; set; }

    public virtual ICollection<AdministracionDocumento> AdministracionDocumentoCodigoUsuarioCreacionNavigations { get; set; } = new List<AdministracionDocumento>();

    public virtual ICollection<AdministracionDocumento> AdministracionDocumentoCodigoUsuarioDocumentoNavigations { get; set; } = new List<AdministracionDocumento>();

    public virtual ICollection<AdministracionDocumento> AdministracionDocumentoCodigoUsuarioEliminacionNavigations { get; set; } = new List<AdministracionDocumento>();

    public virtual ICollection<Alertum> AlertumCodigoUsuarioCreacionNavigations { get; set; } = new List<Alertum>();

    public virtual ICollection<Alertum> AlertumCodigoUsuarioModificacionNavigations { get; set; } = new List<Alertum>();

    public virtual ICollection<Anuncio> Anuncios { get; set; } = new List<Anuncio>();

    public virtual ICollection<AplicacionPlaza> AplicacionPlazaCodigoUsuarioAprobacionNavigations { get; set; } = new List<AplicacionPlaza>();

    public virtual ICollection<AplicacionPlaza> AplicacionPlazaCodigoUsuarioRechazoNavigations { get; set; } = new List<AplicacionPlaza>();

    public virtual ICollection<ArchivoPaquete> ArchivoPaqueteCodigoUsuarioEliminaNavigations { get; set; } = new List<ArchivoPaquete>();

    public virtual ICollection<ArchivoPaquete> ArchivoPaqueteCodigoUsuarioRegistroNavigations { get; set; } = new List<ArchivoPaquete>();

    public virtual ICollection<Archivo> Archivos { get; set; } = new List<Archivo>();

    public virtual ICollection<BitacoraGestionFactura> BitacoraGestionFacturas { get; set; } = new List<BitacoraGestionFactura>();

    public virtual ICollection<BitacoraRegimenProveedor> BitacoraRegimenProveedors { get; set; } = new List<BitacoraRegimenProveedor>();

    public virtual ICollection<Categorium> Categoria { get; set; } = new List<Categorium>();

    public virtual ICollection<CierreContable> CierreContableCodigoUsuarioNavigations { get; set; } = new List<CierreContable>();

    public virtual ICollection<CierreContable> CierreContableCodigoUsuarioReversionNavigations { get; set; } = new List<CierreContable>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Cobro> CobroCodigoUsuarioCapturaNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroCodigoUsuarioCreacionNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroCodigoUsuarioModificacionNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroUsuarioCobroNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroUsuarioCreditoNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroUsuarioDepositoNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroUsuarioEfectivoNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroUsuarioExencionNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroUsuarioPagoNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroUsuarioRevisionNavigations { get; set; } = new List<Cobro>();

    public virtual ICollection<Cobro> CobroUsuarioTarjetaNavigations { get; set; } = new List<Cobro>();

    public virtual Banco CodigoBancoNavigation { get; set; } = null!;

    public virtual ICollection<CodigoCanjeable> CodigoCanjeableCodigoUsuarioCreacionNavigations { get; set; } = new List<CodigoCanjeable>();

    public virtual ICollection<CodigoCanjeable> CodigoCanjeableCodigoUsuarioInactivoNavigations { get; set; } = new List<CodigoCanjeable>();

    public virtual ICollection<CodigoCanjeable> CodigoCanjeableCodigoUsuarioModificacionNavigations { get; set; } = new List<CodigoCanjeable>();

    public virtual DepartamentoEmpresa? CodigoDepartamentoEmpresaNavigation { get; set; }

    public virtual EstadoCivil? CodigoEstadoCivilNavigation { get; set; }

    public virtual GradoUniversitario? CodigoGradoUniversitarioNavigation { get; set; }

    public virtual PerfilDeImpresion? CodigoPerfilDeImpresionNavigation { get; set; }

    public virtual TipoContrato? CodigoTipoContratoNavigation { get; set; }

    public virtual TipoJornadum? CodigoTipoJornadaNavigation { get; set; }

    public virtual ICollection<ConciliacionBancarium> ConciliacionBancariumCodigoUsuarioIngresoNavigations { get; set; } = new List<ConciliacionBancarium>();

    public virtual ICollection<ConciliacionBancarium> ConciliacionBancariumCodigoUsuarioModificacionNavigations { get; set; } = new List<ConciliacionBancarium>();

    public virtual ICollection<ContraCargo> ContraCargoCodigoUsuarioCreacionNavigations { get; set; } = new List<ContraCargo>();

    public virtual ICollection<ContraCargo> ContraCargoCodigoUsuarioModificacionNavigations { get; set; } = new List<ContraCargo>();

    public virtual ICollection<CorreoNotificacionGarantium> CorreoNotificacionGarantia { get; set; } = new List<CorreoNotificacionGarantium>();

    public virtual ICollection<CorreoPersonalizado> CorreoPersonalizadoCodigoUsuarioCreacionNavigations { get; set; } = new List<CorreoPersonalizado>();

    public virtual ICollection<CorreoPersonalizado> CorreoPersonalizadoCodigoUsuarioModificacionNavigations { get; set; } = new List<CorreoPersonalizado>();

    public virtual ICollection<Cuentum> CuentaNavigation { get; set; } = new List<Cuentum>();

    public virtual ICollection<DepositoEmpresaEntrega> DepositoEmpresaEntregaCodigoUsuarioDepositoNavigations { get; set; } = new List<DepositoEmpresaEntrega>();

    public virtual ICollection<DepositoEmpresaEntrega> DepositoEmpresaEntregaCodigoUsuarioModificacionNavigations { get; set; } = new List<DepositoEmpresaEntrega>();

    public virtual ICollection<DireccionImportador> DireccionImportadorCodigoUsuarioCreacionNavigations { get; set; } = new List<DireccionImportador>();

    public virtual ICollection<DireccionImportador> DireccionImportadorCodigoUsuarioModificacionNavigations { get; set; } = new List<DireccionImportador>();

    public virtual ICollection<Dispositivo> DispositivoCodigoUsuarioAsignadoNavigations { get; set; } = new List<Dispositivo>();

    public virtual ICollection<Dispositivo> DispositivoCodigoUsuarioBajaNavigations { get; set; } = new List<Dispositivo>();

    public virtual ICollection<Dispositivo> DispositivoCodigoUsuarioModificacionNavigations { get; set; } = new List<Dispositivo>();

    public virtual ICollection<EmpresaEntregaBitacora> EmpresaEntregaBitacoras { get; set; } = new List<EmpresaEntregaBitacora>();

    public virtual ICollection<Entradum> Entrada { get; set; } = new List<Entradum>();

    public virtual ICollection<ErrorApi> ErrorApis { get; set; } = new List<ErrorApi>();

    public virtual ICollection<Factura> FacturaCodigoUsuarioAnulacionNavigations { get; set; } = new List<Factura>();

    public virtual ICollection<Factura> FacturaCodigoUsuarioDespachoNavigations { get; set; } = new List<Factura>();

    public virtual ICollection<Factura> FacturaCodigoUsuarioModificaDireccionNavigations { get; set; } = new List<Factura>();

    public virtual ICollection<Gasto> GastoCodigoUsuarioModificaGastoNoDeducibleNavigations { get; set; } = new List<Gasto>();

    public virtual ICollection<Gasto> GastoCodigoUsuarioModificacionNavigations { get; set; } = new List<Gasto>();

    public virtual ICollection<Gasto> GastoCodigoUsuarioNavigations { get; set; } = new List<Gasto>();

    public virtual ICollection<GuiaEliminadum> GuiaEliminada { get; set; } = new List<GuiaEliminadum>();

    public virtual ICollection<HistoricoVale> HistoricoVales { get; set; } = new List<HistoricoVale>();

    public virtual ICollection<ImagenContraCargo> ImagenContraCargoCodigoUsuarioCreacionNavigations { get; set; } = new List<ImagenContraCargo>();

    public virtual ICollection<ImagenContraCargo> ImagenContraCargoCodigoUsuarioEliminacionNavigations { get; set; } = new List<ImagenContraCargo>();

    public virtual ICollection<ImagenGarantium> ImagenGarantia { get; set; } = new List<ImagenGarantium>();

    public virtual ICollection<ImagenGasto> ImagenGastoCodigoUsuarioCreacionNavigations { get; set; } = new List<ImagenGasto>();

    public virtual ICollection<ImagenGasto> ImagenGastoCodigoUsuarioEliminacionNavigations { get; set; } = new List<ImagenGasto>();

    public virtual ICollection<ImagenGuiaReclamadum> ImagenGuiaReclamadumCodigoUsuarioCreacionNavigations { get; set; } = new List<ImagenGuiaReclamadum>();

    public virtual ICollection<ImagenGuiaReclamadum> ImagenGuiaReclamadumCodigoUsuarioEliminacionNavigations { get; set; } = new List<ImagenGuiaReclamadum>();

    public virtual ICollection<ImagenPaqueteReclamadum> ImagenPaqueteReclamadumCodigoUsuarioCreacionNavigations { get; set; } = new List<ImagenPaqueteReclamadum>();

    public virtual ICollection<ImagenPaqueteReclamadum> ImagenPaqueteReclamadumCodigoUsuarioEliminacionNavigations { get; set; } = new List<ImagenPaqueteReclamadum>();

    public virtual ICollection<ImagenPolizaDeImportacion> ImagenPolizaDeImportacionCodigoUsuarioCreacionNavigations { get; set; } = new List<ImagenPolizaDeImportacion>();

    public virtual ICollection<ImagenPolizaDeImportacion> ImagenPolizaDeImportacionCodigoUsuarioEliminacionNavigations { get; set; } = new List<ImagenPolizaDeImportacion>();

    public virtual ICollection<Importador> Importadors { get; set; } = new List<Importador>();

    public virtual ICollection<IntentoDeEntrega> IntentoDeEntregas { get; set; } = new List<IntentoDeEntrega>();

    public virtual ICollection<MovimientoEstadoGarantium> MovimientoEstadoGarantia { get; set; } = new List<MovimientoEstadoGarantium>();

    public virtual ICollection<MovimientoGarantium> MovimientoGarantia { get; set; } = new List<MovimientoGarantium>();

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();

    public virtual ICollection<PaqueteReclamado> PaqueteReclamadoCodigoUsuarioCambioEstadoNavigations { get; set; } = new List<PaqueteReclamado>();

    public virtual ICollection<PaqueteReclamado> PaqueteReclamadoCodigoUsuarioModificacionNavigations { get; set; } = new List<PaqueteReclamado>();

    public virtual ICollection<PaqueteReclamado> PaqueteReclamadoCodigoUsuarioReclamoNavigations { get; set; } = new List<PaqueteReclamado>();

    public virtual ICollection<Paquete> Paquetes { get; set; } = new List<Paquete>();

    public virtual ICollection<Parametro> Parametros { get; set; } = new List<Parametro>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<PlantillaCorreo> PlantillaCorreoCodigoUsuarioCreacionNavigations { get; set; } = new List<PlantillaCorreo>();

    public virtual ICollection<PlantillaCorreo> PlantillaCorreoCodigoUsuarioInactivoNavigations { get; set; } = new List<PlantillaCorreo>();

    public virtual ICollection<PlantillaCorreo> PlantillaCorreoCodigoUsuarioModificacionNavigations { get; set; } = new List<PlantillaCorreo>();

    public virtual ICollection<Plaza> PlazaCodigoUsuarioCreacionNavigations { get; set; } = new List<Plaza>();

    public virtual ICollection<Plaza> PlazaCodigoUsuarioEstadoNavigations { get; set; } = new List<Plaza>();

    public virtual ICollection<Plaza> PlazaCodigoUsuarioModificaNavigations { get; set; } = new List<Plaza>();

    public virtual ICollection<PolizaDeImportacion> PolizaDeImportacionCodigoUsuarioCreacionNavigations { get; set; } = new List<PolizaDeImportacion>();

    public virtual ICollection<PolizaDeImportacion> PolizaDeImportacionCodigoUsuarioModificacionNavigations { get; set; } = new List<PolizaDeImportacion>();

    public virtual ICollection<Prioridad> Prioridads { get; set; } = new List<Prioridad>();

    public virtual ICollection<ProductoCaby> ProductoCabyCodigoUsuarioAsociaCabyNavigations { get; set; } = new List<ProductoCaby>();

    public virtual ICollection<ProductoCaby> ProductoCabyCodigoUsuarioModificaCabyNavigations { get; set; } = new List<ProductoCaby>();

    public virtual ICollection<Producto> ProductoCodigoUsuarioModificaCategoriaManualNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoCodigoUsuarioModificaPrecioNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoCodigoUsuarioNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoCodigoUsuarioUbicacionBodegaNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Promocion> PromocionCodigoUsuarioCreacionNavigations { get; set; } = new List<Promocion>();

    public virtual ICollection<Promocion> PromocionCodigoUsuarioFinalizaNavigations { get; set; } = new List<Promocion>();

    public virtual ICollection<Promocion> PromocionCodigoUsuarioModificaNavigations { get; set; } = new List<Promocion>();

    public virtual ICollection<Proveedor> ProveedorCodigoUsuarioModificacionNavigations { get; set; } = new List<Proveedor>();

    public virtual ICollection<Proveedor> ProveedorCodigoUsuarioRegistroNavigations { get; set; } = new List<Proveedor>();

    public virtual ICollection<RazonAnulacionVentum> RazonAnulacionVentumCodigoUsuarioCreacionNavigations { get; set; } = new List<RazonAnulacionVentum>();

    public virtual ICollection<RazonAnulacionVentum> RazonAnulacionVentumCodigoUsuarioEliminacionNavigations { get; set; } = new List<RazonAnulacionVentum>();

    public virtual ICollection<RazonAnulacionVentum> RazonAnulacionVentumCodigoUsuarioModificacionNavigations { get; set; } = new List<RazonAnulacionVentum>();

    public virtual ICollection<RevisionProducto> RevisionProductosNavigation { get; set; } = new List<RevisionProducto>();

    public virtual ICollection<Tarea> TareaCodigoUsuarioEliminacionNavigations { get; set; } = new List<Tarea>();

    public virtual ICollection<Tarea> TareaCodigoUsuarioNavigations { get; set; } = new List<Tarea>();

    public virtual ICollection<Tarea> TareaCodigoUsuarioSupervisorNavigations { get; set; } = new List<Tarea>();

    public virtual ICollection<Tema> TemaCodigoUsuarioEliminaNavigations { get; set; } = new List<Tema>();

    public virtual ICollection<Tema> TemaCodigoUsuarioEncargadoNavigations { get; set; } = new List<Tema>();

    public virtual ICollection<Tema> TemaCodigoUsuarioUltimaModificacionNavigations { get; set; } = new List<Tema>();

    public virtual ICollection<TipoLicenciaVacacione> TipoLicenciaVacacioneCodigoUsuarioActivoNavigations { get; set; } = new List<TipoLicenciaVacacione>();

    public virtual ICollection<TipoLicenciaVacacione> TipoLicenciaVacacioneCodigoUsuarioCreacionNavigations { get; set; } = new List<TipoLicenciaVacacione>();

    public virtual ICollection<TipoLicenciaVacacione> TipoLicenciaVacacioneCodigoUsuarioModificaNavigations { get; set; } = new List<TipoLicenciaVacacione>();

    public virtual ICollection<Transaccion> TransaccionCodigoUsuarioModificacionNavigations { get; set; } = new List<Transaccion>();

    public virtual ICollection<Transaccion> TransaccionCodigoUsuarioNavigations { get; set; } = new List<Transaccion>();

    public virtual ICollection<UsuarioAplicacionExternaUsuario> UsuarioAplicacionExternaUsuarioCodigoUsuarioCreacionNavigations { get; set; } = new List<UsuarioAplicacionExternaUsuario>();

    public virtual ICollection<UsuarioAplicacionExternaUsuario> UsuarioAplicacionExternaUsuarioCodigoUsuarioInactivoNavigations { get; set; } = new List<UsuarioAplicacionExternaUsuario>();

    public virtual ICollection<UsuarioAplicacionExternaUsuario> UsuarioAplicacionExternaUsuarioCodigoUsuarioNavigations { get; set; } = new List<UsuarioAplicacionExternaUsuario>();

    public virtual ICollection<UsuarioAplicacionExterna> UsuarioAplicacionExternas { get; set; } = new List<UsuarioAplicacionExterna>();

    public virtual ICollection<Vacacion> VacacionCodigoUsuarioCreacionNavigations { get; set; } = new List<Vacacion>();

    public virtual ICollection<Vacacion> VacacionCodigoUsuarioEliminaNavigations { get; set; } = new List<Vacacion>();

    public virtual ICollection<Vacacion> VacacionCodigoUsuarioNavigations { get; set; } = new List<Vacacion>();

    public virtual ICollection<Ventum> VentumCodigoUsuarioCambioPrecioNavigations { get; set; } = new List<Ventum>();

    public virtual ICollection<Ventum> VentumCodigoUsuarioDesverificacionNavigations { get; set; } = new List<Ventum>();

    public virtual ICollection<Ventum> VentumCodigoUsuarioEntregaNavigations { get; set; } = new List<Ventum>();

    public virtual ICollection<Ventum> VentumCodigoUsuarioModificaFormaPagoNavigations { get; set; } = new List<Ventum>();

    public virtual ICollection<Ventum> VentumUsuarioDepositoNavigations { get; set; } = new List<Ventum>();

    public virtual ICollection<Ventum> VentumUsuarioTarjetaNavigations { get; set; } = new List<Ventum>();

    public virtual ICollection<Ventum> VentumUsuarioValidacionNavigations { get; set; } = new List<Ventum>();

    public virtual ICollection<Ventum> VentumUsuarioVerificacionNavigations { get; set; } = new List<Ventum>();

    public virtual ICollection<VerificacionEmbarque> VerificacionEmbarques { get; set; } = new List<VerificacionEmbarque>();

    public virtual ICollection<VerificacionEmpaque> VerificacionEmpaques { get; set; } = new List<VerificacionEmpaque>();
}

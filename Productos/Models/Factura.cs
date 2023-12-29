using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Factura
{
    public int CodigoFactura { get; set; }

    public string? SerieDeFactura { get; set; }

    public string? NumeroDeFactura { get; set; }

    public string? Nit { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public int? CodigoEmpresa { get; set; }

    public int? CodigoEstadoFactura { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalSinComisiones { get; set; }

    public string? Correo { get; set; }

    public string? SinFactura { get; set; }

    public string? Observaciones { get; set; }

    public int? CodigoCliente { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public decimal? TotalFactura { get; set; }

    public string? Telefonos { get; set; }

    public decimal? TotalPendiente { get; set; }

    public DateTime? FechaGuia { get; set; }

    public byte? NumeroManifiesto { get; set; }

    public decimal? TotalImpresionFactura { get; set; }

    public decimal? MontoServicioEnEfectivo { get; set; }

    public string? CodigoDeRastreo { get; set; }

    public DateTime? FechaEnvioFactura { get; set; }

    public string? Cae { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public string? NombreRecibido { get; set; }

    public int? CodigoResolucion { get; set; }

    public int? CodigoResolucionDeNotaCredito { get; set; }

    public string? SerieDeNotaCredito { get; set; }

    public decimal? NumeroDeNotaCredito { get; set; }

    public DateTime? FechaDeNotaCredito { get; set; }

    public string? ConceptoDeNotaCredito { get; set; }

    public bool? EsFacturaElectronica { get; set; }

    public string? CaedeNotaCredito { get; set; }

    public string? SerieDeFacturaReferencia { get; set; }

    public string? NumeroDeFacturaReferencia { get; set; }

    public int? CodigoEstadoEntregaFactura { get; set; }

    public DateTime? FechaRecepcionEmpresaDeEntrega { get; set; }

    public DateTime? FechaGeneracionGuia { get; set; }

    public short? CodigoEmpresaDeEntrega { get; set; }

    public bool? GuiaGenerada { get; set; }

    public DateTime? FechaAnulacion { get; set; }

    public int? CodigoUsuarioAnulacion { get; set; }

    public bool? NoGenerarGuia { get; set; }

    public decimal? PorcentajeRegimenFactura { get; set; }

    public string? ObservacionesGuia { get; set; }

    public int? CodigoPolizaMercaderia { get; set; }

    public int? CodigoPolizaServicio { get; set; }

    public int? CodigoFacturaAnulada { get; set; }

    public short? CodigoDepartamento { get; set; }

    public short? CodigoMunicipio { get; set; }

    public string? PruebaEntrega { get; set; }

    public bool? PagarEnvio { get; set; }

    public bool? DatosDeReembolsoPendientes { get; set; }

    public string? Reembolso { get; set; }

    public string? ObservacionesEmpresaEntrega { get; set; }

    public int? CodigoUsuarioGuia { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public string? GuidFirma { get; set; }

    public string? GuidRegistrarDocumento { get; set; }

    public string? GuidAnular { get; set; }

    public string? GuidFirmaResponse { get; set; }

    public string? GuidRegistrarDocumentoResponse { get; set; }

    public string? GuidAnularResponse { get; set; }

    public int? CodigoUsuarioDespacho { get; set; }

    public int? CodigoFormaDeEnvio { get; set; }

    public decimal? Envio { get; set; }

    public int? CodigoUsuarioModificaDireccion { get; set; }

    public DateTime? FechaModificaDireccion { get; set; }

    public int? CodigoMembresia { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? Cui { get; set; }

    public string? ObservacionesDespacho { get; set; }

    public int? CodigoTipoDocumento { get; set; }

    public DateTime? FechaDatosReembolso { get; set; }

    public int? CodigoPorcentajeRetencionExencion { get; set; }

    public DateTime? FechaEnvioCliente { get; set; }

    public virtual ICollection<BitacoraGestionFactura> BitacoraGestionFacturaCodigoFacturaNavigations { get; set; } = new List<BitacoraGestionFactura>();

    public virtual ICollection<BitacoraGestionFactura> BitacoraGestionFacturaCodigoFacturaPadreNavigations { get; set; } = new List<BitacoraGestionFactura>();

    public virtual ICollection<BitacoraMembresium> BitacoraMembresia { get; set; } = new List<BitacoraMembresium>();

    public virtual ICollection<CodigoCanjeable> CodigoCanjeables { get; set; } = new List<CodigoCanjeable>();

    public virtual Cliente? CodigoClienteNavigation { get; set; }

    public virtual Departamento? CodigoDepartamentoNavigation { get; set; }

    public virtual EmpresaDeEntrega? CodigoEmpresaDeEntregaNavigation { get; set; }

    public virtual Empresa? CodigoEmpresaNavigation { get; set; }

    public virtual EstadoEntregaFactura? CodigoEstadoEntregaFacturaNavigation { get; set; }

    public virtual EstadoFactura? CodigoEstadoFacturaNavigation { get; set; }

    public virtual Factura? CodigoFacturaAnuladaNavigation { get; set; }

    public virtual FormaDeEnvio? CodigoFormaDeEnvioNavigation { get; set; }

    public virtual Membresium? CodigoMembresiaNavigation { get; set; }

    public virtual Municipio? CodigoMunicipioNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaMercaderiaNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaServicioNavigation { get; set; }

    public virtual PorcentajeRetencionExencion? CodigoPorcentajeRetencionExencionNavigation { get; set; }

    public virtual TipoDocumento? CodigoTipoDocumentoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioAnulacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioDespachoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificaDireccionNavigation { get; set; }

    public virtual ICollection<DireccionIpcliente> DireccionIpclientes { get; set; } = new List<DireccionIpcliente>();

    public virtual ICollection<EmpresaEntregaBitacora> EmpresaEntregaBitacoras { get; set; } = new List<EmpresaEntregaBitacora>();

    public virtual FacturaCreditoFiscal? FacturaCreditoFiscal { get; set; }

    public virtual ICollection<GuiaEliminadum> GuiaEliminada { get; set; } = new List<GuiaEliminadum>();

    public virtual ICollection<HistoricoVale> HistoricoVales { get; set; } = new List<HistoricoVale>();

    public virtual ICollection<IntentoDeEntrega> IntentoDeEntregas { get; set; } = new List<IntentoDeEntrega>();

    public virtual ICollection<Factura> InverseCodigoFacturaAnuladaNavigation { get; set; } = new List<Factura>();

    public virtual ICollection<PolizaContableBitacora> PolizaContableBitacoras { get; set; } = new List<PolizaContableBitacora>();

    public virtual ICollection<SolicitudDocumentoTarjetum> SolicitudDocumentoTarjeta { get; set; } = new List<SolicitudDocumentoTarjetum>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();

    public virtual ICollection<Garantium> CodigoGarantia { get; set; } = new List<Garantium>();
}

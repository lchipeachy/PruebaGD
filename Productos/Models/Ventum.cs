using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Ventum
{
    public int CodigoVenta { get; set; }

    public DateTime Fecha { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string CorreoCliente { get; set; } = null!;

    public int Cantidad { get; set; }

    public int? CodigoProducto { get; set; }

    public string NombreProducto { get; set; } = null!;

    public decimal? Costo { get; set; }

    public decimal Monto { get; set; }

    public int CodigoFormaDePago { get; set; }

    public string DireccionDeEntrega { get; set; } = null!;

    public string? Factura { get; set; }

    public bool Confirmada { get; set; }

    public string Telefonos { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string? NumeroTarjeta { get; set; }

    public string? VencimientoTarjeta { get; set; }

    public string? NombreTarjeta { get; set; }

    public int? Cuotas { get; set; }

    public decimal? MontoCuota { get; set; }

    public bool EnPreorden { get; set; }

    public string? CodigoSeguridad { get; set; }

    public int? CodigoRedCrediticia { get; set; }

    public string? NumeroAutorizacion { get; set; }

    public int? CodigoTipoDeTarjeta { get; set; }

    public bool? Pendiente { get; set; }

    public string? BoletaDeposito { get; set; }

    public int? UsuarioDeposito { get; set; }

    public int? UsuarioTarjeta { get; set; }

    public string? ReferenciaCobroTarjeta { get; set; }

    public string? DatosDeSeguridad { get; set; }

    public int CodigoEstadoDeVenta { get; set; }

    public bool? ProductoVerificado { get; set; }

    public int? CodigoEmpaqueDeRegalo { get; set; }

    public decimal? EmpaqueRegalo { get; set; }

    public string? De { get; set; }

    public string? Para { get; set; }

    public int? CodigoFactura { get; set; }

    public decimal? MontoProveedor { get; set; }

    public int? CodigoCliente { get; set; }

    public bool? EsPedido { get; set; }

    public string? Despacho { get; set; }

    public bool? Despachada { get; set; }

    public decimal? PrecioCompra { get; set; }

    public bool? Guia { get; set; }

    public DateTime? FechaDespachada { get; set; }

    public DateOnly? CorreoTransito { get; set; }

    public decimal? TotalVenta { get; set; }

    public string? Llamada11 { get; set; }

    public string? Llamada12 { get; set; }

    public string? Llamada21 { get; set; }

    public string? Llamada22 { get; set; }

    public short? CodigoEstadoEntrega { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public DateTime? FechaConfirmacion { get; set; }

    public string? NombreRecibido { get; set; }

    public DateTime? FechaDespachoProveedor { get; set; }

    public short? DespachoProveedor { get; set; }

    public string? UbicacionEntrega { get; set; }

    public string? CodigoSms { get; set; }

    public bool? Autenticada { get; set; }

    public short? CodigoIncidenciaVenta { get; set; }

    public short? DiasAtraso { get; set; }

    public int? UsuarioValidacion { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public int? UsuarioVerificacion { get; set; }

    public int? CodigoPolizaInventario { get; set; }

    public int? CodigoPolizaArancel { get; set; }

    public int? CodigoUsuarioEntrega { get; set; }

    public int? CodigoUsuarioCambioPrecio { get; set; }

    public bool? ProductoComprado { get; set; }

    public int? DiasEntrega { get; set; }

    public int? CodigoUsuarioDesverificacion { get; set; }

    public DateTime? FechaDesverificacion { get; set; }

    public bool? ClienteAnula { get; set; }

    public DateTime? FechaClienteAnula { get; set; }

    public int? CodigoUbicacionDespacho { get; set; }

    public bool? EmpaqueVerificado { get; set; }

    public string? ComentarioVerificacion { get; set; }

    public int? CodigoUsuarioModificaFormaPago { get; set; }

    public DateTime? FechaUsuarioModificaFormaPago { get; set; }

    public int? CodigoRazonAnulacionVenta { get; set; }

    public string? DireccionDeEntregaAnterior { get; set; }

    public bool EsDevolucion { get; set; }

    public string? FotoVerificacion { get; set; }

    public virtual ICollection<Click> Clicks { get; set; } = new List<Click>();

    public virtual ICollection<Cobro> Cobros { get; set; } = new List<Cobro>();

    public virtual ICollection<CodigoCanjeable> CodigoCanjeables { get; set; } = new List<CodigoCanjeable>();

    public virtual Cliente? CodigoClienteNavigation { get; set; }

    public virtual EmpaqueDeRegalo? CodigoEmpaqueDeRegaloNavigation { get; set; }

    public virtual EstadoDeVentum CodigoEstadoDeVentaNavigation { get; set; } = null!;

    public virtual EstadoEntrega? CodigoEstadoEntregaNavigation { get; set; }

    public virtual Factura? CodigoFacturaNavigation { get; set; }

    public virtual FormaDePago CodigoFormaDePagoNavigation { get; set; } = null!;

    public virtual IncidenciaVentum? CodigoIncidenciaVentaNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaArancelNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaInventarioNavigation { get; set; }

    public virtual Producto? CodigoProductoNavigation { get; set; }

    public virtual RazonAnulacionVentum? CodigoRazonAnulacionVentaNavigation { get; set; }

    public virtual RedCrediticium? CodigoRedCrediticiaNavigation { get; set; }

    public virtual TipoDeTarjetum? CodigoTipoDeTarjetaNavigation { get; set; }

    public virtual UbicacionDespacho? CodigoUbicacionDespachoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioCambioPrecioNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioDesverificacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioEntregaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificaFormaPagoNavigation { get; set; }

    public virtual ICollection<DetalleVentaServicio> DetalleVentaServicios { get; set; } = new List<DetalleVentaServicio>();

    public virtual ICollection<Garantium> Garantia { get; set; } = new List<Garantium>();

    public virtual ICollection<HistoricoVale> HistoricoVales { get; set; } = new List<HistoricoVale>();

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();

    public virtual ICollection<Preguntum> Pregunta { get; set; } = new List<Preguntum>();

    public virtual Usuario? UsuarioDepositoNavigation { get; set; }

    public virtual Usuario? UsuarioTarjetaNavigation { get; set; }

    public virtual Usuario? UsuarioValidacionNavigation { get; set; }

    public virtual Usuario? UsuarioVerificacionNavigation { get; set; }

    public virtual ICollection<VentaCaby> VentaCabies { get; set; } = new List<VentaCaby>();

    public virtual ICollection<VentaPedidoInventario> VentaPedidoInventarios { get; set; } = new List<VentaPedidoInventario>();

    public virtual ICollection<VentaPedido> VentaPedidos { get; set; } = new List<VentaPedido>();

    public virtual ICollection<VerificacionEmpaque> VerificacionEmpaques { get; set; } = new List<VerificacionEmpaque>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Garantium
{
    public int CodigoGarantia { get; set; }

    public int? CodigoEstadoGarantia { get; set; }

    public int? CodigoVenta { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? Descripcion { get; set; }

    public int? CodigoPedido { get; set; }

    public bool? Pedido { get; set; }

    public string? Resolucion { get; set; }

    public bool? Aprobada { get; set; }

    public string? NombreContacto { get; set; }

    public string? CorreoContacto { get; set; }

    public string? TelefonoContacto { get; set; }

    public int? CodigoLocalidad { get; set; }

    public int? CodigoUsuario { get; set; }

    public DateTime? FechaResolucion { get; set; }

    public int? CodigoUsuarioResolucion { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public int? CodigoUsuarioEntrega { get; set; }

    public int? CodigoCobro { get; set; }

    public string? CodigoAmazon { get; set; }

    public bool? ProductoVerificado { get; set; }

    public string? Direccion { get; set; }

    public string? NumeroDeSerie { get; set; }

    public string? ArticulosRecibidos { get; set; }

    public bool? CopiaFactura { get; set; }

    public bool? NotaDelCliente { get; set; }

    public bool? GarantiaProducto { get; set; }

    public string? PersonaEntrega { get; set; }

    public string? Dpi { get; set; }

    public int? CodigoTipoGarantia { get; set; }

    public bool? ReemplazoInmediato { get; set; }

    public string? MensajeCliente { get; set; }

    public bool? FacturaOriginal { get; set; }

    public bool? Movimiento { get; set; }

    public string? ExcepcionTiempoGarantia { get; set; }

    public bool? ActualizaSaldoProveedor { get; set; }

    public decimal? MontoReembolsado { get; set; }

    public decimal? MontoProveedor { get; set; }

    public bool? PagoParcial { get; set; }

    public DateTime? FechaRecepcionGuia { get; set; }

    public virtual ICollection<CodigoCanjeable> CodigoCanjeables { get; set; } = new List<CodigoCanjeable>();

    public virtual Cobro? CodigoCobroNavigation { get; set; }

    public virtual EstadoGarantium? CodigoEstadoGarantiaNavigation { get; set; }

    public virtual Localidad? CodigoLocalidadNavigation { get; set; }

    public virtual Pedido? CodigoPedidoNavigation { get; set; }

    public virtual TipoGarantium? CodigoTipoGarantiaNavigation { get; set; }

    public virtual Ventum? CodigoVentaNavigation { get; set; }

    public virtual ICollection<ImagenGarantium> ImagenGarantia { get; set; } = new List<ImagenGarantium>();

    public virtual ICollection<MovimientoEstadoGarantium> MovimientoEstadoGarantia { get; set; } = new List<MovimientoEstadoGarantium>();

    public virtual ICollection<MovimientoGarantium> MovimientoGarantia { get; set; } = new List<MovimientoGarantium>();

    public virtual ICollection<Factura> CodigoFacturas { get; set; } = new List<Factura>();
}

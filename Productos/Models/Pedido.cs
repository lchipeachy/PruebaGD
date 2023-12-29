using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Pedido
{
    public int CodigoPedido { get; set; }

    public DateTime? FechaDeOrden { get; set; }

    public string? OrdenDeAmazon { get; set; }

    public string? NombreProducto { get; set; }

    public string? TipoDeProducto { get; set; }

    public string? CodigoAmazon { get; set; }

    public DateTime? FechaDeLanzamiento { get; set; }

    public string? Condicion { get; set; }

    public string? Vendedor { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public string? Tarjeta { get; set; }

    public string? OrdenDeCompra { get; set; }

    public string? Correo { get; set; }

    public DateTime? FechaDeEnvio { get; set; }

    public string? NombreEnvio { get; set; }

    public string? Direccion1Envio { get; set; }

    public string? Direccion2Envio { get; set; }

    public string? CiudadDeEnvio { get; set; }

    public string? EstadoDeEnvio { get; set; }

    public string? ZipDeEnvio { get; set; }

    public string? EstadoDeLaOrden { get; set; }

    public string? CodigoDeRastreo { get; set; }

    public decimal? MontoTotal { get; set; }

    public int? CodigoImportador { get; set; }

    public int? CodigoEstadoPedido { get; set; }

    public string? CodigoEmbarque { get; set; }

    public bool? Preordenado { get; set; }

    public string? Observaciones { get; set; }

    public string? Warehouse { get; set; }

    public string? Transportista { get; set; }

    public string? Marca { get; set; }

    public int? Reservado { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? Website { get; set; }

    public DateOnly? Notificacion { get; set; }

    public int? CodigoPaquete { get; set; }

    public decimal? Impuesto { get; set; }

    public decimal? ImpuestoReembolsado { get; set; }

    public bool? Escaneada { get; set; }

    public int? CodigoPaqueteReclamado { get; set; }

    public bool? Modificado { get; set; }

    public int? CodigoEstadoPedidoAnterior { get; set; }

    public string? UrlOrden { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public decimal? Cifaduana { get; set; }

    public decimal? MontoArancel { get; set; }

    public decimal? MontoFlete { get; set; }

    public decimal? MontoIva { get; set; }

    public decimal? Peso { get; set; }

    public DateOnly? FechaImpuestoReembolsado { get; set; }

    public decimal? MontoReembolsado { get; set; }

    public DateOnly? FechaMontoReembolsado { get; set; }

    public int? CodigoPolizaInventarioMercaderia { get; set; }

    public int? CodigoPolizaContableMercaderiaEnTransito { get; set; }

    public int? CodigoCuenta { get; set; }

    public int? CodigoPolizaContableImpuestoCobrado { get; set; }

    public int? CodigoUsuarioAplicacionExterna { get; set; }

    public virtual Producto? CodigoAmazonNavigation { get; set; }

    public virtual Cuentum? CodigoCuentaNavigation { get; set; }

    public virtual Embarque? CodigoEmbarqueNavigation { get; set; }

    public virtual EstadoPedido? CodigoEstadoPedidoNavigation { get; set; }

    public virtual Paquete? CodigoPaqueteNavigation { get; set; }

    public virtual PaqueteReclamado? CodigoPaqueteReclamadoNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContableImpuestoCobradoNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContableMercaderiaEnTransitoNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaInventarioMercaderiaNavigation { get; set; }

    public virtual UsuarioAplicacionExterna? CodigoUsuarioAplicacionExternaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual CuentaDeCompra? CorreoNavigation { get; set; }

    public virtual ICollection<Garantium> Garantia { get; set; } = new List<Garantium>();

    public virtual ICollection<PolizaContableBitacora> PolizaContableBitacoras { get; set; } = new List<PolizaContableBitacora>();

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();

    public virtual ICollection<VentaPedido> VentaPedidos { get; set; } = new List<VentaPedido>();

    public virtual ICollection<VerificacionEmbarque> VerificacionEmbarques { get; set; } = new List<VerificacionEmbarque>();
}

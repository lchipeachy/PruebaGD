using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TmpPedido
{
    public DateTime? OrderDate { get; set; }

    public string? OrderId { get; set; }

    public string? Title { get; set; }

    public string? Category { get; set; }

    public string? AsinIsbn { get; set; }

    public string? Website { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? Condition { get; set; }

    public string? Seller { get; set; }

    public string? OriginalListPrice { get; set; }

    public string? PerUnitPrice { get; set; }

    public int? Quantity { get; set; }

    public string? PaymentInstrumentType { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? OrderingCustomerEmail { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public string? ShippingAddressName { get; set; }

    public string? ShippingAddressStreet1 { get; set; }

    public string? ShippingAddressStreet2 { get; set; }

    public string? ShippingAddressCity { get; set; }

    public string? ShippingAddressState { get; set; }

    public string? ShippingAddressZip { get; set; }

    public string? ShipmentOrderCondition { get; set; }

    public string? CarrierNameTrackingNumber { get; set; }

    public string? ItemSubtotal { get; set; }

    public string? ItemSubtotalTax { get; set; }

    public string? BuyerName { get; set; }

    public string? Currency { get; set; }

    public string? ExternalItemNumber { get; set; }

    public string? Signature { get; set; }

    public string? Upc { get; set; }

    public decimal? PrecioVenta { get; set; }

    public string? Carasteristicas { get; set; }

    public string? Foto1 { get; set; }

    public string? Foto2 { get; set; }

    public string? Foto3 { get; set; }

    public string? Observaciones { get; set; }

    public string? Pagina { get; set; }

    public decimal? PrecioAnterior { get; set; }

    public decimal? PrecioCompra { get; set; }

    public string? CodigoReferencia { get; set; }

    public string? UrlOrden { get; set; }

    public decimal? Cifaduana { get; set; }

    public decimal? MontoArancel { get; set; }

    public decimal? MontoFlete { get; set; }

    public decimal? MontoIva { get; set; }

    public decimal? Peso { get; set; }
}

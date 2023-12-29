using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TmpPedidoEstablecimiento
{
    public DateTime? OrderDate { get; set; }

    public string? OrderId { get; set; }

    public string? Title { get; set; }

    public string? Category { get; set; }

    public string? AsinIsbn { get; set; }

    public string? Seller { get; set; }

    public string? PerUnitPrice { get; set; }

    public int? Quantity { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public string? CarrierNameTrackingNumber { get; set; }

    public string? ItemSubtotal { get; set; }

    public string? Upc { get; set; }

    public decimal? PrecioVenta { get; set; }

    public string? Pagina { get; set; }

    public string? CodigoReferencia { get; set; }

    public string? CodigoEstablecimiento { get; set; }

    public string? EnglishName { get; set; }
}

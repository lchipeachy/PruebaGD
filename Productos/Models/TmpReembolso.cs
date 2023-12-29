using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TmpReembolso
{
    public string? OrderId { get; set; }

    public string? OrderDate { get; set; }

    public string? Title { get; set; }

    public string? Category { get; set; }

    public string? AsinIsbn { get; set; }

    public string? Website { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? RefundDate { get; set; }

    public string? RefundCondition { get; set; }

    public string? RefundAmount { get; set; }

    public string? RefundTaxAmount { get; set; }

    public string? TaxExemptionApplied { get; set; }

    public string? RefundReason { get; set; }

    public string? Quantity { get; set; }

    public string? Seller { get; set; }

    public string? SellerCredentials { get; set; }

    public string? BuyerName { get; set; }

    public string? GroupName { get; set; }
}

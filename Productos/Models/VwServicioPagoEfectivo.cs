using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VwServicioPagoEfectivo
{
    public string? Referencia { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Usuario { get; set; }

    public decimal? Monto { get; set; }

    public string? Facturas { get; set; }

    public string? Revision { get; set; }

    public string? Guias { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class OrdenDeCompra
{
    public string OrdenDeAmazon { get; set; } = null!;

    public DateOnly? CorreoDeExencion { get; set; }

    public DateTime? FechaReembolsoImpuestoManual { get; set; }
}

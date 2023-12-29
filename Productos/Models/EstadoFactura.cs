using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoFactura
{
    public int CodigoEstadoFactura { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}

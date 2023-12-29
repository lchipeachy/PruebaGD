using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ProductoNoVigente
{
    public int? CodigoProducto { get; set; }

    public string Resultado { get; set; } = null!;

    public DateTime? Fecha { get; set; }
}

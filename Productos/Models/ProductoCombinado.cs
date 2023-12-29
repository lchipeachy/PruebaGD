using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ProductoCombinado
{
    public int CodigoProducto { get; set; }

    public int CodigoProductoCombinado { get; set; }

    public int Cantidad { get; set; }

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;
}

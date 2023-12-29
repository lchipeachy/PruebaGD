using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VentaPedidoInventario
{
    public int CodigoVenta { get; set; }

    public int CodigoPedido { get; set; }

    public int Cantidad { get; set; }

    public virtual Ventum CodigoVentaNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VentaPedido
{
    public int CodigoVenta { get; set; }

    public int CodigoPedido { get; set; }

    public int Cantidad { get; set; }

    public virtual Pedido CodigoPedidoNavigation { get; set; } = null!;

    public virtual Ventum CodigoVentaNavigation { get; set; } = null!;
}

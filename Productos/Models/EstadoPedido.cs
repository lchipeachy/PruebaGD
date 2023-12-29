using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoPedido
{
    public int CodigoEstadoPedido { get; set; }

    public string? Nombre { get; set; }

    public bool? Gestionar { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

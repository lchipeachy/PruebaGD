using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoProducto
{
    public int CodigoEstadoProducto { get; set; }

    public string Nombre { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ProductoServicio
{
    public int CodigoProducto { get; set; }

    public int CodigoServicio { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;

    public virtual Servicio CodigoServicioNavigation { get; set; } = null!;
}

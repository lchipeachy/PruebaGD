using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VerificacionInventario
{
    public int CodigoVerificacionInventario { get; set; }

    public int? CodigoInventario { get; set; }

    public string? Upc { get; set; }

    public int? CodigoUsuario { get; set; }

    public DateTime? Fecha { get; set; }

    public int? CodigoProducto { get; set; }

    public virtual Inventario? CodigoInventarioNavigation { get; set; }

    public virtual Producto? CodigoProductoNavigation { get; set; }
}

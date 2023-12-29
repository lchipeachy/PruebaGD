using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PrecioBitacora
{
    public int CodigoProducto { get; set; }

    public int CodigoUsuario { get; set; }

    public DateTime Fecha { get; set; }

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioNavigation { get; set; } = null!;
}

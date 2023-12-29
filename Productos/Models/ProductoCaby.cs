using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ProductoCaby
{
    public int CodigoCaby { get; set; }

    public int CodigoProducto { get; set; }

    public int? CodigoUsuarioAsociaCaby { get; set; }

    public DateTime? FechaUsuarioAsociaCaby { get; set; }

    public int? CodigoUsuarioModificaCaby { get; set; }

    public DateTime? FechaUsuarioModificaCaby { get; set; }

    public virtual Caby CodigoCabyNavigation { get; set; } = null!;

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioAsociaCabyNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificaCabyNavigation { get; set; }
}

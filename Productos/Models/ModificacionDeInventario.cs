using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ModificacionDeInventario
{
    public int CodigoModificacionDeInventario { get; set; }

    public DateTime? Fecha { get; set; }

    public int? CodigoProducto { get; set; }

    public byte? Cantidad { get; set; }

    public bool? SumaResta { get; set; }

    public int CodigoUsuario { get; set; }

    public virtual Producto? CodigoProductoNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Penalizacion
{
    public int CodigoPenalizacion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<RevisionProducto> RevisionProductos { get; set; } = new List<RevisionProducto>();
}

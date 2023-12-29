using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class UbicacionDespacho
{
    public int CodigoUbicacionDespacho { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

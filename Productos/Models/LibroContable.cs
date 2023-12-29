using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class LibroContable
{
    public int CodigoLibroContable { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<CuentaContable> CuentaContables { get; set; } = new List<CuentaContable>();
}

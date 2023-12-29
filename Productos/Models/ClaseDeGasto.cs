using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ClaseDeGasto
{
    public int CodigoClaseDeGasto { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<CuentaContable> CuentaContables { get; set; } = new List<CuentaContable>();
}

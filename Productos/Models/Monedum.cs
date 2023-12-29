using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Monedum
{
    public int CodigoMoneda { get; set; }

    public string? Nombre { get; set; }

    public string? Simbolo { get; set; }

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();
}

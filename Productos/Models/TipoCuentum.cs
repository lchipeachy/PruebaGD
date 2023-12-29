using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoCuentum
{
    public int CodigoTipoCuenta { get; set; }

    public string? Nombre { get; set; }

    public bool? AplicaSaldo { get; set; }

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();
}

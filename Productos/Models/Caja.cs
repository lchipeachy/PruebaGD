using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Caja
{
    public decimal? Saldo { get; set; }

    public int? CodigoCuenta { get; set; }

    public virtual Cuentum? CodigoCuentaNavigation { get; set; }
}

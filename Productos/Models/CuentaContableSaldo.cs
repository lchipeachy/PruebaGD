using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CuentaContableSaldo
{
    public int CodigoCuentaContable { get; set; }

    public int CodigoCierreContable { get; set; }

    public decimal? Debe { get; set; }

    public decimal? Haber { get; set; }

    public virtual CierreContable CodigoCierreContableNavigation { get; set; } = null!;

    public virtual CuentaContable CodigoCuentaContableNavigation { get; set; } = null!;
}

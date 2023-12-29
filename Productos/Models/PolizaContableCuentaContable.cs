using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PolizaContableCuentaContable
{
    public int? CodigoPolizaContable { get; set; }

    public int? CodigoCuentaContable { get; set; }

    public decimal? Monto { get; set; }

    public bool? DebeHaber { get; set; }

    public virtual CuentaContable? CodigoCuentaContableNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContableNavigation { get; set; }
}

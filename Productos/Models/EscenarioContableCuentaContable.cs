using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EscenarioContableCuentaContable
{
    public int? CodigoEscenarioContable { get; set; }

    public int? CodigoCuentaContable { get; set; }

    public decimal? Porcentaje { get; set; }

    public bool? OrigenDestino { get; set; }

    public virtual CuentaContable? CodigoCuentaContableNavigation { get; set; }

    public virtual EscenarioContable? CodigoEscenarioContableNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EscenarioContable
{
    public int CodigoEscenarioContable { get; set; }

    public int? CodigoTipoEscenarioContable { get; set; }

    public string? Nombre { get; set; }

    public virtual TipoEscenarioContable? CodigoTipoEscenarioContableNavigation { get; set; }

    public virtual ICollection<PolizaContable> PolizaContables { get; set; } = new List<PolizaContable>();
}

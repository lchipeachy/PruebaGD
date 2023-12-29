using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class GastoDetalle
{
    public int CodigoGastoDetalle { get; set; }

    public int CodigoGasto { get; set; }

    public int CodigoTipoGasto { get; set; }

    public decimal Monto { get; set; }

    public virtual Gasto CodigoGastoNavigation { get; set; } = null!;

    public virtual TipoDeGasto CodigoTipoGastoNavigation { get; set; } = null!;
}

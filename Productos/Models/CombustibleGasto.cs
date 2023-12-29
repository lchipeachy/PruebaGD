using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CombustibleGasto
{
    public int? CodigoGasto { get; set; }

    public decimal? Galon { get; set; }

    public decimal? Idp { get; set; }

    public int? CodigoTipoCombustible { get; set; }

    public virtual Gasto? CodigoGastoNavigation { get; set; }

    public virtual TipoCombustible? CodigoTipoCombustibleNavigation { get; set; }
}

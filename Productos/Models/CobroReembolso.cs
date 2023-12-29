using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CobroReembolso
{
    public int CodigoCobroReembolso { get; set; }

    public int CodigoCobro { get; set; }

    public int CodigoCobroReintegro { get; set; }

    public decimal? Monto { get; set; }

    public virtual Cobro CodigoCobroNavigation { get; set; } = null!;

    public virtual Cobro CodigoCobroReintegroNavigation { get; set; } = null!;
}

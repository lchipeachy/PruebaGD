using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VentaCaby
{
    public int CodigoCaby { get; set; }

    public int CodigoVenta { get; set; }

    public string? NombreCategoriaCaby { get; set; }

    public decimal? HistoricoImpuestoCaby { get; set; }

    public virtual Caby CodigoCabyNavigation { get; set; } = null!;

    public virtual Ventum CodigoVentaNavigation { get; set; } = null!;
}

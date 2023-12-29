using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Vale
{
    public int CodigoVale { get; set; }

    public string NumeroVale { get; set; } = null!;

    public decimal Monto { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<HistoricoVale> HistoricoVales { get; set; } = new List<HistoricoVale>();
}

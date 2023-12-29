using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoHistorico
{
    public int CodigoTipoHistorico { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<HistoricoVale> HistoricoVales { get; set; } = new List<HistoricoVale>();
}

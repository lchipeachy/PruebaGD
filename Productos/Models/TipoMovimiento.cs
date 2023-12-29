using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoMovimiento
{
    public int CodigoTipoMovimiento { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
}

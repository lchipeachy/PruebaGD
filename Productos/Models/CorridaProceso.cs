using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CorridaProceso
{
    public int CodigoProceso { get; set; }

    public DateTime Fecha { get; set; }

    public string? Resultado { get; set; }
}

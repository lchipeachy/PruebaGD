using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TasaDeCambio
{
    public DateOnly Fecha { get; set; }

    public decimal? Valor { get; set; }
}

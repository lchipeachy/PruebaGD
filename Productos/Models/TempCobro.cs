using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TempCobro
{
    public decimal Codigo { get; set; }

    public string Datos { get; set; } = null!;

    public DateTime? Fecha { get; set; }
}

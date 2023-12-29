using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Busquedum
{
    public string Texto { get; set; } = null!;

    public int Resultados { get; set; }

    public DateTime Fecha { get; set; }
}

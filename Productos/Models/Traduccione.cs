using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Traduccione
{
    public string CadenaTraducir { get; set; } = null!;

    public string? Traduccion { get; set; }

    public DateTime? Fecha { get; set; }
}

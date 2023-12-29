using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class BusquedaPagina
{
    public string? CadenaBuscar { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Url { get; set; }
}

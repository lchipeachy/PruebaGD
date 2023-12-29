using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CategoriaNoAutomatizable
{
    public int CodigoCategoriaNoAutomatizable { get; set; }

    public string BrowseNodeId { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class AnuncioRestringido
{
    public int CodigoAnuncioRestringido { get; set; }

    public string? Palabra { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoAnuncio
{
    public int CodigoEstadoAnuncio { get; set; }

    public string Nombre { get; set; } = null!;
}

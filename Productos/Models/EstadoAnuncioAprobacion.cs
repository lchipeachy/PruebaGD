using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoAnuncioAprobacion
{
    public byte CodigoEstadoAnuncioAprobacion { get; set; }

    public string Nombre { get; set; } = null!;
}

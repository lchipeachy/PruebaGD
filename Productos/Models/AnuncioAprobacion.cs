using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class AnuncioAprobacion
{
    public int? CodigoAnuncio { get; set; }

    public string? Clave { get; set; }

    public byte? Estado { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Observaciones { get; set; }
}

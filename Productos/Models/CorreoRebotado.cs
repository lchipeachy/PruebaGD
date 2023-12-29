using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CorreoRebotado
{
    public DateTime Fecha { get; set; }

    public string Correo { get; set; } = null!;

    public string? Error { get; set; }
}

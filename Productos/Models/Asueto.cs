using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Asueto
{
    public DateOnly Fecha { get; set; }

    public bool? MedioDia { get; set; }

    public string? Descripcion { get; set; }
}

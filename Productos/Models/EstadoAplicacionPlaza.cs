using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoAplicacionPlaza
{
    public int CodigoEstadoAplicacionPlaza { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<AplicacionPlaza> AplicacionPlazas { get; set; } = new List<AplicacionPlaza>();
}

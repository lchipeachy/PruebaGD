using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoPaqueteReclamado
{
    public int CodigoEstadoPaqueteReclamado { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<PaqueteReclamado> PaqueteReclamados { get; set; } = new List<PaqueteReclamado>();
}

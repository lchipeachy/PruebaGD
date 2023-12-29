using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoPaquete
{
    public short CodigoEstadoPaquete { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Paquete> Paquetes { get; set; } = new List<Paquete>();
}

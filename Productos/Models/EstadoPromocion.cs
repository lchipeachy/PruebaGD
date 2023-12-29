using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoPromocion
{
    public byte CodigoEstadoPromocion { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Promocion> Promocions { get; set; } = new List<Promocion>();
}

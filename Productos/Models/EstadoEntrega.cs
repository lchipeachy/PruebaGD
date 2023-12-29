using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoEntrega
{
    public short CodigoEstadoEntrega { get; set; }

    public string Nombre { get; set; } = null!;

    public short? Dias { get; set; }

    public string? Etapa { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

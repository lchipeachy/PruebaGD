using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class IncidenciaVentum
{
    public short CodigoIncidenciaVenta { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

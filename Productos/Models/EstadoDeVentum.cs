using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoDeVentum
{
    public int CodigoEstadoDeVenta { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

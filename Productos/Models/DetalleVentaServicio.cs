using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class DetalleVentaServicio
{
    public int CodigoVenta { get; set; }

    public int CodigoServicio { get; set; }

    public decimal? Monto { get; set; }

    public virtual Servicio CodigoServicioNavigation { get; set; } = null!;

    public virtual Ventum CodigoVentaNavigation { get; set; } = null!;
}

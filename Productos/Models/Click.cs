using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Click
{
    public int CodigoAnuncio { get; set; }

    public DateTime Fecha { get; set; }

    public int? CodigoVenta { get; set; }

    public float? Cpc { get; set; }

    public virtual Ventum? CodigoVentaNavigation { get; set; }
}

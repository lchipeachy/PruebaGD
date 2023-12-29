using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class DireccionIpcliente
{
    public int CodigoDireccionIpcliente { get; set; }

    public string DireccionIpcliente1 { get; set; } = null!;

    public DateTime FechaCapturaIp { get; set; }

    public int CodigoFactura { get; set; }

    public virtual Factura CodigoFacturaNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class IntentoDeEntrega
{
    public int CodigoIntentoDeEntrega { get; set; }

    public int CodigoFactura { get; set; }

    public int CodigoUsuario { get; set; }

    public string? UbicacionIntentoEntrega { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Observaciones { get; set; }

    public int? CodigoMotivoRetorno { get; set; }

    public virtual Factura CodigoFacturaNavigation { get; set; } = null!;

    public virtual MotivoRetorno? CodigoMotivoRetornoNavigation { get; set; }

    public virtual Usuario CodigoUsuarioNavigation { get; set; } = null!;
}

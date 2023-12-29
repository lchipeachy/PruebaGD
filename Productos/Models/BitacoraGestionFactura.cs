using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class BitacoraGestionFactura
{
    public int CodigoBitacoraGestionFactura { get; set; }

    public int CodigoFacturaPadre { get; set; }

    public int CodigoFactura { get; set; }

    public int CodigoUsuario { get; set; }

    public DateTime Fecha { get; set; }

    public virtual Factura CodigoFacturaNavigation { get; set; } = null!;

    public virtual Factura CodigoFacturaPadreNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioNavigation { get; set; } = null!;
}

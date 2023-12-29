using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class SolicitudDocumentoTarjetum
{
    public int CodigoSolicitudDocumentoTarjeta { get; set; }

    public int CodigoFactura { get; set; }

    public int CodigoUsuario { get; set; }

    public DateTime Fecha { get; set; }

    public virtual Factura CodigoFacturaNavigation { get; set; } = null!;
}

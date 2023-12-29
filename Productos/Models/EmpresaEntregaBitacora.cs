using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EmpresaEntregaBitacora
{
    public int CodigoEmpresaEntregaBitacora { get; set; }

    public int CodigoFactura { get; set; }

    public string CodigoDeRastreo { get; set; } = null!;

    public int CodigoEstadoEntregaFactura { get; set; }

    public int CodigoUsuario { get; set; }

    public DateTime Fecha { get; set; }

    public virtual EstadoEntregaFactura CodigoEstadoEntregaFacturaNavigation { get; set; } = null!;

    public virtual Factura CodigoFacturaNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioNavigation { get; set; } = null!;
}

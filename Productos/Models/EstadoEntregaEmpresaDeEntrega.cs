using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoEntregaEmpresaDeEntrega
{
    public string CodigoEstadoEntregaEmpresaDeEntrega { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int CodigoEstadoEntregaFactura { get; set; }

    public short CodigoEmpresaDeEntrega { get; set; }

    public virtual EmpresaDeEntrega CodigoEmpresaDeEntregaNavigation { get; set; } = null!;

    public virtual EstadoEntregaFactura CodigoEstadoEntregaFacturaNavigation { get; set; } = null!;
}

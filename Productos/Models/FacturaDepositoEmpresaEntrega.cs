using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class FacturaDepositoEmpresaEntrega
{
    public int CodigoFactura { get; set; }

    public int CodigoDepositoEmpresaEntrega { get; set; }

    public virtual DepositoEmpresaEntrega CodigoDepositoEmpresaEntregaNavigation { get; set; } = null!;

    public virtual Factura CodigoFacturaNavigation { get; set; } = null!;
}

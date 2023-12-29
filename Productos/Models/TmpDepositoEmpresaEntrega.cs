using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TmpDepositoEmpresaEntrega
{
    public int CodigoEmpresaEntrega { get; set; }

    public int CodigoFactura { get; set; }

    public string NumeroAutorizacion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public decimal MontoDeposito { get; set; }
}

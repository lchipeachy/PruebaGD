using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoDepositoEmpresaEntrega
{
    public int CodigoEstadoDepositoEmpresaEntrega { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<DepositoEmpresaEntrega> DepositoEmpresaEntregas { get; set; } = new List<DepositoEmpresaEntrega>();
}

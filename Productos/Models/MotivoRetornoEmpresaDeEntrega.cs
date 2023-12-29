using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MotivoRetornoEmpresaDeEntrega
{
    public string CodigoMotivoRetornoEmpresaEntrega { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int CodigoMotivoRetorno { get; set; }

    public short CodigoEmpresaDeEntrega { get; set; }

    public virtual EmpresaDeEntrega CodigoEmpresaDeEntregaNavigation { get; set; } = null!;

    public virtual MotivoRetorno CodigoMotivoRetornoNavigation { get; set; } = null!;
}

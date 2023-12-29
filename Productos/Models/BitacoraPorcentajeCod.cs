using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class BitacoraPorcentajeCod
{
    public int CodigoBitacoraPorcentajeCod { get; set; }

    public short CodigoEmpresaDeEntrega { get; set; }

    public DateTime Fecha { get; set; }

    public decimal? PorcentajeComisionCod { get; set; }

    public virtual EmpresaDeEntrega CodigoEmpresaDeEntregaNavigation { get; set; } = null!;
}

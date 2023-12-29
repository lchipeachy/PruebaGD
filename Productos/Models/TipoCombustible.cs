using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoCombustible
{
    public int CodigoTipoCombustible { get; set; }

    public decimal Porcentaje { get; set; }

    public string? Nombre { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TmpCategoriaEliminadum
{
    public int CodigoCategoria { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public string Usuario { get; set; } = null!;
}

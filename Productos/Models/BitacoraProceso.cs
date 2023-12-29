using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class BitacoraProceso
{
    public int CodigoBitacoraProceso { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public string Descripcion { get; set; } = null!;

    public int CodigoProceso { get; set; }

    public virtual Proceso CodigoProcesoNavigation { get; set; } = null!;
}

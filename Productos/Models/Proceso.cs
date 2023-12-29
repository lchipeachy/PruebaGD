using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Proceso
{
    public int CodigoProceso { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<BitacoraProceso> BitacoraProcesos { get; set; } = new List<BitacoraProceso>();
}

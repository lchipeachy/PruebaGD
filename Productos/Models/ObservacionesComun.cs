using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ObservacionesComun
{
    public int CodigoObservacionesComun { get; set; }

    public string? Nombre { get; set; }

    public string? Texto { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class RespuestaComun
{
    public int CodigoRespuestaComun { get; set; }

    public string? Nombre { get; set; }

    public string? Texto { get; set; }
}

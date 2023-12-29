using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class LlamadaKeepa
{
    public decimal CodigoLlamada { get; set; }

    public string Url { get; set; } = null!;

    public short Tokens { get; set; }

    public DateTime? Fecha { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoNotaContable
{
    public int CodigoEstadoNotaContable { get; set; }

    public string? Prefijo { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<NotaContable> NotaContables { get; set; } = new List<NotaContable>();
}

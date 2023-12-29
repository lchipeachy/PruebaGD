using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ConceptoNotaContable
{
    public int CodigoConceptoNotaContable { get; set; }

    public string? Concepto { get; set; }

    public virtual ICollection<NotaContable> NotaContables { get; set; } = new List<NotaContable>();
}

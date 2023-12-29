using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoPreguntum
{
    public int CodigoTipoPregunta { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Preguntum> Pregunta { get; set; } = new List<Preguntum>();
}

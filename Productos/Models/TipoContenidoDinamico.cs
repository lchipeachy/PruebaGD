using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoContenidoDinamico
{
    public int CodigoTipoContenidoDinamico { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<ContenidoDinamico> ContenidoDinamicos { get; set; } = new List<ContenidoDinamico>();
}

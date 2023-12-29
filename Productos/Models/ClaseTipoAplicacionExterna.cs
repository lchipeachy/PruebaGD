using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ClaseTipoAplicacionExterna
{
    public int CodigoClaseTipoAplicacionExterna { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<TipoAplicacionExterna> TipoAplicacionExternas { get; set; } = new List<TipoAplicacionExterna>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class IndiceDeBusquedum
{
    public string? SearchIndex { get; set; }

    public string? Nombre { get; set; }

    public bool? Traducir { get; set; }

    public short CodigoIndiceDeBusqueda { get; set; }

    public virtual ICollection<Categorium> Categoria { get; set; } = new List<Categorium>();
}

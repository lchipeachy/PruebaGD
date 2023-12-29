using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ContenidoAdicional
{
    public int CodigoContenidoAdicional { get; set; }

    public string? Nombre { get; set; }

    public string? Contenido { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}

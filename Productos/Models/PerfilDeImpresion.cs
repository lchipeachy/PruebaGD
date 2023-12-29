using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PerfilDeImpresion
{
    public int CodigoPerfilDeImpresion { get; set; }

    public string? NombreImpresora { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

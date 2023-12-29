using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoJornadum
{
    public int CodigoTipoJornada { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

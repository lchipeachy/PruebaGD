using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class GradoUniversitario
{
    public int CodigoGradoUniversitario { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

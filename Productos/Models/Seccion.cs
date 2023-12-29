using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Seccion
{
    public int CodigoSeccion { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Foto { get; set; }

    public string? Texto { get; set; }

    public string? Html { get; set; }

    public string? Fondo { get; set; }

    public virtual ICollection<Subseccion> Subseccions { get; set; } = new List<Subseccion>();
}

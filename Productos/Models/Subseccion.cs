using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Subseccion
{
    public int CodigoSubseccion { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Foto { get; set; }

    public string? Texto { get; set; }

    public string? Html { get; set; }

    public string? Fondo { get; set; }

    public int CodigoSeccion { get; set; }

    public virtual Seccion CodigoSeccionNavigation { get; set; } = null!;
}

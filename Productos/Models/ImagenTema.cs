using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ImagenTema
{
    public int CodigoImagenTema { get; set; }

    public string? Urlimagen { get; set; }

    public int? CodigoTema { get; set; }

    public virtual Tema? CodigoTemaNavigation { get; set; }
}

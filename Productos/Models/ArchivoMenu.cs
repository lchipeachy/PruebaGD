using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ArchivoMenu
{
    public short CodigoArchivoMenu { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Pagina> Paginas { get; set; } = new List<Pagina>();
}

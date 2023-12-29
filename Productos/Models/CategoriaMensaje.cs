using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CategoriaMensaje
{
    public int CodigoCategoriaMensaje { get; set; }

    public string? NombreCategoria { get; set; }

    public virtual ICollection<Mensaje> Mensajes { get; set; } = new List<Mensaje>();
}

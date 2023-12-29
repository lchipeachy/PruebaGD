using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class BitacoraManifiesto
{
    public DateTime Fecha { get; set; }

    public int? NumeroManifiesto { get; set; }

    public int? CodigoUsuario { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

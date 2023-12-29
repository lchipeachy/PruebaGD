using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Mensaje
{
    public int CodigoMensaje { get; set; }

    public string? Nombre { get; set; }

    public string? Texto { get; set; }

    public int? CorrelativoMensaje { get; set; }

    public int? CodigoCategoriaMensaje { get; set; }

    public virtual CategoriaMensaje? CodigoCategoriaMensajeNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ErrorApi
{
    public string CodigoErrorApi { get; set; } = null!;

    public short? CodigoTipoError { get; set; }

    public DateTime Fecha { get; set; }

    public string Url { get; set; } = null!;

    public string? Mensaje { get; set; }

    public string? Stacktrace { get; set; }

    public string? Contenido { get; set; }

    public int? CodigoUsuario { get; set; }

    public virtual TipoError? CodigoTipoErrorNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

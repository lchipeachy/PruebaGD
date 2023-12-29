using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Error
{
    public int CodigoError { get; set; }

    public short? CodigoTipoError { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Mensaje { get; set; }

    public string? Archivo { get; set; }

    public string? Url { get; set; }

    public string? Ip { get; set; }

    public string? Descripcion { get; set; }

    public virtual TipoError? CodigoTipoErrorNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoError
{
    public short CodigoTipoError { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<ErrorApi> ErrorApis { get; set; } = new List<ErrorApi>();

    public virtual ICollection<Error> Errors { get; set; } = new List<Error>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ArchivoReembolso
{
    public int CodigoArchivoReembolso { get; set; }

    public string UrlarchivoReembolso { get; set; } = null!;

    public int CodigoCobro { get; set; }

    public virtual Cobro CodigoCobroNavigation { get; set; } = null!;
}

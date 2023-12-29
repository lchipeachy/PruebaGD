using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class UsuarioAplicacionExternaCuentum
{
    public int CodigoCuenta { get; set; }

    public int CodigoUsuarioAplicacionExterna { get; set; }

    public virtual Cuentum CodigoCuentaNavigation { get; set; } = null!;

    public virtual UsuarioAplicacionExterna CodigoUsuarioAplicacionExternaNavigation { get; set; } = null!;
}

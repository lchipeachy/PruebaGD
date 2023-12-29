using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoIngreso
{
    public int CodigoTipoIngreso { get; set; }

    public string Nombre { get; set; } = null!;

    public int CodigoCuentaContable { get; set; }

    public virtual CuentaContable CodigoCuentaContableNavigation { get; set; } = null!;

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();
}

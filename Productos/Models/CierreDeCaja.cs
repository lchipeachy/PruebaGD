using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CierreDeCaja
{
    public DateTime Fecha { get; set; }

    public decimal? Monto { get; set; }

    public decimal? MontoEnCaja { get; set; }

    public int? CodigoUsuario { get; set; }

    public DateTime? FechaCierre { get; set; }

    public int? CodigoCuenta { get; set; }

    public int? CodigoUsuarioReversion { get; set; }

    public DateTime? FechaReversion { get; set; }

    public bool? Estado { get; set; }

    public virtual Cuentum? CodigoCuentaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioReversionNavigation { get; set; }
}

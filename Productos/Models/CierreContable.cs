using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CierreContable
{
    public int CodigoCierreContable { get; set; }

    public int? Mes { get; set; }

    public int? Anio { get; set; }

    public DateTime? Fecha { get; set; }

    public int? CodigoUsuario { get; set; }

    public bool? Cerrado { get; set; }

    public int? CodigoUsuarioReversion { get; set; }

    public DateTime? FechaUsuarioReversion { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioReversionNavigation { get; set; }

    public virtual ICollection<CuentaContableSaldo> CuentaContableSaldos { get; set; } = new List<CuentaContableSaldo>();

    public virtual ICollection<PolizaContable> PolizaContables { get; set; } = new List<PolizaContable>();
}

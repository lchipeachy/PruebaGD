using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoDeGasto
{
    public int CodigoTipoDeGasto { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? CodigoCuentaContable { get; set; }

    public bool? Vigente { get; set; }

    public bool? AsociaGuias { get; set; }

    public virtual CuentaContable? CodigoCuentaContableNavigation { get; set; }

    public virtual ICollection<GastoDetalle> GastoDetalles { get; set; } = new List<GastoDetalle>();

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();
}

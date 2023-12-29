using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoTransaccion
{
    public int CodigoTipoTransaccion { get; set; }

    public int? CodigoFormaDePago { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Cobro> Cobros { get; set; } = new List<Cobro>();

    public virtual FormaDePago? CodigoFormaDePagoNavigation { get; set; }

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();
}

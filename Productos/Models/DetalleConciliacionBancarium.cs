using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class DetalleConciliacionBancarium
{
    public int CodigoDetalleConciliacionBancaria { get; set; }

    public int CodigoConciliacionBancaria { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int? CodigoTransaccion { get; set; }

    public string Referencia { get; set; } = null!;

    public DateTime FechaEstadoCuenta { get; set; }

    public decimal? Credito { get; set; }

    public decimal? Debito { get; set; }

    public virtual ConciliacionBancarium CodigoConciliacionBancariaNavigation { get; set; } = null!;

    public virtual Transaccion? CodigoTransaccionNavigation { get; set; }
}

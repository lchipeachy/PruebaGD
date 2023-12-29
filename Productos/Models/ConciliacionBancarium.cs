using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ConciliacionBancarium
{
    public int CodigoConciliacionBancaria { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int CodigoCuenta { get; set; }

    public decimal SaldoInicial { get; set; }

    public decimal CreditoEstadoCuenta { get; set; }

    public decimal DebitoEstadoCuenta { get; set; }

    public decimal CreditoSistema { get; set; }

    public decimal DebitoSistema { get; set; }

    public int CodigoUsuarioIngreso { get; set; }

    public bool? Conciliado { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaUsuarioModificacion { get; set; }

    public virtual Cuentum CodigoCuentaNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioIngresoNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual ICollection<DetalleConciliacionBancarium> DetalleConciliacionBancaria { get; set; } = new List<DetalleConciliacionBancarium>();
}

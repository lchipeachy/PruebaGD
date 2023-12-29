using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class DepositoEmpresaEntrega
{
    public int CodigoDepositoEmpresaEntrega { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? CodigoCuenta { get; set; }

    public string? NoBoleta { get; set; }

    public decimal? MontoDepositado { get; set; }

    public DateTime? FechaDeposito { get; set; }

    public int? CodigoEstadoDepositoEmpresaEntrega { get; set; }

    public int? CodigoTransaccion { get; set; }

    public int? CodigoTransaccionAnulacion { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public int? CodigoUsuarioDeposito { get; set; }

    public string? Urlimagen { get; set; }

    public DateTime? FechaUsuarioModificacion { get; set; }

    public virtual Cuentum? CodigoCuentaNavigation { get; set; }

    public virtual EstadoDepositoEmpresaEntrega? CodigoEstadoDepositoEmpresaEntregaNavigation { get; set; }

    public virtual Transaccion? CodigoTransaccionAnulacionNavigation { get; set; }

    public virtual Transaccion? CodigoTransaccionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioDepositoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }
}

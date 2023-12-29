using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Transaccion
{
    public int CodigoTransaccion { get; set; }

    public int? CuentaOrigen { get; set; }

    public int? CuentaDestino { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Monto { get; set; }

    public int? CodigoUsuario { get; set; }

    public string? Referencia { get; set; }

    public int? CodigoCobro { get; set; }

    public int? CodigoGasto { get; set; }

    public bool? Estado { get; set; }

    public int? CodigoTipoTransaccion { get; set; }

    public string? NumeroDeCheque { get; set; }

    public int? CodigoPolizaContable { get; set; }

    public decimal? TipoCambio { get; set; }

    public string? NumeroReferenciaOrigen { get; set; }

    public int? CodigoPedido { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? CodigoTipoIngreso { get; set; }

    public int? CodigoEstadoTransferencia { get; set; }

    public string? NumeroReferenciaDestino { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaUsuarioModificacion { get; set; }

    public virtual Cobro? CodigoCobroNavigation { get; set; }

    public virtual EstadoTransferencium? CodigoEstadoTransferenciaNavigation { get; set; }

    public virtual Gasto? CodigoGastoNavigation { get; set; }

    public virtual Pedido? CodigoPedidoNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContableNavigation { get; set; }

    public virtual TipoIngreso? CodigoTipoIngresoNavigation { get; set; }

    public virtual TipoTransaccion? CodigoTipoTransaccionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }

    public virtual Cuentum? CuentaDestinoNavigation { get; set; }

    public virtual Cuentum? CuentaOrigenNavigation { get; set; }

    public virtual ICollection<DepositoEmpresaEntrega> DepositoEmpresaEntregaCodigoTransaccionAnulacionNavigations { get; set; } = new List<DepositoEmpresaEntrega>();

    public virtual ICollection<DepositoEmpresaEntrega> DepositoEmpresaEntregaCodigoTransaccionNavigations { get; set; } = new List<DepositoEmpresaEntrega>();

    public virtual ICollection<DetalleConciliacionBancarium> DetalleConciliacionBancaria { get; set; } = new List<DetalleConciliacionBancarium>();

    public virtual ICollection<PolizaContableBitacora> PolizaContableBitacoras { get; set; } = new List<PolizaContableBitacora>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Cuentum
{
    public int CodigoCuenta { get; set; }

    public string? Nombre { get; set; }

    public string? Numero { get; set; }

    public int CodigoBanco { get; set; }

    public int? CodigoTipoCuenta { get; set; }

    public decimal? Saldo { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? SaldoInicial { get; set; }

    public int? CodigoEstablecimiento { get; set; }

    public bool? Activa { get; set; }

    public byte[]? Usuario { get; set; }

    public byte[]? Clave { get; set; }

    public byte[]? Codigo { get; set; }

    public int? CodigoCuentaContable { get; set; }

    public byte[]? Usuario2 { get; set; }

    public byte[]? Clave2 { get; set; }

    public byte[]? Codigo2 { get; set; }

    public byte[]? Usuario3 { get; set; }

    public byte[]? Clave3 { get; set; }

    public byte[]? Codigo3 { get; set; }

    public bool? AplicaSaldo { get; set; }

    public string? TelefonosRegistrados { get; set; }

    public int? CodigoMoneda { get; set; }

    public bool? CuentaPublica { get; set; }

    public bool? CajaChica { get; set; }

    public bool CuentaRegistro { get; set; }

    public bool? CuentaReembolso { get; set; }

    public int? CodigoCuentaPadre { get; set; }

    public decimal? LimiteCredito { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public DateTime? FechaSaldoInicialReporte { get; set; }

    public decimal? SaldoInicialReporte { get; set; }

    public virtual ICollection<Cobro> Cobros { get; set; } = new List<Cobro>();

    public virtual Banco CodigoBancoNavigation { get; set; } = null!;

    public virtual CuentaContable? CodigoCuentaContableNavigation { get; set; }

    public virtual Cuentum? CodigoCuentaPadreNavigation { get; set; }

    public virtual Establecimiento? CodigoEstablecimientoNavigation { get; set; }

    public virtual Monedum? CodigoMonedaNavigation { get; set; }

    public virtual TipoCuentum? CodigoTipoCuentaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual ICollection<ConciliacionBancarium> ConciliacionBancaria { get; set; } = new List<ConciliacionBancarium>();

    public virtual ICollection<Deposito> DepositoCuentaDestinoNavigations { get; set; } = new List<Deposito>();

    public virtual ICollection<Deposito> DepositoCuentaOrigenNavigations { get; set; } = new List<Deposito>();

    public virtual ICollection<DepositoEmpresaEntrega> DepositoEmpresaEntregas { get; set; } = new List<DepositoEmpresaEntrega>();

    public virtual ICollection<EmpresaDeEntrega> EmpresaDeEntregas { get; set; } = new List<EmpresaDeEntrega>();

    public virtual ICollection<Establecimiento> EstablecimientoCodigoCuentaCompraNavigations { get; set; } = new List<Establecimiento>();

    public virtual ICollection<Establecimiento> EstablecimientoCodigoCuentaCxPNavigations { get; set; } = new List<Establecimiento>();

    public virtual ICollection<Establecimiento> EstablecimientoCodigoCuentaInventarioNavigations { get; set; } = new List<Establecimiento>();

    public virtual ICollection<Establecimiento> EstablecimientoCuentaPorPagarNavigations { get; set; } = new List<Establecimiento>();

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual ICollection<Cuentum> InverseCodigoCuentaPadreNavigation { get; set; } = new List<Cuentum>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<RedCrediticium> RedCrediticia { get; set; } = new List<RedCrediticium>();

    public virtual ICollection<Transaccion> TransaccionCuentaDestinoNavigations { get; set; } = new List<Transaccion>();

    public virtual ICollection<Transaccion> TransaccionCuentaOrigenNavigations { get; set; } = new List<Transaccion>();
}

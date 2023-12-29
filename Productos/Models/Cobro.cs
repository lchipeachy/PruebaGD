using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Cobro
{
    public int CodigoCobro { get; set; }

    public DateTime? Fecha { get; set; }

    public int? CodigoVenta { get; set; }

    public int? CodigoTipoTransaccionTemp { get; set; }

    public int? UsuarioCobro { get; set; }

    public string? NumeroTarjeta { get; set; }

    public string? VencimientoTarjeta { get; set; }

    public string? NombreTarjeta { get; set; }

    public int? Cuotas { get; set; }

    public decimal? MontoCuota { get; set; }

    public string? CodigoSeguridad { get; set; }

    public int? CodigoRedCrediticia { get; set; }

    public string? NumeroAutorizacion { get; set; }

    public int? CodigoTipoDeTarjeta { get; set; }

    public int? CodigoBanco { get; set; }

    public string? BoletaDeposito { get; set; }

    public int? UsuarioDeposito { get; set; }

    public int? UsuarioTarjeta { get; set; }

    public int? UsuarioEfectivo { get; set; }

    public DateTime? FechaConfirmacion { get; set; }

    public string? ReferenciaCobroTarjeta { get; set; }

    public string? DatosDeSeguridad { get; set; }

    public string? IdDeTransaccion { get; set; }

    public int? CodigoFactura { get; set; }

    public int? CodigoFormaDePago { get; set; }

    public int? UsuarioPago { get; set; }

    public DateTime? FechaPago { get; set; }

    public int? UsuarioCredito { get; set; }

    public int? CodigoCuenta { get; set; }

    public bool? Estado { get; set; }

    public string? BoletaRevision { get; set; }

    public int? UsuarioRevision { get; set; }

    public bool? Cod { get; set; }

    public string? CodigoDeRastreo { get; set; }

    public string? NumeroDeAuditoria { get; set; }

    public int? UsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public int? UsuarioExencion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public bool? ReembolsoTc { get; set; }

    public int? CodigoUsuarioCreacion { get; set; }

    public int? CodigoUsuarioCaptura { get; set; }

    public DateTime? FechaUsuarioCaptura { get; set; }

    public int? CodigoCodigoCanjeable { get; set; }

    public decimal? PorcentajeComision { get; set; }

    public virtual ICollection<ArchivoReembolso> ArchivoReembolsos { get; set; } = new List<ArchivoReembolso>();

    public virtual ICollection<CobroReembolso> CobroReembolsoCodigoCobroNavigations { get; set; } = new List<CobroReembolso>();

    public virtual ICollection<CobroReembolso> CobroReembolsoCodigoCobroReintegroNavigations { get; set; } = new List<CobroReembolso>();

    public virtual Banco? CodigoBancoNavigation { get; set; }

    public virtual ICollection<CodigoCanjeable> CodigoCanjeables { get; set; } = new List<CodigoCanjeable>();

    public virtual CodigoCanjeable? CodigoCodigoCanjeableNavigation { get; set; }

    public virtual Cuentum? CodigoCuentaNavigation { get; set; }

    public virtual FormaDePago? CodigoFormaDePagoNavigation { get; set; }

    public virtual RedCrediticium? CodigoRedCrediticiaNavigation { get; set; }

    public virtual TipoDeTarjetum? CodigoTipoDeTarjetaNavigation { get; set; }

    public virtual TipoTransaccion? CodigoTipoTransaccionTempNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioCapturaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioCreacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual Ventum? CodigoVentaNavigation { get; set; }

    public virtual ICollection<ContraCargo> ContraCargos { get; set; } = new List<ContraCargo>();

    public virtual ICollection<Garantium> Garantia { get; set; } = new List<Garantium>();

    public virtual ICollection<NotaContable> NotaContables { get; set; } = new List<NotaContable>();

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();

    public virtual Usuario? UsuarioCobroNavigation { get; set; }

    public virtual Usuario? UsuarioCreditoNavigation { get; set; }

    public virtual Usuario? UsuarioDepositoNavigation { get; set; }

    public virtual Usuario? UsuarioEfectivoNavigation { get; set; }

    public virtual Usuario? UsuarioExencionNavigation { get; set; }

    public virtual Usuario? UsuarioPagoNavigation { get; set; }

    public virtual Usuario? UsuarioRevisionNavigation { get; set; }

    public virtual Usuario? UsuarioTarjetaNavigation { get; set; }
}

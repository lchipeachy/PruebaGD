using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Gasto
{
    public int CodigoGasto { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Monto { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? CodigoTipoDeGasto { get; set; }

    public string? Nit { get; set; }

    public string? Factura { get; set; }

    public int? CodigoFormaDePago { get; set; }

    public int? CuentaOrigen { get; set; }

    public int? CodigoUsuario { get; set; }

    public bool? Estado { get; set; }

    public int? CodigoProveedor { get; set; }

    public int? CodigoClaseDocumento { get; set; }

    public DateTime? FechaOperacion { get; set; }

    public DateTime? FechaRevision { get; set; }

    public DateTime? FechaAplica { get; set; }

    public string? Imagen { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? BoletaDeposito { get; set; }

    public int? CodigoPolizaContableProveedor { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public decimal? Isr { get; set; }

    public int? CodigoGastoImpuestoAduanero { get; set; }

    public bool? PolizaMayor { get; set; }

    public bool GastoNoDeducible { get; set; }

    public int? CodigoUsuarioModificaGastoNoDeducible { get; set; }

    public DateTime? FechaModificaGastoNoDeducible { get; set; }

    public virtual ICollection<CodigoCanjeable> CodigoCanjeables { get; set; } = new List<CodigoCanjeable>();

    public virtual ClaseDocumento? CodigoClaseDocumentoNavigation { get; set; }

    public virtual FormaDePago? CodigoFormaDePagoNavigation { get; set; }

    public virtual Gasto? CodigoGastoImpuestoAduaneroNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContableProveedorNavigation { get; set; }

    public virtual Proveedor? CodigoProveedorNavigation { get; set; }

    public virtual TipoDeGasto? CodigoTipoDeGastoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificaGastoNoDeducibleNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }

    public virtual Cuentum? CuentaOrigenNavigation { get; set; }

    public virtual ICollection<GastoDetalle> GastoDetalles { get; set; } = new List<GastoDetalle>();

    public virtual ICollection<ImagenGasto> ImagenGastos { get; set; } = new List<ImagenGasto>();

    public virtual ICollection<Gasto> InverseCodigoGastoImpuestoAduaneroNavigation { get; set; } = new List<Gasto>();

    public virtual ICollection<PolizaContableBitacora> PolizaContableBitacoras { get; set; } = new List<PolizaContableBitacora>();

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();
}

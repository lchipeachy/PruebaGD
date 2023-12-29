using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Movimiento
{
    public int CodigoMovimiento { get; set; }

    public int CodigoTipoMovimiento { get; set; }

    public int? CodigoProducto { get; set; }

    public string? VentaEmbarqueAnt { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? Fecha { get; set; }

    public bool? Actualizado { get; set; }

    public int? CodigoUsuario { get; set; }

    public int? CodigoVenta { get; set; }

    public string? CodigoEmbarque { get; set; }

    public string? Observaciones { get; set; }

    public int? CodigoPolizaEntradaMercaderia { get; set; }

    public int? CodigoPolizaEntradaArancel { get; set; }

    public int? CodigoPolizaSalidaMercaderia { get; set; }

    public int? CodigoPolizaSalidaArancel { get; set; }

    public int? CantidadAnterior { get; set; }

    public int? DiasAtraso { get; set; }

    public virtual Embarque? CodigoEmbarqueNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaEntradaArancelNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaEntradaMercaderiaNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaSalidaArancelNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaSalidaMercaderiaNavigation { get; set; }

    public virtual Producto? CodigoProductoNavigation { get; set; }

    public virtual TipoMovimiento CodigoTipoMovimientoNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }

    public virtual Ventum? CodigoVentaNavigation { get; set; }
}

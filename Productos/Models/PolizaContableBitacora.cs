using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PolizaContableBitacora
{
    public int CodigoBitacora { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Monto { get; set; }

    public string? Descripcion { get; set; }

    public int? CodigoOrigen { get; set; }

    public int? CodigoDestino { get; set; }

    public string? Mensaje { get; set; }

    public DateTime? FhIngreso { get; set; }

    public int CodigoTipoEscenarioContable { get; set; }

    public int? CodigoFactura { get; set; }

    public int? CodigoTransaccion { get; set; }

    public int? CodigoGasto { get; set; }

    public int? CodigoPedido { get; set; }

    public int? CodigoPaquete { get; set; }

    public int? CodigoNotaContable { get; set; }

    public int? CodigoPolizaContable { get; set; }

    public virtual Factura? CodigoFacturaNavigation { get; set; }

    public virtual Gasto? CodigoGastoNavigation { get; set; }

    public virtual NotaContable? CodigoNotaContableNavigation { get; set; }

    public virtual Paquete? CodigoPaqueteNavigation { get; set; }

    public virtual Pedido? CodigoPedidoNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContableNavigation { get; set; }

    public virtual TipoEscenarioContable CodigoTipoEscenarioContableNavigation { get; set; } = null!;

    public virtual Transaccion? CodigoTransaccionNavigation { get; set; }
}

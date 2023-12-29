using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class FacturaDetalle
{
    public int CodigoFactura { get; set; }

    public decimal PrecioUnitario { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Cantidad { get; set; }

    public int? CodigoProducto { get; set; }

    public int? CodigoVenta { get; set; }

    public int? CodigoServicio { get; set; }

    public int? CodigoPolizaContableServicio { get; set; }

    public virtual PolizaContable? CodigoPolizaContableServicioNavigation { get; set; }

    public virtual Servicio? CodigoServicioNavigation { get; set; }
}

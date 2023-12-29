using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class InventarioDiario
{
    public DateTime? Fecha { get; set; }

    public int CodigoEstablecimiento { get; set; }

    public decimal Monto { get; set; }

    public decimal MontoVenta { get; set; }

    public short CantidadDeProductos { get; set; }

    public short CantidadDeProductosDiferentes { get; set; }
}

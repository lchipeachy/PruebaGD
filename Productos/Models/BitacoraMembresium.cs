using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class BitacoraMembresium
{
    public int CodigoBitacoraMembresia { get; set; }

    public int CodigoMembresia { get; set; }

    public int CodigoFactura { get; set; }

    public DateTime? FechaActivacion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int CodigoMovimientoMembresia { get; set; }

    public virtual Factura CodigoFacturaNavigation { get; set; } = null!;

    public virtual Membresium CodigoMembresiaNavigation { get; set; } = null!;

    public virtual MovimientoMembresium CodigoMovimientoMembresiaNavigation { get; set; } = null!;
}

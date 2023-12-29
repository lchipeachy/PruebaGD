using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PorcentajeRetencionExencion
{
    public int CodigoPorcentajeRetencionExencion { get; set; }

    public decimal Porcentaje { get; set; }

    public short CodigoRegimenFactura { get; set; }

    public virtual RegimenFactura CodigoRegimenFacturaNavigation { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}

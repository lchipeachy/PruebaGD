using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class RegimenFactura
{
    public short CodigoRegimenFactura { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<PorcentajeRetencionExencion> PorcentajeRetencionExencions { get; set; } = new List<PorcentajeRetencionExencion>();
}

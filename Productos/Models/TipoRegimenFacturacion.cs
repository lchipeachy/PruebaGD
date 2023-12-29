using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoRegimenFacturacion
{
    public short CodigoTipoRegimenFacturacion { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Resolucion> Resolucions { get; set; } = new List<Resolucion>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MedioDesuscripcion
{
    public int CodigoMedioDesuscripcion { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Suscripcion> Suscripcions { get; set; } = new List<Suscripcion>();
}

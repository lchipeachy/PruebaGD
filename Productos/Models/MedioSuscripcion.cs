using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MedioSuscripcion
{
    public int CodigoMedioSuscripcion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Suscripcion> Suscripcions { get; set; } = new List<Suscripcion>();
}

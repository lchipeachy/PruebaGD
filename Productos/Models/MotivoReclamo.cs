using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MotivoReclamo
{
    public int CodigoMotivoReclamo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<PaqueteReclamado> PaqueteReclamados { get; set; } = new List<PaqueteReclamado>();
}

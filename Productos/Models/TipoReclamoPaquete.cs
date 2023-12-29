using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoReclamoPaquete
{
    public int CodigoTipoReclamoPaquete { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<PaqueteReclamado> PaqueteReclamados { get; set; } = new List<PaqueteReclamado>();
}

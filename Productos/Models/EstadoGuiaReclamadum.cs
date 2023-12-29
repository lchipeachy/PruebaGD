using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoGuiaReclamadum
{
    public int CodigoEstadoGuiaReclamada { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<GuiaReclamadum> GuiaReclamada { get; set; } = new List<GuiaReclamadum>();
}

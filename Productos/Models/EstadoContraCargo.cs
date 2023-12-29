using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoContraCargo
{
    public int CodigoEstadoContraCargo { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<ContraCargo> ContraCargos { get; set; } = new List<ContraCargo>();
}

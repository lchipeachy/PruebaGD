using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Localidad
{
    public int CodigoLocalidad { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Garantium> Garantia { get; set; } = new List<Garantium>();
}

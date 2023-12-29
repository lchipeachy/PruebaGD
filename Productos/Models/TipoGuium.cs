using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoGuium
{
    public int CodigoTipoGuia { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<FormaDePago> FormaDePagos { get; set; } = new List<FormaDePago>();
}

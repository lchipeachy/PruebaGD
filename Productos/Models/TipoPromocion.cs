using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoPromocion
{
    public int CodigoTipoPromocion { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Promocion> Promocions { get; set; } = new List<Promocion>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ValorAtributo
{
    public int CodigoValorAtributo { get; set; }

    public int CodigoAtributo { get; set; }

    public string Valor { get; set; } = null!;

    public virtual Atributo CodigoAtributoNavigation { get; set; } = null!;

    public virtual ICollection<Producto> CodigoProductos { get; set; } = new List<Producto>();
}

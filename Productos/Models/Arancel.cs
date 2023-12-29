using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Arancel
{
    public int CodigoArancel { get; set; }

    public int? Valor { get; set; }

    public virtual ICollection<GestionCorreoExencion> GestionCorreoExencions { get; set; } = new List<GestionCorreoExencion>();
}

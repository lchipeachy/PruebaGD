using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Caby
{
    public int CodigoCaby { get; set; }

    public string? IdentificadorCategoriaCaby { get; set; }

    public string? NombreCaby { get; set; }

    public decimal? ImpuestoCaby { get; set; }

    public virtual ICollection<BitacoraServicioCaby> BitacoraServicioCabies { get; set; } = new List<BitacoraServicioCaby>();

    public virtual ICollection<ProductoCaby> ProductoCabies { get; set; } = new List<ProductoCaby>();

    public virtual ICollection<VentaCaby> VentaCabies { get; set; } = new List<VentaCaby>();
}

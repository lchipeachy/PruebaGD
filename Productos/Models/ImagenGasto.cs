using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ImagenGasto
{
    public int CodigoImagenGasto { get; set; }

    public DateTime FechaSubida { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public string Urlimagen { get; set; } = null!;

    public bool Estado { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public int? CodigoUsuarioEliminacion { get; set; }

    public int CodigoGasto { get; set; }

    public virtual Gasto CodigoGastoNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioEliminacionNavigation { get; set; }
}

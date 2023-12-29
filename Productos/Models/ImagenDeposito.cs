using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ImagenDeposito
{
    public int CodigoImagenDeposito { get; set; }

    public DateTime FechaSubida { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public string? Urlimagen { get; set; }

    public bool Estado { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public int? CodigoUsuarioEliminacion { get; set; }

    public int CodigoTransaccion { get; set; }

    public virtual Transaccion CodigoTransaccionNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioEliminacionNavigation { get; set; }
}

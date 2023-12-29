using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ImagenGuiaReclamadum
{
    public int CodigoImagenGuiaReclamo { get; set; }

    public DateTime FechaSubida { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public string? Urlimagen { get; set; }

    public bool Estado { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public int? CodigoUsuarioEliminacion { get; set; }

    public int CodigoGuiaReclamada { get; set; }

    public virtual GuiaReclamadum CodigoGuiaReclamadaNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioEliminacionNavigation { get; set; }
}

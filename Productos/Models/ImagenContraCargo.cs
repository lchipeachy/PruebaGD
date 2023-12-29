using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ImagenContraCargo
{
    public int CodigoImagenContraCargo { get; set; }

    public int CodigoContraCargo { get; set; }

    public DateTime FechaSubida { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public string? UrlImagen { get; set; }

    public string? Descripcion { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public bool Activo { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public int? CodigoUsuarioEliminacion { get; set; }

    public virtual ContraCargo CodigoContraCargoNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioEliminacionNavigation { get; set; }
}

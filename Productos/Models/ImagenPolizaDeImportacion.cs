using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ImagenPolizaDeImportacion
{
    public int CodigoImagenPolizaDeImportacion { get; set; }

    public int CodigoPolizaDeImportacion { get; set; }

    public DateTime FechaSubida { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public string? UrlImagen { get; set; }

    public string? Descripcion { get; set; }

    public bool Activo { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public int? CodigoUsuarioEliminacion { get; set; }

    public virtual PolizaDeImportacion CodigoPolizaDeImportacionNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioEliminacionNavigation { get; set; }
}

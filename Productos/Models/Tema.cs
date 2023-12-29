using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Tema
{
    public int CodigoTema { get; set; }

    public int? CodigoTemaPadre { get; set; }

    public string? Nombre { get; set; }

    public string? NombreContenidoBucket { get; set; }

    public int? CodigoUsuarioEncargado { get; set; }

    public int? CodigoUsuarioUltimaModificacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public bool? EstadoDocumentacion { get; set; }

    public int? CodigoUsuarioElimina { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public virtual Tema? CodigoTemaPadreNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioEliminaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioEncargadoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioUltimaModificacionNavigation { get; set; }

    public virtual ICollection<ImagenTema> ImagenTemas { get; set; } = new List<ImagenTema>();

    public virtual ICollection<Tema> InverseCodigoTemaPadreNavigation { get; set; } = new List<Tema>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class DireccionImportador
{
    public int CodigoDireccionImportador { get; set; }

    public int CodigoImportador { get; set; }

    public string DireccionImportador1 { get; set; } = null!;

    public DateTime? FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Activo { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public virtual Importador CodigoImportadorNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }
}

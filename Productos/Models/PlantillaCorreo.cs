using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PlantillaCorreo
{
    public int CodigoPlantillaCorreo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Contenido { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaInactivo { get; set; }

    public int? CodigoUsuarioInactivo { get; set; }

    public bool Activo { get; set; }

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioInactivoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }
}

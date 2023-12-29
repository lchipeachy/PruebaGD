using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CorreoPersonalizado
{
    public int CodigoCorreoPersonalizado { get; set; }

    public string? Titulo { get; set; }

    public string? Encabezado { get; set; }

    public string? Cuerpo { get; set; }

    public DateOnly? FechaEnvio { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? CodigoUsuarioCreacion { get; set; }

    public bool? Activo { get; set; }

    public bool? CorreoEnviado { get; set; }

    public string? Imagen { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaUsuarioModificacion { get; set; }

    public virtual Usuario? CodigoUsuarioCreacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }
}

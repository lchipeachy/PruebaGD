using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class UsuarioAplicacionExternaUsuario
{
    public int CodigoUsuario { get; set; }

    public int CodigoUsuarioAplicacionExterna { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Activo { get; set; }

    public int? CodigoUsuarioInactivo { get; set; }

    public DateTime? FechaUsuarioInactivo { get; set; }

    public virtual UsuarioAplicacionExterna CodigoUsuarioAplicacionExternaNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioInactivoNavigation { get; set; }

    public virtual Usuario CodigoUsuarioNavigation { get; set; } = null!;
}

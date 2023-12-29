using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Plaza
{
    public int CodigoPlaza { get; set; }

    public bool Estado { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? CodigoUsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public int? CodigoUsuarioEstado { get; set; }

    public DateTime? FechaEstado { get; set; }

    public virtual ICollection<AplicacionPlaza> AplicacionPlazas { get; set; } = new List<AplicacionPlaza>();

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioEstadoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificaNavigation { get; set; }
}

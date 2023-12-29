using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class RazonAnulacionVentum
{
    public int CodigoRazonAnulacionVenta { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? CodigoUsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? CodigoUsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public bool Activo { get; set; }

    public virtual Usuario? CodigoUsuarioCreacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioEliminacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class RevisionProducto
{
    public int CodigoRevisionProducto { get; set; }

    public int? CodigoProducto { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? Fecha { get; set; }

    public int? CodigoUsuario { get; set; }

    public int? CodigoEstadoRevision { get; set; }

    public int? CodigoRevisionAnterior { get; set; }

    public int? CodigoPenalizacion { get; set; }

    public virtual EstadoRevision? CodigoEstadoRevisionNavigation { get; set; }

    public virtual Penalizacion? CodigoPenalizacionNavigation { get; set; }

    public virtual Producto? CodigoProductoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

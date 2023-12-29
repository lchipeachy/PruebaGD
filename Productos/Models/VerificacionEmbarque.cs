using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VerificacionEmbarque
{
    public int CodigoVerificacionEmbarque { get; set; }

    public string? CodigoEmbarque { get; set; }

    public string? Upc { get; set; }

    public string? CodigoDeRastreo { get; set; }

    public int? CodigoUsuario { get; set; }

    public int? CodigoProducto { get; set; }

    public int? CodigoPedido { get; set; }

    public string? FotoVerificacion { get; set; }

    public string? ComentarioVerificacion { get; set; }

    public virtual Embarque? CodigoEmbarqueNavigation { get; set; }

    public virtual Pedido? CodigoPedidoNavigation { get; set; }

    public virtual Producto? CodigoProductoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

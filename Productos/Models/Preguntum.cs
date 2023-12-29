using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Preguntum
{
    public int CodigoPregunta { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Nombre { get; set; }

    public string? Correo { get; set; }

    public string? Pregunta { get; set; }

    public string? Respuesta { get; set; }

    public DateTime? FechaRespuesta { get; set; }

    public int? CodigoProducto { get; set; }

    public int? CodigoUsuario { get; set; }

    public int? CodigoTipoPregunta { get; set; }

    public int? CodigoVenta { get; set; }

    public string? CodigoAmazon { get; set; }

    public int? CodigoFactura { get; set; }

    public short? CodigoEstadoPregunta { get; set; }

    public int? CodigoPreguntaPrincipal { get; set; }

    public virtual EstadoPreguntum? CodigoEstadoPreguntaNavigation { get; set; }

    public virtual Producto? CodigoProductoNavigation { get; set; }

    public virtual TipoPreguntum? CodigoTipoPreguntaNavigation { get; set; }

    public virtual Ventum? CodigoVentaNavigation { get; set; }
}

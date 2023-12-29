using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Promocion
{
    public int CodigoPromocion { get; set; }

    public int? CodigoProducto { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public int? CodigoCategoria { get; set; }

    public string? NombreEnIngles { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Hora { get; set; }

    public int? Duracion { get; set; }

    public byte? CodigoEstadoPromocion { get; set; }

    public string? Ganador { get; set; }

    public string? CodigoVenta { get; set; }

    public int? Reservado { get; set; }

    public decimal? PrecioFinalizacion { get; set; }

    public int? HorasCorreo { get; set; }

    public int? DiasPrecioNormal { get; set; }

    public string? Titulo { get; set; }

    public int? CodigoUsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? CodigoUsuarioModifica { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? CodigoUsuarioFinaliza { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public int? CodigoTipoPromocion { get; set; }

    public virtual EstadoPromocion? CodigoEstadoPromocionNavigation { get; set; }

    public virtual TipoPromocion? CodigoTipoPromocionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioCreacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioFinalizaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificaNavigation { get; set; }
}

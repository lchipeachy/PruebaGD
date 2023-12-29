using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class UbicacionTemporalDespacho
{
    public int CodigoUbicacionTemporalDespacho { get; set; }

    public int? CodigoVenta { get; set; }

    public string? Upc { get; set; }

    public int? CodigoUbicacionDespacho { get; set; }

    public DateTime? FechaUbicacion { get; set; }

    public int? CodigoUsuarioUbicacion { get; set; }

    public DateTime? FechaDesubicacion { get; set; }

    public int? CodigoUsuarioDesubicacion { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Sugerencium
{
    public int CodigoSugerencia { get; set; }

    public DateTime Fecha { get; set; }

    public string Correo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? CodigoAmazon { get; set; }

    public DateTime? Notificada { get; set; }

    public bool? Aprobada { get; set; }

    public byte? PrecioAprobado { get; set; }

    public decimal? PrecioCosto { get; set; }

    public decimal? PrecioSugerido { get; set; }

    public DateOnly? NotificacionReserva { get; set; }
}

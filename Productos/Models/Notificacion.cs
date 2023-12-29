using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Notificacion
{
    public int CodigoNotificacion { get; set; }

    public DateTime Fecha { get; set; }

    public string? Correo { get; set; }

    public int CodigoProducto { get; set; }

    public DateTime? Notificada { get; set; }

    public DateOnly? NotificacionReserva { get; set; }

    public DateTime? FechaDisponible { get; set; }

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;
}

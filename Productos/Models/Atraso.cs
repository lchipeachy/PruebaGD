using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Atraso
{
    public int CodigoAtraso { get; set; }

    public DateTime? Fecha { get; set; }

    public byte? Dias { get; set; }

    public int CodigoUsuario { get; set; }

    public string? Observaciones { get; set; }

    public int? Notificaciones { get; set; }

    public int? Pedidos { get; set; }
}

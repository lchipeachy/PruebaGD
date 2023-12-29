using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Inventario
{
    public int CodigoInventario { get; set; }

    public DateTime? FechaInicial { get; set; }

    public DateTime? FechaFinal { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<VerificacionInventarioUbicacion> VerificacionInventarioUbicacions { get; set; } = new List<VerificacionInventarioUbicacion>();

    public virtual ICollection<VerificacionInventario> VerificacionInventarios { get; set; } = new List<VerificacionInventario>();
}

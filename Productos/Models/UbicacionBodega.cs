using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class UbicacionBodega
{
    public int CodigoUbicacionBodega { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Producto> ProductoCodigoUbicacionBodegaAnteriorNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoCodigoUbicacionBodegaNavigations { get; set; } = new List<Producto>();

    public virtual ICollection<VerificacionInventarioUbicacion> VerificacionInventarioUbicacions { get; set; } = new List<VerificacionInventarioUbicacion>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VerificacionInventarioUbicacion
{
    public int CodigoVerificacionInventarioUbicacion { get; set; }

    public int CodigoInventario { get; set; }

    public int CodigoUbicacion { get; set; }

    public DateTime Fecha { get; set; }

    public virtual Inventario CodigoInventarioNavigation { get; set; } = null!;

    public virtual UbicacionBodega CodigoUbicacionNavigation { get; set; } = null!;
}

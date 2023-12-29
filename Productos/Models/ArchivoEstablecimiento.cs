using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ArchivoEstablecimiento
{
    public int CodigoArchivoEstablecimiento { get; set; }

    public int CodigoEstablecimiento { get; set; }

    public string? Nombre { get; set; }

    public string? Ruta { get; set; }

    public string? Descripcion { get; set; }

    public DateTime Fecha { get; set; }

    public bool Activo { get; set; }

    public virtual Establecimiento CodigoEstablecimientoNavigation { get; set; } = null!;
}

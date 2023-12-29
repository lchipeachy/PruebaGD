using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VwSalidaDispositivo
{
    public int Codigo { get; set; }

    public string? Tipo { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public long? Upc { get; set; }

    public string? Asignado { get; set; }

    public string? Descripcion { get; set; }

    public string? Observaciones { get; set; }
}

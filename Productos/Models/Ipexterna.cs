using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Ipexterna
{
    public DateTime? Fecha { get; set; }

    public string? Ip { get; set; }

    public string? UrlOrigen { get; set; }

    public string? UrlDestino { get; set; }

    public string? TituloPagina { get; set; }

    public string? Pais { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Bitacora
{
    public int CodigoBitacora { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Usuario { get; set; }

    public string? Archivo { get; set; }

    public string? Resultado { get; set; }

    public string? Nota { get; set; }

    public string? Correo { get; set; }
}

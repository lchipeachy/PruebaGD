using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Resena
{
    public int CodigoResena { get; set; }

    public string? NombreCliente { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? NombreProducto { get; set; }

    public string? Descripcion { get; set; }
}

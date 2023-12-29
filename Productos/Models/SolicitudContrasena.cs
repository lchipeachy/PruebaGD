using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class SolicitudContrasena
{
    public int Codigo { get; set; }

    public int? Usuario { get; set; }

    public string? Operador { get; set; }

    public string? Email { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Id { get; set; }

    public byte? Estado { get; set; }

    public int? CodigoCliente { get; set; }

    public virtual Cliente? CodigoClienteNavigation { get; set; }
}

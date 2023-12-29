using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VerificacionEmpaque
{
    public int CodigoVerificacionEmpaque { get; set; }

    public int CodigoVenta { get; set; }

    public int CodigoUsuarioVerificacion { get; set; }

    public DateTime FechaVerificacion { get; set; }

    public string Upc { get; set; } = null!;

    public virtual Usuario CodigoUsuarioVerificacionNavigation { get; set; } = null!;

    public virtual Ventum CodigoVentaNavigation { get; set; } = null!;
}

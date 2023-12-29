using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Parametro
{
    public int CodigoParametro { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Valor { get; set; }

    public string? Descripcion { get; set; }

    public int? CodigoUsuarioModifica { get; set; }

    public DateTime? FechaUsuarioModifica { get; set; }

    public virtual Usuario? CodigoUsuarioModificaNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoTransferencium
{
    public int CodigoEstadoTransferencia { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();
}

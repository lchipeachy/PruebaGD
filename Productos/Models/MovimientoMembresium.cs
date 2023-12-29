using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MovimientoMembresium
{
    public int CodigoMovimientoMembresia { get; set; }

    public string NombreMovimiento { get; set; } = null!;

    public virtual ICollection<BitacoraMembresium> BitacoraMembresia { get; set; } = new List<BitacoraMembresium>();
}

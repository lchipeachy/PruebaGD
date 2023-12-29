using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoEscenarioContable
{
    public int CodigoTipoEscenarioContable { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Algoritmo { get; set; }

    public bool? PermiteMultiplesEscenarios { get; set; }

    public virtual ICollection<EscenarioContable> EscenarioContables { get; set; } = new List<EscenarioContable>();

    public virtual ICollection<PolizaContableBitacora> PolizaContableBitacoras { get; set; } = new List<PolizaContableBitacora>();
}

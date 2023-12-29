using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Regiman
{
    public int CodigoRegimen { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<BitacoraRegimenProveedor> BitacoraRegimenProveedors { get; set; } = new List<BitacoraRegimenProveedor>();

    public virtual ICollection<ParametroPorcentajeImpuesto> ParametroPorcentajeImpuestos { get; set; } = new List<ParametroPorcentajeImpuesto>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}

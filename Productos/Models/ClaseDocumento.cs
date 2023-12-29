using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ClaseDocumento
{
    public int CodigoClaseDocumento { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual ICollection<NotaContable> NotaContables { get; set; } = new List<NotaContable>();

    public virtual ICollection<ParametroPorcentajeImpuesto> ParametroPorcentajeImpuestos { get; set; } = new List<ParametroPorcentajeImpuesto>();

    public virtual ICollection<Resolucion> Resolucions { get; set; } = new List<Resolucion>();
}

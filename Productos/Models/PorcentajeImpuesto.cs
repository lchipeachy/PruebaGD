using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PorcentajeImpuesto
{
    public int CodigoPorcentajeImpuesto { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public decimal? Porcentaje { get; set; }

    public decimal? RangoMinimo { get; set; }

    public decimal? RangoMaximo { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<ParametroPorcentajeImpuesto> ParametroPorcentajeImpuestos { get; set; } = new List<ParametroPorcentajeImpuesto>();
}

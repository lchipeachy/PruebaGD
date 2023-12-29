using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoGarantium
{
    public int CodigoEstadoGarantia { get; set; }

    public string Nombre { get; set; } = null!;

    public bool? EstadoFinal { get; set; }

    public virtual ICollection<Garantium> Garantia { get; set; } = new List<Garantium>();

    public virtual ICollection<MovimientoEstadoGarantium> MovimientoEstadoGarantia { get; set; } = new List<MovimientoEstadoGarantium>();

    public virtual ICollection<MovimientoGarantium> MovimientoGarantia { get; set; } = new List<MovimientoGarantium>();
}

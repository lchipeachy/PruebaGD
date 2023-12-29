using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MovimientoGarantium
{
    public int CodigoMovimientoGarantia { get; set; }

    public int? CodigoGarantia { get; set; }

    public int? CodigoUsuarioMovimiento { get; set; }

    public int? CodigoEstadoGarantia { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaHoraUsuarioModifica { get; set; }

    public virtual EstadoGarantium? CodigoEstadoGarantiaNavigation { get; set; }

    public virtual Garantium? CodigoGarantiaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioMovimientoNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MovimientoEstadoGarantium
{
    public int CodigoMovimientoEstadoGarantia { get; set; }

    public int CodigoGarantia { get; set; }

    public int CodigoUsuario { get; set; }

    public int CodigoEstadoGarantia { get; set; }

    public DateTime Fecha { get; set; }

    public virtual EstadoGarantium CodigoEstadoGarantiaNavigation { get; set; } = null!;

    public virtual Garantium CodigoGarantiaNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<CorreoNotificacionGarantium> CorreoNotificacionGarantia { get; set; } = new List<CorreoNotificacionGarantium>();
}

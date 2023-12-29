using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CorreoNotificacionGarantium
{
    public int CodigoCorreoNotificacionGarantia { get; set; }

    public int? CodigoMovimientoEstadoGarantia { get; set; }

    public int? CodigoUsuario { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public virtual MovimientoEstadoGarantium? CodigoMovimientoEstadoGarantiaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

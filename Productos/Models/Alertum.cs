using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Alertum
{
    public int CodigoAlerta { get; set; }

    public string? Nombre { get; set; }

    public int CodigoWebhook { get; set; }

    public bool? Activo { get; set; }

    public int? CodigoUsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual Usuario? CodigoUsuarioCreacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual Webhook CodigoWebhookNavigation { get; set; } = null!;
}

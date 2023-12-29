using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Webhook
{
    public int CodigoWebhook { get; set; }

    public string Canal { get; set; } = null!;

    public string Url { get; set; } = null!;

    public virtual ICollection<Alertum> Alerta { get; set; } = new List<Alertum>();
}

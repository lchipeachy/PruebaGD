using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoDispositivo
{
    public int CodigoTipoDispositivo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public bool? TipoImpresion { get; set; }

    public virtual ICollection<Dispositivo> Dispositivos { get; set; } = new List<Dispositivo>();
}

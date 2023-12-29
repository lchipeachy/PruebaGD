using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class AplicacionExterna
{
    public int CodigoAplicacionExterna { get; set; }

    public string? Nombre { get; set; }

    public int? CodigoTipoAplicacionExterna { get; set; }

    public string? Url { get; set; }

    public bool Estado { get; set; }

    public virtual TipoAplicacionExterna? CodigoTipoAplicacionExternaNavigation { get; set; }

    public virtual ICollection<UsuarioAplicacionExterna> UsuarioAplicacionExternas { get; set; } = new List<UsuarioAplicacionExterna>();
}

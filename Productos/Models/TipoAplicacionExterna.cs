using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoAplicacionExterna
{
    public int CodigoTipoAplicacionExterna { get; set; }

    public string? Nombre { get; set; }

    public bool ImplicaCuentasBancarias { get; set; }

    public bool Estado { get; set; }

    public int? CodigoClaseTipoAplicacionExterna { get; set; }

    public virtual ICollection<AplicacionExterna> AplicacionExternas { get; set; } = new List<AplicacionExterna>();

    public virtual ClaseTipoAplicacionExterna? CodigoClaseTipoAplicacionExternaNavigation { get; set; }
}

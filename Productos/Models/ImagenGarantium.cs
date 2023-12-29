using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ImagenGarantium
{
    public int CodigoImagenGarantia { get; set; }

    public int? CodigoUsuario { get; set; }

    public int? CodigoGarantia { get; set; }

    public DateTime? FechaSubida { get; set; }

    public string? Urlimagen { get; set; }

    public string? Descripcion { get; set; }

    public virtual Garantium? CodigoGarantiaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

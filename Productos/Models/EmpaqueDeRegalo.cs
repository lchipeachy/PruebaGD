using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EmpaqueDeRegalo
{
    public int CodigoEmpaqueDeRegalo { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal? Precio { get; set; }

    public bool? Vigente { get; set; }

    public string? Foto { get; set; }

    public string? De { get; set; }

    public string? Para { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

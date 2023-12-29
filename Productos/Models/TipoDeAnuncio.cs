using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoDeAnuncio
{
    public int CodigoTipoDeAnuncio { get; set; }

    public string? Nombre { get; set; }

    public int? Alto { get; set; }

    public int? Ancho { get; set; }

    public float? Ponderacion { get; set; }

    public bool? EsImagen { get; set; }

    public float? Cpcminimo { get; set; }

    public int? CodigoProducto { get; set; }

    public virtual ICollection<Anuncio> Anuncios { get; set; } = new List<Anuncio>();

    public virtual Producto? CodigoProductoNavigation { get; set; }
}

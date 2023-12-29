using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoDeAnuncio
{
    public int CodigoEstadoDeAnuncio { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Anuncio> Anuncios { get; set; } = new List<Anuncio>();
}

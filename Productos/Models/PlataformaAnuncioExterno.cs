using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PlataformaAnuncioExterno
{
    public int CodigoPlataformaAnuncioExterno { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<AnuncioExterno> AnuncioExternos { get; set; } = new List<AnuncioExterno>();

    public virtual ICollection<CampaniaExterna> CampaniaExternas { get; set; } = new List<CampaniaExterna>();
}

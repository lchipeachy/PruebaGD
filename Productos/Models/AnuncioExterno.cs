using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class AnuncioExterno
{
    public int CodigoProducto { get; set; }

    public int CodigoPlataformaAnuncioExterno { get; set; }

    public int? CodigoCampaniaExterna { get; set; }

    public long? CodigoAnuncio { get; set; }

    public int CodigoEstadoAnuncio { get; set; }

    public long? CodigoGrupo { get; set; }

    public DateTime? FechaCreacionAnuncio { get; set; }

    public DateTime? FechaModificacionAnuncio { get; set; }

    public DateTime? FechaEliminacionAnuncio { get; set; }

    public virtual PlataformaAnuncioExterno CodigoPlataformaAnuncioExternoNavigation { get; set; } = null!;

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;
}

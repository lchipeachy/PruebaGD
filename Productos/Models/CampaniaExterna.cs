using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CampaniaExterna
{
    public string NombreCampaniaExterna { get; set; } = null!;

    public long CodigoCampania { get; set; }

    public byte CodigoEstadoCampaniaExterna { get; set; }

    public int CodigoPlataformaAnuncioExterno { get; set; }

    public int CodigoCampaniaExterna { get; set; }

    public virtual PlataformaAnuncioExterno CodigoPlataformaAnuncioExternoNavigation { get; set; } = null!;
}

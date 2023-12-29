using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ZonaRoja
{
    public int CodigoZonaRoja { get; set; }

    public short? CodigoMunicipio { get; set; }

    public string? Zona { get; set; }

    public string? Lugar { get; set; }

    public virtual Municipio? CodigoMunicipioNavigation { get; set; }
}

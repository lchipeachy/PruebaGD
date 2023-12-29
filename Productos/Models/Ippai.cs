using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Ippai
{
    public string Network { get; set; } = null!;

    public string? GeonameId { get; set; }

    public string? RegisteredCountryGeonameId { get; set; }

    public string? RepresentedCountryGeonameId { get; set; }

    public string? IsAnonymousProxy { get; set; }

    public string? IsSatelliteProvider { get; set; }
}

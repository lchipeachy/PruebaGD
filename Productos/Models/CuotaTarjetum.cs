using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CuotaTarjetum
{
    public int CodigoRedCrediticia { get; set; }

    public short? Cuotas { get; set; }

    public decimal? PorcentajeComision { get; set; }

    public decimal? PorcentajeAcreditacion { get; set; }

    public string? IdentificadorTransaccionCuota { get; set; }

    public virtual RedCrediticium CodigoRedCrediticiaNavigation { get; set; } = null!;
}

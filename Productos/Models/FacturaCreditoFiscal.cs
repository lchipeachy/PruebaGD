using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class FacturaCreditoFiscal
{
    public int CodigoFacturaCreditoFiscal { get; set; }

    public int CodigoFactura { get; set; }

    public string NumeroRegistroFiscal { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string ActividadEconomica { get; set; } = null!;

    public short CodigoDepartamento { get; set; }

    public short CodigoMunicipio { get; set; }

    public string? TelefonoFactura { get; set; }

    public virtual Departamento CodigoDepartamentoNavigation { get; set; } = null!;

    public virtual Factura CodigoFacturaNavigation { get; set; } = null!;

    public virtual Municipio CodigoMunicipioNavigation { get; set; } = null!;
}

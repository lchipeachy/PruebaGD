using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ParametroPorcentajeImpuesto
{
    public int CodigoParametroPorcentajeImpuesto { get; set; }

    public int CodigoPorcentajeImpuesto { get; set; }

    public int CodigoClaseDocumento { get; set; }

    public int CodigoRegimen { get; set; }

    public virtual ClaseDocumento CodigoClaseDocumentoNavigation { get; set; } = null!;

    public virtual PorcentajeImpuesto CodigoPorcentajeImpuestoNavigation { get; set; } = null!;

    public virtual Regiman CodigoRegimenNavigation { get; set; } = null!;
}

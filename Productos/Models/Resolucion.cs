using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Resolucion
{
    public int CodigoResolucion { get; set; }

    public string Resolucion1 { get; set; } = null!;

    public string Serie { get; set; } = null!;

    public int NumeroDeFacturaInicio { get; set; }

    public int NumeroDeFacturaFin { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public string? TipoDocumento { get; set; }

    public int? NumeroDeFacturaActual { get; set; }

    public int? CodigoClaseDocumento { get; set; }

    public DateTime? FechaResolucion { get; set; }

    public bool? EsElectronico { get; set; }

    public bool? Estado { get; set; }

    public short? CodigoTipoRegimenFacturacion { get; set; }

    public virtual ClaseDocumento? CodigoClaseDocumentoNavigation { get; set; }

    public virtual TipoRegimenFacturacion? CodigoTipoRegimenFacturacionNavigation { get; set; }

    public virtual ICollection<NotaContable> NotaContables { get; set; } = new List<NotaContable>();
}

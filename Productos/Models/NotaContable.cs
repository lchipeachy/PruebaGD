using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class NotaContable
{
    public int CodigoNotaContable { get; set; }

    public decimal? Numero { get; set; }

    public string? Serie { get; set; }

    public int? CodigoResolucion { get; set; }

    public int? CodigoConceptoNotaContable { get; set; }

    public int? CodigoFactura { get; set; }

    public DateTime? FechaEmision { get; set; }

    public int? CodigoEstadoNotaContable { get; set; }

    public decimal? ValorNeto { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Total { get; set; }

    public string? Cae { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaAnulacion { get; set; }

    public string? UsuarioAnulacion { get; set; }

    public int? CodigoCobro { get; set; }

    public int? CodigoClaseDocumento { get; set; }

    public string? GuidFirma { get; set; }

    public string? GuidRegistrarDocumento { get; set; }

    public string? GuidAnular { get; set; }

    public string? GuidFirmaResponse { get; set; }

    public string? GuidRegistrarDocumentoResponse { get; set; }

    public string? GuidAnularResponse { get; set; }

    public int? CodigoPolizaContable { get; set; }

    public virtual ClaseDocumento? CodigoClaseDocumentoNavigation { get; set; }

    public virtual Cobro? CodigoCobroNavigation { get; set; }

    public virtual ConceptoNotaContable? CodigoConceptoNotaContableNavigation { get; set; }

    public virtual EstadoNotaContable? CodigoEstadoNotaContableNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContableNavigation { get; set; }

    public virtual Resolucion? CodigoResolucionNavigation { get; set; }

    public virtual ICollection<PolizaContableBitacora> PolizaContableBitacoras { get; set; } = new List<PolizaContableBitacora>();
}

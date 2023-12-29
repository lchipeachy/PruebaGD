using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class EstadoEntregaFactura
{
    public int CodigoEstadoEntregaFactura { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<EmpresaEntregaBitacora> EmpresaEntregaBitacoras { get; set; } = new List<EmpresaEntregaBitacora>();

    public virtual ICollection<EstadoEntregaEmpresaDeEntrega> EstadoEntregaEmpresaDeEntregas { get; set; } = new List<EstadoEntregaEmpresaDeEntrega>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<GuiaEliminadum> GuiaEliminada { get; set; } = new List<GuiaEliminadum>();
}

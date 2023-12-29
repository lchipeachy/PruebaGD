using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class GuiaEliminadum
{
    public int CodigoFactura { get; set; }

    public string NumeroDeGuia { get; set; } = null!;

    public int? CodigoEstadoEntregaFactura { get; set; }

    public DateTime? FechaRecepcionEmpresaDeEntrega { get; set; }

    public short? CodigoEmpresaDeEntrega { get; set; }

    public int? CodigoUsuario { get; set; }

    public DateOnly? FechaEliminacion { get; set; }

    public int CodigoGuiaEliminada { get; set; }

    public string? Observacion { get; set; }

    public virtual EmpresaDeEntrega? CodigoEmpresaDeEntregaNavigation { get; set; }

    public virtual EstadoEntregaFactura? CodigoEstadoEntregaFacturaNavigation { get; set; }

    public virtual Factura CodigoFacturaNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

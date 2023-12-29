using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class HistoricoVale
{
    public int CodigoHistoricoVale { get; set; }

    public decimal Monto { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? Fecha { get; set; }

    public int CodigoTipoHistorico { get; set; }

    public int? CodigoUsuarioCreacion { get; set; }

    public int? CodigoVenta { get; set; }

    public int CodigoCliente { get; set; }

    public int CodigoVale { get; set; }

    public bool? Estado { get; set; }

    public int? CodigoFactura { get; set; }

    public virtual Factura? CodigoFacturaNavigation { get; set; }

    public virtual TipoHistorico CodigoTipoHistoricoNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioCreacionNavigation { get; set; }

    public virtual Vale CodigoValeNavigation { get; set; } = null!;

    public virtual Ventum? CodigoVentaNavigation { get; set; }
}

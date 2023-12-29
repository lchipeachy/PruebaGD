using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class HistoricoPagoVentum
{
    public int? CodigoVenta { get; set; }

    public int? CodigoBanco { get; set; }

    public int? UsuarioPago { get; set; }

    public DateTime? FechaPago { get; set; }

    public virtual Banco? CodigoBancoNavigation { get; set; }

    public virtual Ventum? CodigoVentaNavigation { get; set; }

    public virtual Usuario? UsuarioPagoNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TmpCargareembolso
{
    public int? CodigoTransaccion { get; set; }

    public int? CodigoPedido { get; set; }

    public decimal? Monto { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? CodigoEstablecimiento { get; set; }

    public string? Tarjeta { get; set; }

    public int? CodigoEstadoPedido { get; set; }

    public int? CodigoUsuario { get; set; }

    public bool? Estado { get; set; }

    public DateTime? FechaOperacion { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Embarque
{
    public string CodigoEmbarque { get; set; } = null!;

    public DateTime? FechaPedido { get; set; }

    public DateTime? FechaRecbido { get; set; }

    public decimal? Monto { get; set; }

    public decimal? PorcentajeVendido { get; set; }

    public int? Dias { get; set; }

    public int? Diferencias { get; set; }

    public DateTime? FechaVerificacion { get; set; }

    public bool? EnVerificacion { get; set; }

    public string? CargarArchivo { get; set; }

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<VerificacionEmbarque> VerificacionEmbarques { get; set; } = new List<VerificacionEmbarque>();
}

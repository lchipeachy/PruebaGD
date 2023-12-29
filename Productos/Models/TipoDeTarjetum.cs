using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoDeTarjetum
{
    public int CodigoTipoDeTarjeta { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cobro> Cobros { get; set; } = new List<Cobro>();

    public virtual ICollection<Membresium> Membresia { get; set; } = new List<Membresium>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

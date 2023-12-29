using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoGarantium
{
    public int CodigoTipoGarantia { get; set; }

    public string Nombre { get; set; } = null!;

    public short? TiempoMaximo { get; set; }

    public virtual ICollection<Garantium> Garantia { get; set; } = new List<Garantium>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class BitacoraServicioCaby
{
    public int CodigoBitacoraServicioCaby { get; set; }

    public int CodigoServicio { get; set; }

    public int CodigoCaby { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public bool Activo { get; set; }

    public virtual Caby CodigoCabyNavigation { get; set; } = null!;

    public virtual Servicio CodigoServicioNavigation { get; set; } = null!;
}

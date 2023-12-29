using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Suscripcion
{
    public int CodigoSuscripcion { get; set; }

    public string Correo { get; set; } = null!;

    public bool? Suscrito { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? CodigoMedioSuscripcion { get; set; }

    public int? CodigoMedioDesuscripcion { get; set; }

    public virtual MedioDesuscripcion? CodigoMedioDesuscripcionNavigation { get; set; }

    public virtual MedioSuscripcion? CodigoMedioSuscripcionNavigation { get; set; }
}

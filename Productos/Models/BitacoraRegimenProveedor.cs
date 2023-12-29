using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class BitacoraRegimenProveedor
{
    public int CodigoBitacoraRegimenProveedor { get; set; }

    public int CodigoRegimen { get; set; }

    public int CodigoProveedor { get; set; }

    public DateTime FechaCambioRegimen { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int? CodigoUsuarioModificacionRegimen { get; set; }

    public virtual Proveedor CodigoProveedorNavigation { get; set; } = null!;

    public virtual Regiman CodigoRegimenNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioModificacionRegimenNavigation { get; set; }
}

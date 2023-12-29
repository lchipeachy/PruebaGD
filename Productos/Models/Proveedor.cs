using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Proveedor
{
    public int CodigoProveedor { get; set; }

    public string? Nombre { get; set; }

    public string? Nit { get; set; }

    public int? CodigoRegimen { get; set; }

    public int? CodigoEstablecimiento { get; set; }

    public bool Estado { get; set; }

    public int? CodigoUsuarioRegistro { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaUsuarioRegistro { get; set; }

    public DateTime? FechaUsuarioModificacion { get; set; }

    public bool? AgenteRetenedor { get; set; }

    public virtual ICollection<BitacoraRegimenProveedor> BitacoraRegimenProveedors { get; set; } = new List<BitacoraRegimenProveedor>();

    public virtual Establecimiento? CodigoEstablecimientoNavigation { get; set; }

    public virtual Regiman? CodigoRegimenNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioRegistroNavigation { get; set; }

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();
}

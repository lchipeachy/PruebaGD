using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PolizaDeImportacion
{
    public int CodigoPolizaDeImportacion { get; set; }

    public DateTime FechaPolizaDeImportacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public bool? Activo { get; set; }

    public string? NumeroDua { get; set; }

    public decimal Monto { get; set; }

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual ICollection<ImagenPolizaDeImportacion> ImagenPolizaDeImportacions { get; set; } = new List<ImagenPolizaDeImportacion>();

    public virtual ICollection<Paquete> Paquetes { get; set; } = new List<Paquete>();
}

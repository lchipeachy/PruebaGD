using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ContraCargo
{
    public int CodigoContraCargo { get; set; }

    public int CodigoCobro { get; set; }

    public DateTime FechaContraCargo { get; set; }

    public int CodigoEstadoContraCargo { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Activo { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? Descripcion { get; set; }

    public virtual Cobro CodigoCobroNavigation { get; set; } = null!;

    public virtual EstadoContraCargo CodigoEstadoContraCargoNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual ICollection<ImagenContraCargo> ImagenContraCargos { get; set; } = new List<ImagenContraCargo>();
}

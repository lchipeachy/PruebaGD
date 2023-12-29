using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoLicenciaVacacione
{
    public int CodigoTipoLicenciaVacaciones { get; set; }

    public string Nombre { get; set; } = null!;

    public double Cantidad { get; set; }

    public bool AfectaVacaciones { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? CodigoUsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public int? CodigoUsuarioActivo { get; set; }

    public DateTime? FechaActivo { get; set; }

    public bool Activo { get; set; }

    public virtual Usuario? CodigoUsuarioActivoNavigation { get; set; }

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioModificaNavigation { get; set; }

    public virtual ICollection<Vacacion> Vacacions { get; set; } = new List<Vacacion>();
}

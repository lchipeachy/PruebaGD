using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Vacacion
{
    public int CodigoUsuario { get; set; }

    public DateTime FechaInicio { get; set; }

    public double Dias { get; set; }

    public string? Observacion { get; set; }

    public DateTime? FechaElimina { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? CodigoUsuarioElimina { get; set; }

    public int? CodigoUsuarioCreacion { get; set; }

    public int? Estado { get; set; }

    public bool? Enfermedad { get; set; }

    public bool? Penalizacion { get; set; }

    public int CodigoTipoLicenciaVacaciones { get; set; }

    public string? MotivoEliminacion { get; set; }

    public virtual TipoLicenciaVacacione CodigoTipoLicenciaVacacionesNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioCreacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioEliminaNavigation { get; set; }

    public virtual Usuario CodigoUsuarioNavigation { get; set; } = null!;
}

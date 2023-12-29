using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ArchivoPaquete
{
    public int CodigoArchivoPaquete { get; set; }

    public int CodigoPaquete { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Observacion { get; set; }

    public int CodigoUsuarioRegistro { get; set; }

    public int? CodigoUsuarioElimina { get; set; }

    public string Ruta { get; set; } = null!;

    public DateTime FechaUsuarioRegistro { get; set; }

    public DateTime? FechaUsuarioElimina { get; set; }

    public bool Activo { get; set; }

    public virtual Paquete CodigoPaqueteNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioEliminaNavigation { get; set; }

    public virtual Usuario CodigoUsuarioRegistroNavigation { get; set; } = null!;
}

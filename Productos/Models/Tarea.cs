using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Tarea
{
    public short CodigoTarea { get; set; }

    public int? CodigoUsuario { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public byte? Prioridad { get; set; }

    public string? Nombre { get; set; }

    public bool? Notificacion { get; set; }

    public decimal? Horas { get; set; }

    public DateTime? UltimaModificacion { get; set; }

    public int? CodigoUsuarioSupervisor { get; set; }

    public bool? NotificacionSupervisor { get; set; }

    public bool? Inactivo { get; set; }

    public bool Revision { get; set; }

    public int? CodigoUsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public DateTime? FechaDeEntrega { get; set; }

    public bool? SinFechaDeEntrega { get; set; }

    public bool RevisionCreador { get; set; }

    public DateTime? UltimaModificacionCreador { get; set; }

    public virtual Usuario? CodigoUsuarioEliminacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioSupervisorNavigation { get; set; }
}

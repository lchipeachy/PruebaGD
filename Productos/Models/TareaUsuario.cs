using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TareaUsuario
{
    public short? CodigoTarea { get; set; }

    public int? CodigoUsuario { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public bool? Notificacion { get; set; }

    public DateTime? FechaUltimaModificacion { get; set; }

    public decimal? Secuencia { get; set; }

    public int? EsUsuarioPrincipal { get; set; }

    public virtual Tarea? CodigoTareaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

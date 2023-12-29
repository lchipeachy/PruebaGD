using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Entradum
{
    public int? CodigoUsuario { get; set; }

    public bool? EntradaSalida { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Ip { get; set; }

    public long CodigoEntrada { get; set; }

    public TimeOnly? HoraEntradaUsuario { get; set; }

    public TimeOnly? HoraSalidaUsuario { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

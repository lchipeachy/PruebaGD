using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ArchivoTarea
{
    public int? CodigoArchivo { get; set; }

    public short? CodigoTarea { get; set; }

    public string? Nombre { get; set; }

    public string? Ruta { get; set; }

    public DateTime? Fecha { get; set; }

    public int? CodigoUsuario { get; set; }

    public string? Descripcion { get; set; }

    public virtual Tarea? CodigoTareaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }
}

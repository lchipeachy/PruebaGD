using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class DirectorioEmpresa
{
    public int CodigoDirectorioEmpresa { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public DateOnly? FechaModificacion { get; set; }

    public virtual ICollection<DirectorioContacto> DirectorioContactos { get; set; } = new List<DirectorioContacto>();
}

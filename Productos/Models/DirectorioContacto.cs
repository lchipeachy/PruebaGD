using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class DirectorioContacto
{
    public int CodigoDirectorioContacto { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono1 { get; set; }

    public string? Telefono2 { get; set; }

    public string? Departamento { get; set; }

    public string? Puesto { get; set; }

    public string? Correo { get; set; }

    public int? CodigoDirectorioEmpresa { get; set; }

    public DateOnly? FechaModificacion { get; set; }

    public virtual DirectorioEmpresa? CodigoDirectorioEmpresaNavigation { get; set; }
}

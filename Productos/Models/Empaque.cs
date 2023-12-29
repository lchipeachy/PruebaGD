using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Empaque
{
    public int CodigoEmpaque { get; set; }

    public string? Foto { get; set; }

    public string? Nombre { get; set; }

    public bool? Activo { get; set; }

    public bool EmpaqueRetorno { get; set; }

    public virtual ICollection<EmpresaDeEntrega> CodigoEmpresaDeEntregas { get; set; } = new List<EmpresaDeEntrega>();
}

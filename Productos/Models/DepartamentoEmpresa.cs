using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class DepartamentoEmpresa
{
    public int CodigoDepartamentoEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? CodigoDepartamentoPadre { get; set; }

    public virtual DepartamentoEmpresa? CodigoDepartamentoPadreNavigation { get; set; }

    public virtual ICollection<DepartamentoEmpresa> InverseCodigoDepartamentoPadreNavigation { get; set; } = new List<DepartamentoEmpresa>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

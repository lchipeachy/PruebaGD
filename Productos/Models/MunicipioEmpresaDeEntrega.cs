using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MunicipioEmpresaDeEntrega
{
    public short CodigoMunicipio { get; set; }

    public short CodigoEmpresaDeEntrega { get; set; }

    public int UsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int? UsuarioModificacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public bool Activo { get; set; }

    public string? CodigoCabecera { get; set; }

    public virtual EmpresaDeEntrega CodigoEmpresaDeEntregaNavigation { get; set; } = null!;

    public virtual Municipio CodigoMunicipioNavigation { get; set; } = null!;
}

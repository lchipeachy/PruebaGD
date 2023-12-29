using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MotivoRetorno
{
    public int CodigoMotivoRetorno { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<IntentoDeEntrega> IntentoDeEntregas { get; set; } = new List<IntentoDeEntrega>();

    public virtual ICollection<MotivoRetornoEmpresaDeEntrega> MotivoRetornoEmpresaDeEntregas { get; set; } = new List<MotivoRetornoEmpresaDeEntrega>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class FormaDeEnvio
{
    public int CodigoFormaDeEnvio { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Monto { get; set; }

    public bool AplicaDevolucion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<EmpresaDeEntrega> CodigoEmpresaDeEntregas { get; set; } = new List<EmpresaDeEntrega>();
}

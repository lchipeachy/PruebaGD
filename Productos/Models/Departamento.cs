using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Departamento
{
    public short CodigoDepartamento { get; set; }

    public string Nombre { get; set; } = null!;

    public short? CodigoProvincia { get; set; }

    public virtual ICollection<FacturaCreditoFiscal> FacturaCreditoFiscals { get; set; } = new List<FacturaCreditoFiscal>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Membresium> Membresia { get; set; } = new List<Membresium>();

    public virtual ICollection<Municipio> Municipios { get; set; } = new List<Municipio>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Municipio
{
    public short CodigoMunicipio { get; set; }

    public string Nombre { get; set; } = null!;

    public short CodigoDepartamento { get; set; }

    public short? CodigoCanton { get; set; }

    public virtual Departamento CodigoDepartamentoNavigation { get; set; } = null!;

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual ICollection<FacturaCreditoFiscal> FacturaCreditoFiscals { get; set; } = new List<FacturaCreditoFiscal>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Membresium> Membresia { get; set; } = new List<Membresium>();

    public virtual ICollection<MunicipioEmpresaDeEntrega> MunicipioEmpresaDeEntregas { get; set; } = new List<MunicipioEmpresaDeEntrega>();

    public virtual ICollection<ZonaRoja> ZonaRojas { get; set; } = new List<ZonaRoja>();
}

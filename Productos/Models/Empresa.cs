using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Empresa
{
    public int CodigoEmpresa { get; set; }

    public string? Nombre { get; set; }

    public string? Token { get; set; }

    public string? FechaVigencia { get; set; }

    public string? Nit { get; set; }

    public string? NombreComercial { get; set; }

    public string? NombreEmisor { get; set; }

    public string? Direccion { get; set; }

    public int? CodigoPostal { get; set; }

    public short? CodigoMunicipio { get; set; }

    public string? Pais { get; set; }

    public string? CorreoEmisor { get; set; }

    public string? AfiliacionIva { get; set; }

    public short? CodigoEstablecimiento { get; set; }

    public virtual Municipio? CodigoMunicipioNavigation { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}

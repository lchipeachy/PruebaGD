using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Membresium
{
    public int CodigoMembresia { get; set; }

    public int CodigoCliente { get; set; }

    public short CodigoDepartamento { get; set; }

    public short CodigoMunicipio { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public string? DireccionDeEntrega { get; set; }

    public string? NumeroTarjeta { get; set; }

    public string? NombreTarjeta { get; set; }

    public int? CodigoTipoDeTarjeta { get; set; }

    public string? FechaVencimineto { get; set; }

    public string? CodigoSeguridad { get; set; }

    public string? AliasMembresia { get; set; }

    public virtual ICollection<BitacoraMembresium> BitacoraMembresia { get; set; } = new List<BitacoraMembresium>();

    public virtual Cliente CodigoClienteNavigation { get; set; } = null!;

    public virtual Departamento CodigoDepartamentoNavigation { get; set; } = null!;

    public virtual Municipio CodigoMunicipioNavigation { get; set; } = null!;

    public virtual TipoDeTarjetum? CodigoTipoDeTarjetaNavigation { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}

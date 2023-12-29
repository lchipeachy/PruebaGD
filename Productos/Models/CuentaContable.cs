using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CuentaContable
{
    public int CodigoCuentaContable { get; set; }

    public string NumeroDeCuenta { get; set; } = null!;

    public int? CodigoCuentaContablePadre { get; set; }

    public string Nombre { get; set; } = null!;

    public int CodigoClaseDeGasto { get; set; }

    public int CodigoClaseCuentaContable { get; set; }

    public int CodigoLibroContable { get; set; }

    public bool? EsRama { get; set; }

    public virtual ClaseCuentaContable CodigoClaseCuentaContableNavigation { get; set; } = null!;

    public virtual ClaseDeGasto CodigoClaseDeGastoNavigation { get; set; } = null!;

    public virtual CuentaContable? CodigoCuentaContablePadreNavigation { get; set; }

    public virtual LibroContable CodigoLibroContableNavigation { get; set; } = null!;

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();

    public virtual ICollection<CuentaContableSaldo> CuentaContableSaldos { get; set; } = new List<CuentaContableSaldo>();

    public virtual ICollection<EmpresaDeEntrega> EmpresaDeEntregas { get; set; } = new List<EmpresaDeEntrega>();

    public virtual ICollection<CuentaContable> InverseCodigoCuentaContablePadreNavigation { get; set; } = new List<CuentaContable>();

    public virtual ICollection<RedCrediticium> RedCrediticia { get; set; } = new List<RedCrediticium>();

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();

    public virtual ICollection<TipoDeGasto> TipoDeGastos { get; set; } = new List<TipoDeGasto>();

    public virtual ICollection<TipoIngreso> TipoIngresos { get; set; } = new List<TipoIngreso>();
}

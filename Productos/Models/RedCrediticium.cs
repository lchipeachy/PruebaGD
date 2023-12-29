using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class RedCrediticium
{
    public int CodigoRedCrediticia { get; set; }

    public string Nombre { get; set; } = null!;

    public int? CodigoCuenta { get; set; }

    public int? CodigoCuentaPorCobrar { get; set; }

    public bool? PermitirCobroDeUnaCuota { get; set; }

    public bool? PermitirCobroDeVariasCuotas { get; set; }

    public virtual ICollection<Cobro> Cobros { get; set; } = new List<Cobro>();

    public virtual CuentaContable? CodigoCuentaNavigation { get; set; }

    public virtual Cuentum? CodigoCuentaPorCobrarNavigation { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

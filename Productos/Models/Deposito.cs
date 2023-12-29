using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Deposito
{
    public int CodigoDeposito { get; set; }

    public DateTime? Fecha { get; set; }

    public int? CodigoBanco { get; set; }

    public decimal? Monto { get; set; }

    public int? CuentaOrigen { get; set; }

    public int? CuentaDestino { get; set; }

    public virtual Banco? CodigoBancoNavigation { get; set; }

    public virtual Cuentum? CuentaDestinoNavigation { get; set; }

    public virtual Cuentum? CuentaOrigenNavigation { get; set; }
}

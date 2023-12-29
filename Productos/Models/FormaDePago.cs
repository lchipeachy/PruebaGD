using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class FormaDePago
{
    public int CodigoFormaDePago { get; set; }

    public string? Nombre { get; set; }

    public int? CodigoTipoGuia { get; set; }

    public virtual ICollection<Cobro> Cobros { get; set; } = new List<Cobro>();

    public virtual TipoGuium? CodigoTipoGuiaNavigation { get; set; }

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual ICollection<TipoTransaccion> TipoTransaccions { get; set; } = new List<TipoTransaccion>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

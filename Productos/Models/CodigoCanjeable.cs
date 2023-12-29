using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CodigoCanjeable
{
    public int CodigoCodigoCanjeable { get; set; }

    public string CodigoGenerado { get; set; } = null!;

    public int CodigoProducto { get; set; }

    public bool GeneradoEnSistema { get; set; }

    public int? CodigoGasto { get; set; }

    public int? CodigoFacturaEmision { get; set; }

    public int? CodigoGarantia { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public bool Activo { get; set; }

    public bool Canjeado { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? CodigoUsuarioInactivo { get; set; }

    public DateTime? FechaUsuarioInactivo { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaUsuarioModificacion { get; set; }

    public int CodigoVenta { get; set; }

    public int? CodigoCobroOrigen { get; set; }

    public virtual ICollection<Cobro> Cobros { get; set; } = new List<Cobro>();

    public virtual Cobro? CodigoCobroOrigenNavigation { get; set; }

    public virtual Factura? CodigoFacturaEmisionNavigation { get; set; }

    public virtual Garantium? CodigoGarantiaNavigation { get; set; }

    public virtual Gasto? CodigoGastoNavigation { get; set; }

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioInactivoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual Ventum CodigoVentaNavigation { get; set; } = null!;
}

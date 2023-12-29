using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Servicio
{
    public int CodigoServicio { get; set; }

    public string Nombre { get; set; } = null!;

    public bool AfectaMovimiento { get; set; }

    public decimal? Porcentaje { get; set; }

    public int? CodigoCuentaContable { get; set; }

    public short DiasVigenciaServicio { get; set; }

    public bool ProductoDigital { get; set; }

    public bool AplicaGarantia { get; set; }

    public virtual ICollection<BitacoraServicioCaby> BitacoraServicioCabies { get; set; } = new List<BitacoraServicioCaby>();

    public virtual CuentaContable? CodigoCuentaContableNavigation { get; set; }

    public virtual ICollection<DetalleVentaServicio> DetalleVentaServicios { get; set; } = new List<DetalleVentaServicio>();

    public virtual ICollection<ProductoServicio> ProductoServicios { get; set; } = new List<ProductoServicio>();
}

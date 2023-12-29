using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PolizaContable
{
    public int CodigoPolizaContable { get; set; }

    public DateOnly Fecha { get; set; }

    public int CodigoEscenarioContable { get; set; }

    public DateOnly FechaCreacion { get; set; }

    public int? CodigoCierreContable { get; set; }

    public bool EsPolizaManual { get; set; }

    public virtual CierreContable? CodigoCierreContableNavigation { get; set; }

    public virtual EscenarioContable CodigoEscenarioContableNavigation { get; set; } = null!;

    public virtual ICollection<Factura> FacturaCodigoPolizaMercaderiaNavigations { get; set; } = new List<Factura>();

    public virtual ICollection<Factura> FacturaCodigoPolizaServicioNavigations { get; set; } = new List<Factura>();

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();

    public virtual ICollection<Movimiento> MovimientoCodigoPolizaEntradaArancelNavigations { get; set; } = new List<Movimiento>();

    public virtual ICollection<Movimiento> MovimientoCodigoPolizaEntradaMercaderiaNavigations { get; set; } = new List<Movimiento>();

    public virtual ICollection<Movimiento> MovimientoCodigoPolizaSalidaArancelNavigations { get; set; } = new List<Movimiento>();

    public virtual ICollection<Movimiento> MovimientoCodigoPolizaSalidaMercaderiaNavigations { get; set; } = new List<Movimiento>();

    public virtual ICollection<NotaContable> NotaContables { get; set; } = new List<NotaContable>();

    public virtual ICollection<Paquete> PaqueteCodigoPolizaContableArancelNavigations { get; set; } = new List<Paquete>();

    public virtual ICollection<Paquete> PaqueteCodigoPolizaContableIvaNavigations { get; set; } = new List<Paquete>();

    public virtual ICollection<Paquete> PaqueteCodigoPolizaContablePagoImpuestoNavigations { get; set; } = new List<Paquete>();

    public virtual ICollection<Pedido> PedidoCodigoPolizaContableImpuestoCobradoNavigations { get; set; } = new List<Pedido>();

    public virtual ICollection<Pedido> PedidoCodigoPolizaContableMercaderiaEnTransitoNavigations { get; set; } = new List<Pedido>();

    public virtual ICollection<Pedido> PedidoCodigoPolizaInventarioMercaderiaNavigations { get; set; } = new List<Pedido>();

    public virtual ICollection<PolizaContableBitacora> PolizaContableBitacoras { get; set; } = new List<PolizaContableBitacora>();

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();

    public virtual ICollection<Ventum> VentumCodigoPolizaArancelNavigations { get; set; } = new List<Ventum>();

    public virtual ICollection<Ventum> VentumCodigoPolizaInventarioNavigations { get; set; } = new List<Ventum>();
}

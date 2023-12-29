using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Establecimiento
{
    public int CodigoEstablecimiento { get; set; }

    public string? Nombre { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? Horario { get; set; }

    public decimal? PorcentajeComision { get; set; }

    public decimal? CostoFijo { get; set; }

    public decimal? Saldo { get; set; }

    public string? Telefono { get; set; }

    public string? TelefonoAlterno { get; set; }

    public int? CodigoCliente { get; set; }

    public bool? ComisionSobreVenta { get; set; }

    public string? Contacto1 { get; set; }

    public string? Correo1 { get; set; }

    public string? Contacto2 { get; set; }

    public string? Correo2 { get; set; }

    public bool ModificaPedido { get; set; }

    public bool? Aprobado { get; set; }

    public bool? Eliminado { get; set; }

    public string? NombreImportacion { get; set; }

    public string? Logo { get; set; }

    public bool? AutorizaCupones { get; set; }

    public bool? AutorizaVentas { get; set; }

    public string? CodigoCasillero { get; set; }

    public string? Nit { get; set; }

    public decimal? PorcentajeComisionPedido { get; set; }

    public int? CuentaPorPagar { get; set; }

    public bool? ModificaAsin { get; set; }

    public int? CodigoCuentaInventario { get; set; }

    public int? CodigoCuentaCxP { get; set; }

    public int? CodigoCuentaCompra { get; set; }

    public bool? CargaArchivo { get; set; }

    public string? Url { get; set; }

    public string? ConsignatarioId { get; set; }

    public string? ClienteId { get; set; }

    public bool? HabilitaPromocion { get; set; }

    public bool? PromocionSinExistencia { get; set; }

    public string? ObservacionesEstablecimiento { get; set; }

    public bool AceptaPoliticas { get; set; }

    public int MaximoProductosBajoDemanda { get; set; }

    public int DiasMinimoEntregaBajoPedido { get; set; }

    public byte PorcentajeLogistico { get; set; }

    public virtual ICollection<ArchivoEstablecimiento> ArchivoEstablecimientos { get; set; } = new List<ArchivoEstablecimiento>();

    public virtual Cliente? CodigoClienteNavigation { get; set; }

    public virtual Cuentum? CodigoCuentaCompraNavigation { get; set; }

    public virtual Cuentum? CodigoCuentaCxPNavigation { get; set; }

    public virtual Cuentum? CodigoCuentaInventarioNavigation { get; set; }

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();

    public virtual ICollection<CuentaDeCompra> CuentaDeCompras { get; set; } = new List<CuentaDeCompra>();

    public virtual Cuentum? CuentaPorPagarNavigation { get; set; }

    public virtual ICollection<GestionCorreoExencion> GestionCorreoExencions { get; set; } = new List<GestionCorreoExencion>();

    public virtual ICollection<Paquete> Paquetes { get; set; } = new List<Paquete>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}

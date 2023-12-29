using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Paquete
{
    public int CodigoPaquete { get; set; }

    public string CodigoDeRastreo { get; set; } = null!;

    public string? GuiaAerea { get; set; }

    public string? EnviadoPor { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Peso { get; set; }

    public decimal? PesoVolumetrico { get; set; }

    public decimal? MontoImpuesto { get; set; }

    public DateTime? Fecha { get; set; }

    public bool? Generado { get; set; }

    public short? CodigoEstadoPaquete { get; set; }

    public string? Gca { get; set; }

    public int? CodigoEstablecimiento { get; set; }

    public int? CodigoArancel { get; set; }

    public DateTime? FechaRecibida { get; set; }

    public DateTime? FechaEnvioFactura { get; set; }

    public DateTime? FechaCodigoDeRastreoNoEncontrado { get; set; }

    public decimal? Valor { get; set; }

    public bool? FacturaNoRecibida { get; set; }

    public decimal? MontoFlete { get; set; }

    public decimal? MontoIva { get; set; }

    public decimal? MontoArancel { get; set; }

    public int? CodigoImportador { get; set; }

    public int? CodigoEstadoPaqueteAnterior { get; set; }

    public DateTime? FechaMontoFlete { get; set; }

    public int? CodigoGasto { get; set; }

    public decimal? ValorLocal { get; set; }

    public decimal? ValorFleteAduana { get; set; }

    public decimal? CifguatemalaDigital { get; set; }

    public decimal? Cifaduana { get; set; }

    public string? Dua { get; set; }

    public int? CodigoPolizaContableIva { get; set; }

    public int? CodigoPolizaContableArancel { get; set; }

    public int? CodigoPolizaContablePagoImpuesto { get; set; }

    public int? CodigoUsuario { get; set; }

    public DateTime? FechaInicioProceso { get; set; }

    public int? CodigoInternoCourrier { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaUsuarioModificacion { get; set; }

    public int? CodigoPolizaDeImportacion { get; set; }

    public virtual ICollection<ArchivoPaquete> ArchivoPaquetes { get; set; } = new List<ArchivoPaquete>();

    public virtual Establecimiento? CodigoEstablecimientoNavigation { get; set; }

    public virtual EstadoPaquete? CodigoEstadoPaqueteNavigation { get; set; }

    public virtual Importador? CodigoImportadorNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContableArancelNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContableIvaNavigation { get; set; }

    public virtual PolizaContable? CodigoPolizaContablePagoImpuestoNavigation { get; set; }

    public virtual PolizaDeImportacion? CodigoPolizaDeImportacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual ICollection<PaqueteReclamado> PaqueteReclamados { get; set; } = new List<PaqueteReclamado>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<PolizaContableBitacora> PolizaContableBitacoras { get; set; } = new List<PolizaContableBitacora>();
}

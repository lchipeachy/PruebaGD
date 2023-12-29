using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Importador
{
    public int CodigoImportador { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion1Envio { get; set; }

    public string? Dominio { get; set; }

    public string? CorreoFacturas { get; set; }

    public string? TituloCorreoNotificacionBodegaMiami { get; set; }

    public string? TituloCorreoFactura { get; set; }

    public string? TituloCorreoNotificacionBodegaGuatemala { get; set; }

    public bool? WebService { get; set; }

    public string? Linea1Awb { get; set; }

    public string? Linea2Awb { get; set; }

    public string? Linea3Awb { get; set; }

    public string? PatronGuia { get; set; }

    public decimal? ValorLibra { get; set; }

    public string? CorreosApi { get; set; }

    public int? CodigoCuentaContable { get; set; }

    public bool? AsociaGuia { get; set; }

    public string? CorreoPaquetesSinImpuestos { get; set; }

    public bool? AplicaVerificacionTracking { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? UsuarioModificacion { get; set; }

    public virtual ICollection<DireccionImportador> DireccionImportadors { get; set; } = new List<DireccionImportador>();

    public virtual ICollection<Paquete> Paquetes { get; set; } = new List<Paquete>();

    public virtual Usuario? UsuarioModificacionNavigation { get; set; }
}

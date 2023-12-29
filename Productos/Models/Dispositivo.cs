using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Dispositivo
{
    public int CodigoDispositivo { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string? Observaciones { get; set; }

    public int? CodigoUsuarioAsignado { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public int? CodigoTipoDispositivo { get; set; }

    public int? CodigoUsuarioBaja { get; set; }

    public DateTime? FechaBaja { get; set; }

    public bool? Estado { get; set; }

    public long? Upc { get; set; }

    public virtual TipoDispositivo? CodigoTipoDispositivoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioAsignadoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioBajaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }
}

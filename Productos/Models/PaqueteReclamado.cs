using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class PaqueteReclamado
{
    public int CodigoPaqueteReclamado { get; set; }

    public int? CodigoPaquete { get; set; }

    public DateTime? FechaReclamo { get; set; }

    public string? DescripcionReclamo { get; set; }

    public int? CodigoEstadoPaqueteReclamado { get; set; }

    public int? CodigoTipoReclamoPaquete { get; set; }

    public string? Resolucion { get; set; }

    public decimal? Monto { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public int? CodigoUsuarioCambioEstado { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public DateTime? FechaCambioEstado { get; set; }

    public int? CodigoMotivoReclamo { get; set; }

    public int? CodigoUsuarioReclamo { get; set; }

    public virtual EstadoPaqueteReclamado? CodigoEstadoPaqueteReclamadoNavigation { get; set; }

    public virtual MotivoReclamo? CodigoMotivoReclamoNavigation { get; set; }

    public virtual Paquete? CodigoPaqueteNavigation { get; set; }

    public virtual TipoReclamoPaquete? CodigoTipoReclamoPaqueteNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioCambioEstadoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioReclamoNavigation { get; set; }

    public virtual ICollection<ImagenPaqueteReclamadum> ImagenPaqueteReclamada { get; set; } = new List<ImagenPaqueteReclamadum>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Anuncio
{
    public int CodigoAnuncio { get; set; }

    public int? CodigoTipoDeAnuncio { get; set; }

    public string? Nombre { get; set; }

    public string? Linea1 { get; set; }

    public string? Linea2 { get; set; }

    public string? EnlaceVisible { get; set; }

    public string? Enlace { get; set; }

    public string? Imagen { get; set; }

    public int? CodigoEstadoDeAnuncio { get; set; }

    public float? Cpc { get; set; }

    public bool? Aprobado { get; set; }

    public int? CodigoPagina { get; set; }

    public string? CorreoCliente { get; set; }

    public string? Encabezado { get; set; }

    public int? CodigoCliente { get; set; }

    public string? Paginas { get; set; }

    public DateTime? FechaCambioEstado { get; set; }

    public int? CodigoUsuarioModificacion { get; set; }

    public DateTime? FechaModificacionAnuncio { get; set; }

    public virtual Cliente? CodigoClienteNavigation { get; set; }

    public virtual EstadoDeAnuncio? CodigoEstadoDeAnuncioNavigation { get; set; }

    public virtual TipoDeAnuncio? CodigoTipoDeAnuncioNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificacionNavigation { get; set; }

    public virtual ICollection<Pagina> PaginasNavigation { get; set; } = new List<Pagina>();
}

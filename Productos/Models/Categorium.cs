using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Categorium
{
    public int CodigoCategoria { get; set; }

    public string? Nombre { get; set; }

    public string? Foto { get; set; }

    public string? PartidaArancelaria { get; set; }

    public string? DescripcionArancelaria { get; set; }

    public int? Arancel { get; set; }

    public string? BrowseNodeId { get; set; }

    public string? AmazonHtml { get; set; }

    public string? AmazonHtmlcategoria { get; set; }

    public string? SearchIndex { get; set; }

    public bool? Traducir { get; set; }

    public DateOnly? FechaCorreo { get; set; }

    public string? NombreEnIngles { get; set; }

    public string? DescripcionNodo { get; set; }

    public short? CodigoIndiceDeBusqueda { get; set; }

    public long? CampaniaId { get; set; }

    public string? CampaniaStatus { get; set; }

    public long? GrupoId { get; set; }

    public string? GrupoStatus { get; set; }

    public long? AnuncioId { get; set; }

    public DateTime? FechaAnuncio { get; set; }

    public string? HtmlGuatemalaDigital { get; set; }

    public int? CodigoEstadoAnuncio { get; set; }

    public bool? NoBuscarEnKeepa { get; set; }

    public bool? NoPublicar { get; set; }

    public string? GuatemalaDigitalJson { get; set; }

    public string? AmazonJsoncategoria { get; set; }

    public string? AmazonJson { get; set; }

    public int? CodigoUsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual IndiceDeBusquedum? CodigoIndiceDeBusquedaNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificaNavigation { get; set; }

    public virtual ICollection<Prioridad> Prioridads { get; set; } = new List<Prioridad>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<Atributo> CodigoAtributos { get; set; } = new List<Atributo>();
}

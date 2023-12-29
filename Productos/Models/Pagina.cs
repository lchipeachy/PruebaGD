using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Pagina
{
    public int CodigoPagina { get; set; }

    public string? Nombre { get; set; }

    public bool? EsPrincipal { get; set; }

    public string? HtmlAnuncios { get; set; }

    public string? Url { get; set; }

    public decimal? PrimerLugar { get; set; }

    public decimal? CostoMinimo { get; set; }

    public decimal? Ponderacion { get; set; }

    public byte? NumeroAnunciosPagina { get; set; }

    public short? CodigoArchivoMenu { get; set; }

    public string? Descripcion { get; set; }

    public string? Jsonanuncios { get; set; }

    public virtual ArchivoMenu? CodigoArchivoMenuNavigation { get; set; }

    public virtual ICollection<ContenidoDinamico> ContenidoDinamicos { get; set; } = new List<ContenidoDinamico>();

    public virtual ICollection<Prioridad> Prioridads { get; set; } = new List<Prioridad>();

    public virtual ICollection<Anuncio> Anuncios { get; set; } = new List<Anuncio>();
}

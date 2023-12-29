using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ContenidoDinamico
{
    public int CodigoContenidoDinamico { get; set; }

    public int? CodigoTipoContenidoDinamico { get; set; }

    public string? Texto { get; set; }

    public int? CodigoPagina { get; set; }

    public int? Valor { get; set; }

    public virtual Pagina? CodigoPaginaNavigation { get; set; }

    public virtual TipoContenidoDinamico? CodigoTipoContenidoDinamicoNavigation { get; set; }
}

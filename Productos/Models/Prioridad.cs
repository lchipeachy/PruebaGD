using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Prioridad
{
    public int CodigoCategoria { get; set; }

    public int CodigoPagina { get; set; }

    public int? Nivel { get; set; }

    public string? Aleatorio { get; set; }

    public int? CodigoUsuarioCreacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual Categorium CodigoCategoriaNavigation { get; set; } = null!;

    public virtual Pagina CodigoPaginaNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioCreacionNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class DefinicionEscanerDetalle
{
    public int CodigoDefinicionEscaner { get; set; }

    public string? NombreColumna { get; set; }

    public string? Inicio { get; set; }

    public string? Fin { get; set; }

    public string? Valor { get; set; }

    public int? Posicion { get; set; }

    public string? Salida { get; set; }

    public bool Opcional { get; set; }

    public virtual DefinicionEscaner CodigoDefinicionEscanerNavigation { get; set; } = null!;
}

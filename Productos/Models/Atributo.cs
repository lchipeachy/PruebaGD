using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Atributo
{
    public int CodigoAtributo { get; set; }

    public string Nombre { get; set; } = null!;

    public bool? Sugerencias { get; set; }

    public virtual ICollection<ValorAtributo> ValorAtributos { get; set; } = new List<ValorAtributo>();

    public virtual ICollection<Categorium> CodigoCategoria { get; set; } = new List<Categorium>();
}

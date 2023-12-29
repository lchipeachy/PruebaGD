using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Carpetum
{
    public int CodigoCarpeta { get; set; }

    public string Nombre { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int CodigoCarpetaPadre { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<Archivo> Archivos { get; set; } = new List<Archivo>();

    public virtual Carpetum CodigoCarpetaPadreNavigation { get; set; } = null!;

    public virtual ICollection<Carpetum> InverseCodigoCarpetaPadreNavigation { get; set; } = new List<Carpetum>();
}

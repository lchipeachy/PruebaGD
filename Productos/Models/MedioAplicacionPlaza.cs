using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class MedioAplicacionPlaza
{
    public int CodigoMedioAplicacionPlaza { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<AplicacionPlaza> AplicacionPlazas { get; set; } = new List<AplicacionPlaza>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Archivo
{
    public long CodigoArchivo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int CodigoCarpeta { get; set; }

    public bool Activo { get; set; }

    public int? CodigoUsuarioArchivo { get; set; }

    public DateTime? FechaArchivo { get; set; }

    public virtual ICollection<AdministracionDocumento> AdministracionDocumentos { get; set; } = new List<AdministracionDocumento>();

    public virtual Carpetum CodigoCarpetaNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioArchivoNavigation { get; set; }
}

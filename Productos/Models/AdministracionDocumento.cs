using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class AdministracionDocumento
{
    public int CodigoAdministracionDocumento { get; set; }

    public int CodigoUsuarioDocumento { get; set; }

    public long? CodigoArchivo { get; set; }

    public int CodigoTipoDocumento { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int? CodigoUsuarioEliminacion { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public virtual Archivo? CodigoArchivoNavigation { get; set; }

    public virtual TipoDocumento CodigoTipoDocumentoNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioDocumentoNavigation { get; set; } = null!;

    public virtual Usuario? CodigoUsuarioEliminacionNavigation { get; set; }
}

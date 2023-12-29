using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class AdministracionDocumentoTarjetum
{
    public int CodigoSolicitudDocumentoTarjeta { get; set; }

    public long CodigoArchivo { get; set; }

    public virtual Archivo CodigoArchivoNavigation { get; set; } = null!;

    public virtual SolicitudDocumentoTarjetum CodigoSolicitudDocumentoTarjetaNavigation { get; set; } = null!;
}

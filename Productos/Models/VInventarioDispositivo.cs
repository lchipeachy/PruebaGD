using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class VInventarioDispositivo
{
    public int CodigoDispositivo { get; set; }

    public string? Dispositivo { get; set; }

    public string? Departamento { get; set; }

    public string? Usuario { get; set; }

    public long? Upc { get; set; }

    public int? CodigoDepartamentoEmpresa { get; set; }

    public int? CodigoUsuarioAsignado { get; set; }

    public int CodigoTipoDispositivo { get; set; }

    public bool? TipoImpresion { get; set; }
}

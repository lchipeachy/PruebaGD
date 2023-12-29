using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Candidato
{
    public int CodigoCandidato { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public bool Genero { get; set; }

    public string Telefono { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string? Profesion { get; set; }

    public string? TituloAcademico { get; set; }

    public string Cv { get; set; } = null!;

    public string? Cui { get; set; }

    public int? CodigoTipoDocumento { get; set; }

    public virtual ICollection<AplicacionPlaza> AplicacionPlazas { get; set; } = new List<AplicacionPlaza>();

    public virtual TipoDocumento? CodigoTipoDocumentoNavigation { get; set; }
}

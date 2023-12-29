using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Marca
{
    public int CodigoMarca { get; set; }

    public string? Nombre { get; set; }

    public string? Campania { get; set; }

    public long? CampaniaId { get; set; }

    public string? CampaniaStatus { get; set; }

    public long? GrupoId { get; set; }

    public string? GrupoStatus { get; set; }

    public long? AnuncioId { get; set; }

    public DateTime? FechaAnuncio { get; set; }

    public int? CodigoEstadoAnuncio { get; set; }
}

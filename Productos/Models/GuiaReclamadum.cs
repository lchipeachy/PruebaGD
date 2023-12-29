using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class GuiaReclamadum
{
    public int CodigoGuiaReclamada { get; set; }

    public string? CodigoDeRastreo { get; set; }

    public short? CodigoEmpresaDeEntrega { get; set; }

    public DateTime? FechaReclamo { get; set; }

    public string? DescripcionReclamo { get; set; }

    public int? CodigoEstadoGuiaReclamada { get; set; }

    public string? Resolucion { get; set; }

    public decimal? Monto { get; set; }

    public virtual EmpresaDeEntrega? CodigoEmpresaDeEntregaNavigation { get; set; }

    public virtual EstadoGuiaReclamadum? CodigoEstadoGuiaReclamadaNavigation { get; set; }

    public virtual ICollection<ImagenGuiaReclamadum> ImagenGuiaReclamada { get; set; } = new List<ImagenGuiaReclamadum>();
}

using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class TipoDocumento
{
    public int CodigoTipoDocumento { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<AdministracionDocumento> AdministracionDocumentos { get; set; } = new List<AdministracionDocumento>();

    public virtual ICollection<Candidato> Candidatos { get; set; } = new List<Candidato>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}

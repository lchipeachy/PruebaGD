using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class UsuarioAplicacionExterna
{
    public int CodigoUsuarioAplicacionExterna { get; set; }

    public byte[] Usuario { get; set; } = null!;

    public byte[]? Codigo { get; set; }

    public byte[]? Password { get; set; }

    public int CodigoAplicacionExterna { get; set; }

    public bool Activo { get; set; }

    public int? CodigoUsuarioInactivo { get; set; }

    public DateTime? FechaUsuarioInactivo { get; set; }

    public int CodigoUsuarioCreacion { get; set; }

    public DateTime FechaUsuarioCreacion { get; set; }

    public virtual AplicacionExterna CodigoAplicacionExternaNavigation { get; set; } = null!;

    public virtual Usuario CodigoUsuarioCreacionNavigation { get; set; } = null!;

    public virtual ICollection<GestionCorreoExencion> GestionCorreoExencions { get; set; } = new List<GestionCorreoExencion>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<UsuarioAplicacionExternaUsuario> UsuarioAplicacionExternaUsuarios { get; set; } = new List<UsuarioAplicacionExternaUsuario>();
}

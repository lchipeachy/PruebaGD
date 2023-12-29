using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Banco
{
    public int CodigoBanco { get; set; }

    public string? Nombre { get; set; }

    public string? Pagina { get; set; }

    public virtual ICollection<Cobro> Cobros { get; set; } = new List<Cobro>();

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();

    public virtual ICollection<Deposito> Depositos { get; set; } = new List<Deposito>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

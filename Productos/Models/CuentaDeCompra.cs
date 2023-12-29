using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class CuentaDeCompra
{
    public string Correo { get; set; } = null!;

    public bool? SiempreEnviarExencion { get; set; }

    public bool? NuncaEnviarExencion { get; set; }

    public int? CodigoEstablecimiento { get; set; }

    public bool? EnviarCopiaExencion { get; set; }

    public bool? Activa { get; set; }

    public int? Arancel { get; set; }

    public bool? Inventario { get; set; }

    public string? ContraseñaCorreo { get; set; }

    public string? ContraseñaProveedor { get; set; }

    public string? Perfil { get; set; }

    public virtual Establecimiento? CodigoEstablecimientoNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

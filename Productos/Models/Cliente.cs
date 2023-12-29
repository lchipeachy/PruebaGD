using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Cliente
{
    public string Correo { get; set; } = null!;

    public bool? Factura { get; set; }

    public string? Observaciones { get; set; }

    public string? Telefono { get; set; }

    public string? TelefonoAlt { get; set; }

    public string? Nombre { get; set; }

    public byte[]? Clave { get; set; }

    public string? NombreFactura { get; set; }

    public string? DireccionFactura { get; set; }

    public string? Nit { get; set; }

    public string? NumeroTarjeta { get; set; }

    public int? VencimientoTarjeta { get; set; }

    public string? NombreTarjeta { get; set; }

    public bool? AnunciosSuspendidos { get; set; }

    public string? TipoTarjeta { get; set; }

    public int CodigoCliente { get; set; }

    public bool? AplicaEfectivo { get; set; }

    public decimal? MontoVale { get; set; }

    public DateTime? FechaModificacionBloqueoEfectivo { get; set; }

    public int? CodigoUsuarioModificaBloqueoEfectivo { get; set; }

    public virtual ICollection<Anuncio> Anuncios { get; set; } = new List<Anuncio>();

    public virtual Usuario? CodigoUsuarioModificaBloqueoEfectivoNavigation { get; set; }

    public virtual ICollection<Establecimiento> Establecimientos { get; set; } = new List<Establecimiento>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Membresium> Membresia { get; set; } = new List<Membresium>();

    public virtual ICollection<SolicitudContrasena> SolicitudContrasenas { get; set; } = new List<SolicitudContrasena>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}

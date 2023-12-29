using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class Producto
{
    public int CodigoProducto { get; set; }

    public int? CodigoCategoria { get; set; }

    public string? Nombre { get; set; }

    public string? Pagina { get; set; }

    public string? Foto { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public string CodigoAmazon { get; set; } = null!;

    public string? Revision { get; set; }

    public string? Observaciones { get; set; }

    public decimal? PrecioAnterior { get; set; }

    public DateTime? ProximoIngreso { get; set; }

    public string? Caracteristicas { get; set; }

    public string? Descripcion { get; set; }

    public string? Foto11 { get; set; }

    public string? Foto12 { get; set; }

    public string? Foto13 { get; set; }

    public string? Foto21 { get; set; }

    public string? Foto22 { get; set; }

    public string? Foto23 { get; set; }

    public string? Foto31 { get; set; }

    public string? Foto32 { get; set; }

    public string? Foto33 { get; set; }

    public string? Video { get; set; }

    public int? CodigoContenidoAdicional { get; set; }

    public bool Combinado { get; set; }

    public int Reserva { get; set; }

    public string? Upc { get; set; }

    public decimal? PrecioNormal { get; set; }

    public int? CodigoUsuario { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? CodigoEstablecimiento { get; set; }

    public decimal? PorcentajeComision { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public decimal? PrecioSugerido { get; set; }

    public string? NombreEnIngles { get; set; }

    public int? Inventario { get; set; }

    public decimal? PrecioCompra { get; set; }

    public DateTime? FechaPrecio { get; set; }

    public string? Foto41 { get; set; }

    public string? Foto42 { get; set; }

    public string? Foto43 { get; set; }

    public bool? ComisionDeTarjeta { get; set; }

    public decimal? Peso { get; set; }

    public bool? Tallas { get; set; }

    public string? CodigoReferencia { get; set; }

    public short? CorreoPrecio { get; set; }

    public string? Nodos { get; set; }

    public bool? Mostrar { get; set; }

    public bool? PrecioVigenteAmazon { get; set; }

    public string? Size { get; set; }

    public string? ColorVariaciones { get; set; }

    public string? CodigoAmazonVariaciones { get; set; }

    public int? CodigoUbicacionBodega { get; set; }

    public decimal? PrecioProveedor { get; set; }

    public int? CodigoEstadoProducto { get; set; }

    public string NombreBusqueda { get; set; } = null!;

    public bool? Busqueda { get; set; }

    public DateTime? FechaBusqueda { get; set; }

    public int? CodigoUbicacionBodegaAnterior { get; set; }

    public string? NombreRobot { get; set; }

    public bool? Disponibilidad { get; set; }

    public bool? NoConsultarApi { get; set; }

    public bool? DisponibleApi { get; set; }

    public bool? NoComprarInventario { get; set; }

    public bool? CaracteristicasTraducida { get; set; }

    public bool? DescripcionTraducida { get; set; }

    public int? DiasEntrega { get; set; }

    public string? CaracteristicasEnIngles { get; set; }

    public string? DescripcionEnIngles { get; set; }

    public DateTime? FechaDisponibleApi { get; set; }

    public decimal? PorcentajeComisionPedido { get; set; }

    public int? CodigoUbicacionDespacho { get; set; }

    public DateTime? FechaUbicacionBodega { get; set; }

    public int? CodigoUsuarioUbicacionBodega { get; set; }

    public int? CodigoUsuarioModificaPrecio { get; set; }

    public DateTime? FechaUsuarioModificaPrecio { get; set; }

    public bool ModificaCategoriaManual { get; set; }

    public int? CodigoUsuarioModificaCategoriaManual { get; set; }

    public DateTime? FechaModificaCategoriaManual { get; set; }

    public virtual ICollection<AnuncioExterno> AnuncioExternos { get; set; } = new List<AnuncioExterno>();

    public virtual ICollection<CodigoCanjeable> CodigoCanjeables { get; set; } = new List<CodigoCanjeable>();

    public virtual Categorium? CodigoCategoriaNavigation { get; set; }

    public virtual ContenidoAdicional? CodigoContenidoAdicionalNavigation { get; set; }

    public virtual UbicacionBodega? CodigoUbicacionBodegaAnteriorNavigation { get; set; }

    public virtual UbicacionBodega? CodigoUbicacionBodegaNavigation { get; set; }

    public virtual UbicacionDespacho? CodigoUbicacionDespachoNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificaCategoriaManualNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioModificaPrecioNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioNavigation { get; set; }

    public virtual Usuario? CodigoUsuarioUbicacionBodegaNavigation { get; set; }

    public virtual ICollection<ModificacionDeInventario> ModificacionDeInventarios { get; set; } = new List<ModificacionDeInventario>();

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();

    public virtual ICollection<Notificacion> Notificacions { get; set; } = new List<Notificacion>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<Preguntum> Pregunta { get; set; } = new List<Preguntum>();

    public virtual ProductoCaby? ProductoCaby { get; set; }

    public virtual ICollection<ProductoCombinado> ProductoCombinados { get; set; } = new List<ProductoCombinado>();

    public virtual ICollection<ProductoServicio> ProductoServicios { get; set; } = new List<ProductoServicio>();

    public virtual ICollection<RevisionProducto> RevisionProductos { get; set; } = new List<RevisionProducto>();

    public virtual ICollection<TipoDeAnuncio> TipoDeAnuncios { get; set; } = new List<TipoDeAnuncio>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();

    public virtual ICollection<VerificacionEmbarque> VerificacionEmbarques { get; set; } = new List<VerificacionEmbarque>();

    public virtual ICollection<VerificacionInventario> VerificacionInventarios { get; set; } = new List<VerificacionInventario>();

    public virtual ICollection<Producto> CodigoProductoRelacionados { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> CodigoProductos { get; set; } = new List<Producto>();

    public virtual ICollection<ValorAtributo> CodigoValorAtributos { get; set; } = new List<ValorAtributo>();
}

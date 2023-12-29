using System;
using System.Collections.Generic;

namespace Productos.Models;

public partial class ProductoHistorico
{
    public int CodigoProducto { get; set; }

    public int? CodigoCategoria { get; set; }

    public string? Nombre { get; set; }

    public string? Pagina { get; set; }

    public string? Foto { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public string? CodigoAmazon { get; set; }

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

    public bool? NoInventariar { get; set; }

    public bool Combinado { get; set; }

    public int Reserva { get; set; }

    public string? Upc { get; set; }

    public decimal? PrecioNormal { get; set; }

    public int? CodigoUsuario { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? EsCupon { get; set; }

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

    public long? GrupoId { get; set; }

    public string? GrupoStatus { get; set; }

    public long? AnuncioId { get; set; }

    public DateTime? FechaAnuncio { get; set; }

    public int? CodigoEstadoAnuncio { get; set; }

    public string? NombreRobot { get; set; }

    public bool? Disponibilidad { get; set; }

    public bool? NoConsultarApi { get; set; }

    public bool? RegistroMarca { get; set; }

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
}

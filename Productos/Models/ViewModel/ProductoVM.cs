using Microsoft.AspNetCore.Mvc.Rendering;

namespace Productos.Models.ViewModel
{
    public class ProductoVM
    {
        public List<Producto> listaProductos { get; set; }

        public List<CategoriaList> categorias { get; set; }
    }

    public class CategoriaList
    {
        public int CodigoCategoria { get; set; }
        public string NombreCategoria { get; set; }
    }
}

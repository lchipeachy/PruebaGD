using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Productos.Models;
using Productos.Models.ViewModel;
using System.Diagnostics;

namespace Productos.Controllers
{
    public class HomeController : Controller
    {
        private readonly GuatemalaDigitalContext _DBContext;

        public HomeController(GuatemalaDigitalContext context)
        {
            _DBContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProductosCategoria()

        {
            ProductoVM categorias = new ProductoVM();
            categorias.categorias = _DBContext.Categoria.Select(c => new CategoriaList{CodigoCategoria = c.CodigoCategoria, NombreCategoria = c.Nombre }).ToList();
            categorias.listaProductos = new List<Producto>();
            return View(categorias);
        }

        [HttpPost]
        public IActionResult ProductosCategoria(int CodigoCategoria)
           
        {
            //var productos = _DBContext.Productos.Where(p => _DBContext.Venta.Any(v => v.CodigoProducto == p.CodigoProducto && v.Fecha.Year == 2019) && p.CodigoCategoria == CodigoCategoria).ToList();
            ProductoVM productos = new ProductoVM();
            productos.categorias = _DBContext.Categoria.Select(c => new CategoriaList { CodigoCategoria = c.CodigoCategoria, NombreCategoria = c.Nombre }).ToList();
            productos.listaProductos = _DBContext.Productos.Where(p => p.CodigoCategoria == CodigoCategoria).ToList();
            return View(productos);
        }
    }
}

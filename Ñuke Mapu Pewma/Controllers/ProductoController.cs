using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ñuke_Mapu_Pewma.Models;
using Ñuke_Mapu_Pewma.Services;
using System.Collections.Generic;

namespace Ñuke_Mapu_Pewma.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoRepositorio _productoRepositorio;

        public ProductoController(IProductoRepositorio productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }

        // GET: ProductoController
        public ActionResult Index()
        {
            var productos = _productoRepositorio.GetAllProductos();
            return View(productos);
        }

        // GET: ProductoController/Details/5
        public ActionResult Details(int id)
        {
            var producto = _productoRepositorio.GetById(id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producto producto)
        {
            try
            {
                _productoRepositorio.Add(producto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            var producto = _productoRepositorio.GetById(id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Producto producto)
        {
            try
            {
                _productoRepositorio.Update(producto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            var producto = _productoRepositorio.GetById(id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: ProductoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var producto = _productoRepositorio.GetById(id);
                _productoRepositorio.Delete(producto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController/GetAllLibros
        public ActionResult GetAllLibros()
        {
            var libros = _productoRepositorio.GetAllLibros();
            return View(libros);
        }

        // GET: ProductoController/GetLibroNombre/nombre
        public ActionResult GetLibroNombre(string nombre)
        {
            var libro = _productoRepositorio.GetLibroNombre(nombre);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // GET: ProductoController/GetLibroAutor/autor
        public ActionResult GetLibroAutor(string autor)
        {
            var libro = _productoRepositorio.GetLibroAutor(autor);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // GET: ProductoController/GetLibroGenero/genero
        public ActionResult GetLibroGenero(string genero)
        {
            var libro = _productoRepositorio.GetLibroGenero(genero);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // GET: ProductoController/GetAllPrenda
        public ActionResult GetAllPrenda()
        {
            var prendas = _productoRepositorio.GetAllPrendas();
            return View(prendas);
        }

        // GET: ProductoController/GetPrendaTipo/tipo
        public ActionResult GetPrendaTipo(string tipo)
        {
            var prenda = _productoRepositorio.GetPrendaTipo(tipo);
            if (prenda == null)
            {
                return NotFound();
            }

            return View(prenda);
        }

        // GET: ProductoController/GetPrendaNombre/nombre
        public ActionResult GetPrendaNombre(string nombre)
        {
            var prenda = _productoRepositorio.GetPrendaNombre(nombre);
            if (prenda == null)
            {
                return NotFound();
            }

            return View(prenda);
        }

        // GET: ProductoController/GetAllArtesania
        public ActionResult GetAllArtesania()
        {
            var artesanias = _productoRepositorio.GetAllArtesanias();
            return View(artesanias);
        }

        // GET: ProductoController/GetAllProductos
        public ActionResult GetAllProductos()
        {
            var productos = _productoRepositorio.GetAllProductos();
            return View(productos);
        }
    }
}

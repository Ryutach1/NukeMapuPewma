using Ñuke_Mapu_Pewma.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ñuke_Mapu_Pewma.Services
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private readonly List<Producto> productos = new List<Producto>();
        private readonly List<Libro> libros = new List<Libro>();
        private readonly List<Prenda> prendas = new List<Prenda>();
        private readonly List<Artesania> artesanias = new List<Artesania>();

        public ProductoRepositorio()
        {
            libros = new List<Libro>
            {
                new Libro { Id = 1, Nombre = "Sentir", Descripcion = "Descripción del libro 1", Precio = 9.99f, Stock = 10, Autor = "Autor del libro 1", Editorial = "Editorial del libro 1", AñodePublicacion = 2021, Genero = "Documental" },
                new Libro { Id = 2, Nombre = "Leer", Descripcion = "Descripción del libro 1", Precio = 9.99f, Stock = 10, Autor = "Autor del libro 1", Editorial = "Editorial del libro 1", AñodePublicacion = 2021, Genero = "Ciencia Ficcion" },
                new Libro { Id = 3, Nombre = "Cantar", Descripcion = "Descripción del libro 1", Precio = 9.99f, Stock = 10, Autor = "Autor del libro 1", Editorial = "Editorial del libro 1", AñodePublicacion = 2021, Genero = "Cristiano" },
                new Libro { Id = 4, Nombre = "Rezar", Descripcion = "Descripción del libro 1", Precio = 9.99f, Stock = 10, Autor = "Autor del libro 1", Editorial = "Editorial del libro 1", AñodePublicacion = 2021, Genero = "Satanico" },
                new Libro { Id = 5, Nombre = "Amar", Descripcion = "Descripción del libro 1", Precio = 9.99f, Stock = 10, Autor = "Autor del libro 1", Editorial = "Editorial del libro 1", AñodePublicacion = 2021, Genero = "Romance" }
            };

            prendas = new List<Prenda>
            {
                new Prenda { Id = 33, Nombre = "Prenda 1", Descripcion = "Descripción de la prenda 1", Precio = 29.99f, Stock = 8, Tipo = "Polera", Color = "Color de la prenda 1", Talla = 42 },
                new Prenda { Id = 34, Nombre = "Prenda 2", Descripcion = "Descripción de la prenda 1", Precio = 29.99f, Stock = 8, Tipo = "Pantalon", Color = "Color de la prenda 1", Talla = 42 }
            };

            artesanias = new List<Artesania>
            {
                new Artesania { Id = 19, Nombre = "Artesanía 1", Descripcion = "Descripción de la artesanía 2", Precio = 49.99f, Stock = 5, Material = "Material de la artesanía 2" },
                new Artesania { Id = 20, Nombre = "Artesanía 2", Descripcion = "Descripción de la artesanía 2", Precio = 49.99f, Stock = 5, Material = "Material de la artesanía 2" }
            };
        }

        public IEnumerable<Libro> GetAllLibros()
        {
            return libros;
        }

        public Libro GetLibroNombre(string nombre)
        {
            return libros.Find(l => l.Nombre == nombre);
        }

        public Libro GetLibroAutor(string autor)
        {
            return libros.Find(l => l.Autor == autor);
        }

        public Libro GetLibroGenero(string genero)
        {
            return libros.Find(l => l.Genero == genero);
        }

        public IEnumerable<Prenda> GetAllPrendas()
        {
            return prendas;
        }

        public Prenda GetPrendaTipo(string tipo)
        {
            return prendas.Find(p => p.Tipo == tipo);
        }

        public Prenda GetPrendaNombre(string nombre)
        {
            return prendas.Find(p => p.Nombre == nombre);
        }

        public IEnumerable<Artesania> GetAllArtesanias()
        {
            return artesanias;
        }

        public IEnumerable<Producto> GetAllProductos()
        {
            return productos;
        }

        public Producto GetById(int id)
        {
            return productos.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Producto producto)
        {
            productos.Add(producto);
        }

        public void Update(Producto producto)
        {
            Producto productoExistente = productos.FirstOrDefault(p => p.Id == producto.Id);

            if (productoExistente != null)
            {
                productoExistente.Nombre = producto.Nombre;
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;
            }
        }

        public void Delete(Producto producto)
        {
            productos.Remove(producto);
        }
    }
}

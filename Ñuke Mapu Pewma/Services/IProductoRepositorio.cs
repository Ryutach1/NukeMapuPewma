using Ñuke_Mapu_Pewma.Models;
using System.Collections.Generic;

namespace Ñuke_Mapu_Pewma.Services
{
    public interface IProductoRepositorio
    {
        // Métodos genéricos para productos
        Producto GetById(int id);
        IEnumerable<Producto> GetAllProductos();
        void Add(Producto producto);
        void Update(Producto producto);
        void Delete(Producto producto);

        // Métodos específicos para libros
        IEnumerable<Libro> GetAllLibros();
        Libro GetLibroNombre(string nombre);
        Libro GetLibroAutor(string autor);
        Libro GetLibroGenero(string genero);

        // Métodos específicos para prendas
        IEnumerable<Prenda> GetAllPrendas();
        Prenda GetPrendaTipo(string tipo);
        Prenda GetPrendaNombre(string nombre);

        // Métodos específicos para artesanías
        IEnumerable<Artesania> GetAllArtesanias();
    }
}

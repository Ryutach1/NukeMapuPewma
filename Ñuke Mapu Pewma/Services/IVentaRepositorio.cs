using Ñuke_Mapu_Pewma.Models;
using System.Collections.Generic;

namespace Ñuke_Mapu_Pewma.Services
{
    public interface IVentaRepositorio
    {
        Venta GetById(int id);
        IEnumerable<Venta> GetAll();
        void Add(Venta venta);
        void Update(Venta venta);
        void Delete(Venta venta);
    }
}

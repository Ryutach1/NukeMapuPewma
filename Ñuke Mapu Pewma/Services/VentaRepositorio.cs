using Ñuke_Mapu_Pewma.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ñuke_Mapu_Pewma.Services
{
    public class VentaRepositorio : IVentaRepositorio
    {
        private readonly List<Venta> _ventas = new List<Venta>();

        public Venta GetById(int id)
        {
            return _ventas.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Venta> GetAll()
        {
            return _ventas;
        }

        public void Add(Venta venta)
        {
            _ventas.Add(venta);
        }

        public void Update(Venta venta)
        {
            Venta ventaExistente = _ventas.FirstOrDefault(v => v.Id == venta.Id);

            if (ventaExistente != null)
            {
                // Actualizar las propiedades de la venta existente con los nuevos valores
                ventaExistente.Fecha = venta.Fecha;
                ventaExistente.Monto = venta.Monto;
                ventaExistente.Productos = venta.Productos;
            }
        }

        public void Delete(Venta venta)
        {
            _ventas.Remove(venta);
        }
    }
}

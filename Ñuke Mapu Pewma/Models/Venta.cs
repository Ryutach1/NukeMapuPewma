using System.Collections.Generic;
using System;

namespace Ñuke_Mapu_Pewma.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<Producto> Productos { get; set; }
        public float Monto { get; set; }
    }
}

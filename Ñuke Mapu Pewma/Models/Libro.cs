namespace Ñuke_Mapu_Pewma.Models
{
    public class Libro : Producto
    {
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AñodePublicacion { get; set; }
        public string Genero { get; set; }
    }
}

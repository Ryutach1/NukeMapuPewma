namespace Ñuke_Mapu_Pewma.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Registrado { get; set; }
        public bool Logueado { get; set; }
    }
}

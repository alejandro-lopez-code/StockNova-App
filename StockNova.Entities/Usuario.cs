namespace StockNova.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
    }
}
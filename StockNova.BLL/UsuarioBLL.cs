using StockNova.DAL;
using StockNova.Entities;

namespace StockNova.BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL _usuarioDAL = new UsuarioDAL();

        public Usuario IniciarSesion(string usuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new ArgumentException("Por favor, ingrese el nombre de usuario.");
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                throw new ArgumentException("Por favor, ingrese la contraseña.");
            }

            Usuario? usuarioEncontrado = _usuarioDAL.ValidarUsuario(usuario, contrasena);

            if (usuarioEncontrado == null)
            {
                throw new InvalidOperationException("Usuario o contraseña incorrectos.");
            }

            return usuarioEncontrado;
        }
    }
}
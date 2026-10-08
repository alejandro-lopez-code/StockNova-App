using Microsoft.Data.SqlClient;
using StockNova.Entities;

namespace StockNova.DAL
{
    public class UsuarioDAL
    {
        public Usuario? ValidarUsuario(string nombreUsuario, string contrasena)
        {
            Usuario? usuarioEncontrado = null;

            using (var con = new SqlConnection(Conexion.Cadena))
            {
                string query = "SELECT IdUsuario, Usuario, Clave, Rol FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Clave";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Clave", contrasena);

                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        usuarioEncontrado = new Usuario
                        {
                            IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            NombreUsuario = dr["Usuario"].ToString()!,
                            Contrasena = dr["Clave"].ToString()!,
                            Rol = dr["Rol"].ToString()!
                        };
                    }
                }
            }

            return usuarioEncontrado;
        }
    }
}
using StockNova.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StockNova.DAL
{
    public class ProductoDAL
    {
        // Método para listar todos los productos desde SQL Server
        public DataTable ListarProductos()
        {
            DataTable tablaProductos = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.Cadena))
            {
                // Usamos alias (AS) para emparejar los nombres exactos de SQL con la interfaz
                string query = @"SELECT 
                            Codigo, 
                            Nombre, 
                            UnidadMedida AS Unidad, 
                            Categoria, 
                            StockMinimo, 
                            StockActual,
                            CASE 
                                WHEN StockActual = 0 THEN 'Sin Stock'
                                WHEN StockActual <= StockMinimo THEN 'Stock Bajo'
                                ELSE 'Normal'
                            END AS Estado
                         FROM Productos";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        try
                        {
                            conexion.Open();
                            adaptador.Fill(tablaProductos);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al obtener los productos de la base de datos: " + ex.Message);
                        }
                    }
                }
            }

            return tablaProductos;
        }

        // 2. EL NUEVO MÉTODO QUE AGREGAMOS (Para registrar nuevos productos) 💾
        public bool InsertarProducto(Producto prod)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.Cadena))
            {
                string query = @"INSERT INTO Productos (Codigo, Nombre, UnidadMedida, Categoria, StockMinimo, StockActual) 
                                VALUES (@Codigo, @Nombre, @UnidadMedida, @Categoria, @StockMinimo, 0)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Codigo", prod.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", prod.Nombre);
                    cmd.Parameters.AddWithValue("@UnidadMedida", prod.UnidadMedida ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Categoria", prod.Categoria ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@StockMinimo", prod.StockMinimo);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al guardar el producto: " + ex.Message);
                    }
                }
            }
        }
    }
}
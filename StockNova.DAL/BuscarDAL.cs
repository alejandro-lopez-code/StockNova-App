using System;
using System.Data;
using System.Data.SqlClient;

namespace StockNova.DAL
{
    public class BuscarDAL
    {
        private readonly string _connectionString = Conexion.Cadena;

        // Método para buscar productos por Código o Nombre en tiempo real
        public DataTable BuscarProductos(string criterio)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                // Calculamos el Estado con un CASE según el StockActual para evitar errores de columnas faltantes
                string query = @"SELECT 
                            IdProducto, 
                            Codigo, 
                            Nombre, 
                            Categoria, 
                            Precio, 
                            StockActual,
                            CASE 
                                WHEN StockActual = 0 THEN 'Sin Stock' 
                                WHEN StockActual <= 5 THEN 'Stock Bajo' 
                                ELSE 'Normal' 
                            END AS Estado
                         FROM Productos 
                         WHERE Codigo LIKE @Criterio OR Nombre LIKE @Criterio OR Categoria LIKE @Criterio
                         ORDER BY Nombre ASC";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
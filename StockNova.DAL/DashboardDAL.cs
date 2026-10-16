using System;
using System.Data;
using System.Data.SqlClient;

namespace StockNova.DAL
{
    public class DashboardDAL
    {
        private readonly string _connectionString = Conexion.Cadena;

        // 1. Obtiene los contadores para las tarjetas superiores (Total, Movimientos, Sin Stock, Stock Bajo)
        public (int totalProductos, int totalMovimientos, int sinStock, int stockBajo) ObtenerMetricasDashboard()
        {
            int totalProductos = 0;
            int totalMovimientos = 0;
            int sinStock = 0;
            int stockBajo = 0;

            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                conexion.Open();

                // Total de Productos
                string qProd = "SELECT COUNT(*) FROM Productos";
                using (SqlCommand cmd = new SqlCommand(qProd, conexion))
                {
                    totalProductos = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
                }

                // Total de Movimientos
                string qMov = "SELECT COUNT(*) FROM Movimientos";
                using (SqlCommand cmd = new SqlCommand(qMov, conexion))
                {
                    totalMovimientos = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
                }

                // Productos Sin Stock (StockActual = 0)
                string qSinStock = "SELECT COUNT(*) FROM Productos WHERE StockActual = 0";
                using (SqlCommand cmd = new SqlCommand(qSinStock, conexion))
                {
                    sinStock = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
                }

                // Productos con Stock Bajo (ej. mayor a 0 y menor o igual a 5)
                string qBajo = "SELECT COUNT(*) FROM Productos WHERE StockActual > 0 AND StockActual <= 5";
                using (SqlCommand cmd = new SqlCommand(qBajo, conexion))
                {
                    stockBajo = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
                }
            }

            return (totalProductos, totalMovimientos, sinStock, stockBajo);
        }

        // 2. Obtiene la lista detallada para las alertas en el DataGridView
        public DataTable ObtenerProductosConAlertaStock()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                // Consulta que trae los productos que requieren atención (Sin Stock o Stock Bajo)
                string query = @"SELECT 
                                    Codigo, 
                                    Nombre, 
                                    StockActual, 
                                    10 AS StockMin, 
                                    CASE 
                                        WHEN StockActual = 0 THEN 'Sin Stock' 
                                        ELSE 'Stock Bajo' 
                                    END AS Estado
                                 FROM Productos 
                                 WHERE StockActual <= 5 
                                 ORDER BY StockActual ASC";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
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
using System;
using System.Data;
using System.Data.SqlClient;

namespace StockNova.DAL
{
    public class ReportesDAL
    {
        private readonly string _connectionString = Conexion.Cadena;

        public DataTable ObtenerHistorialMovimientos(DateTime fechaDesde, DateTime fechaHasta, string tipoMovimiento)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                DateTime fechaHastaFin = fechaHasta.Date.AddDays(1).AddTicks(-1);

                string query = @"SELECT 
                                    m.IdMovimiento AS [ID],
                                    p.Codigo AS [Código],
                                    p.Nombre AS [Producto],
                                    m.TipoMovimiento AS [Tipo],
                                    m.Cantidad AS [Cantidad],
                                    m.FechaMovimiento AS [Fecha],
                                    m.Observacion AS [Observaciones]
                                 FROM Movimientos m
                                 INNER JOIN Productos p ON m.IdProducto = p.IdProducto
                                 WHERE m.FechaMovimiento >= @FechaDesde 
                                   AND m.FechaMovimiento <= @FechaHasta";

                if (tipoMovimiento != "Todos los movimientos" && !string.IsNullOrEmpty(tipoMovimiento))
                {
                    query += " AND m.TipoMovimiento = @TipoMovimiento";
                }

                query += " ORDER BY m.FechaMovimiento DESC";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde.Date);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHastaFin);

                    if (tipoMovimiento != "Todos los movimientos" && !string.IsNullOrEmpty(tipoMovimiento))
                    {
                        cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);
                    }

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
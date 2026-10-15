using System;
using System.Data.SqlClient;

namespace StockNova.DAL
{
    public class MovimientoDAL
    {
        public bool RegistrarMovimiento(int idProducto, string tipoMovimiento, int cantidad, DateTime fechaMovimiento, int idUsuario, string observacion)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.Cadena))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // 1. Insertar el historial del movimiento
                    string queryMovimiento = @"INSERT INTO Movimientos (IdProducto, TipoMovimiento, Cantidad, FechaMovimiento, IdUsuario, Observacion) 
                                             VALUES (@IdProducto, @TipoMovimiento, @Cantidad, @FechaMovimiento, @IdUsuario, @Observacion)";

                    using (SqlCommand cmd = new SqlCommand(queryMovimiento, conexion, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@FechaMovimiento", fechaMovimiento);
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@Observacion", (object)observacion ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Actualizar el stock actual en Productos (Suma si es Entrada, Resta si es Salida)
                    string operador = tipoMovimiento.Contains("Entrada") ? "+" : "-";
                    string queryStock = $@"UPDATE Productos 
                                           SET StockActual = StockActual {operador} @Cantidad 
                                           WHERE IdProducto = @IdProducto";

                    using (SqlCommand cmdStock = new SqlCommand(queryStock, conexion, transaccion))
                    {
                        cmdStock.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmdStock.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmdStock.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaccion.Rollback();
                    throw;
                }
            }
        }
    }
}
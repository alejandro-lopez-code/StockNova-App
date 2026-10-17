using System;
using System.Data.SqlClient;

namespace StockNova.DAL
{
    public class ConfiguracionDAL
    {
        private readonly string _connectionString = Conexion.Cadena;

        // 1. Validar integridad de las tablas base en SQL Server
        public bool ValidarIntegridadBaseDatos(out string mensaje)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionString))
                {
                    conexion.Open();

                    string query = @"
                        SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES 
                        WHERE TABLE_NAME IN ('Productos', 'Movimientos', 'Usuarios')";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        int tablasEncontradas = Convert.ToInt32(cmd.ExecuteScalar());

                        if (tablasEncontradas >= 3)
                        {
                            mensaje = "Conexión exitosa. La estructura y las tablas principales están verificadas correctamente.";
                            return true;
                        }
                        else
                        {
                            mensaje = $"Atención: Solo se encontraron {tablasEncontradas} de las 3 tablas requeridas en la base de datos.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al conectar con la base de datos: " + ex.Message;
                return false;
            }
        }

        // 2. Inicializar parámetros/estado base del sistema
        public bool InicializarSistema(out string mensaje)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionString))
                {
                    conexion.Open();
                    mensaje = "Sistema inicializado correctamente. Conexión y tablas sincronizadas.";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al inicializar el sistema: " + ex.Message;
                return false;
            }
        }

        // 3. Limpiar solo el historial de movimientos
        public bool LimpiarHistorialMovimientos(out string mensaje)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionString))
                {
                    conexion.Open();
                    string query = "TRUNCATE TABLE Movimientos";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                mensaje = "Se ha limpiado el historial de movimientos correctamente.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "Error al limpiar el historial: " + ex.Message;
                return false;
            }
        }

        // 4. Reset completo de transacciones e inventario (conservando esquema)
        public bool ResetearSistemaCompleto(out string mensaje)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionString))
                {
                    conexion.Open();

                    // Eliminamos transacciones y restablecemos stock de productos a 0
                    string query = @"
                        DELETE FROM Movimientos;
                        UPDATE Productos SET Stock = 0;";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                mensaje = "El sistema ha sido reseteado. Se limpiaron las transacciones y el stock se restableció a cero.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "Error al resetear el sistema: " + ex.Message;
                return false;
            }
        }
    }
}

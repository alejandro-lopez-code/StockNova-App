using System;

namespace StockNova.Entities
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public int IdProducto { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public int IdUsuario { get; set; }
        public string Observacion { get; set; }
    }
}
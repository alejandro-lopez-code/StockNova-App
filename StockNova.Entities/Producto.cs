namespace StockNova.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string UnidadMedida { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int StockMinimo { get; set; }
        public int StockActual { get; set; }

        // Propiedad calculada para determinar el estado visual
        public string Estado
        {
            get
            {
                if (StockActual == 0) return "Sin Stock";
                if (StockActual <= StockMinimo) return "Stock Bajo";
                return "Normal";
            }
        }
    }
}
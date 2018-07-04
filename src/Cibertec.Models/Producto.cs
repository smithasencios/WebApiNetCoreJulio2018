namespace Cibertec.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int StockMinimo { get; set; }
        public string Archivo { get; set; }
        public int StockActual { get; set; }
    }
}

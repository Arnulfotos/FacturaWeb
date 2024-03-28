namespace FacturaWeb.Models.FacturaViewModel
{
    public class FacturaIndexData
    {

        public IEnumerable<Factura>? Facturas { get; set; }
        public IEnumerable<FacturaDetalle>? FacturaDetalles { get; set; }
        public IEnumerable<Producto>? Productos { get; set; }

    }
}

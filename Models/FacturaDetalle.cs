using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FacturaWeb.Models
{
    public class FacturaDetalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FacturaDetalleID { get; set; }


        public int FacturaID { get; set; }
        public int ProductoID { get; set; }
        public Factura? Factura { get; set; }

        public Producto? Producto { get; set; }

       public double? Precio { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FacturaWeb.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }

        public string? Descripcion {  get; set; }

        public ICollection<FacturaDetalle>? FacturaDetalles { get; set; }
    }
}
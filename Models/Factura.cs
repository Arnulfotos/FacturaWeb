using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FacturaWeb.Models
{
    public class Factura
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FacturaID { get; set; }


        [DisplayName("Fecha de alta")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaAlta { get; set; }


        [DisplayName("Total")]
        [DataType(DataType.Currency)]
        public int TotalPago { get; set; }


       


        //

        public ICollection<FacturaDetalle>? FacturaDetalles { get; set; }
        

    }
}

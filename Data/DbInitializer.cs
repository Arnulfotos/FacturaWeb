using FacturaWeb.Models;
using System.Diagnostics;

namespace FacturaWeb.Data
{
    public class DbInitializer
    {
        public static void Initialize(WebAppContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Productos.Any())
            {
                return;   // DB has been seeded
            }

            var productos = new Producto[]
            {
            new Producto{Descripcion = "Pera"},
             new Producto{Descripcion = "Manzana"},
             new Producto{Descripcion = "Zarzamora"},
             new Producto{Descripcion = "Coliflor"},
             new Producto{Descripcion = "Cilantro"},
             new Producto{Descripcion = "Tomate"},
             new Producto{Descripcion = "Cebolla"},

            };
            foreach (Producto p in productos)
            {
                context.Productos.Add(p);
            }
            context.SaveChanges();

            
        }
    }
}

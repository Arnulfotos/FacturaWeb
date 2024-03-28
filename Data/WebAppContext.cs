using FacturaWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FacturaWeb.Data
{
    public class WebAppContext : DbContext
    {

        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {
        }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalles { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factura>().ToTable("Factura");
            modelBuilder.Entity<FacturaDetalle>().ToTable("FacturaDetalle");
            modelBuilder.Entity<Producto>().ToTable("Producto");
        }



    }
}

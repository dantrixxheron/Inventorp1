using Microsoft.EntityFrameworkCore;

namespace AdministrarTiendaElect.Data
{
    public class ATEDbContext:DbContext
    {
        public ATEDbContext(DbContextOptions<ATEDbContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
        //tablas en plural y el objeto en singular
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<VentaControl> VentaControles { get; set; }
        public DbSet<VentaDetalle> VentaDetalles { get; set; }
    }   
}

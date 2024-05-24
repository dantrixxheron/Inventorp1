using Microsoft.EntityFrameworkCore;

namespace AdministrarTiendaElect.Data
{
    public class RepoProducto: IProducto
    {
        private ATEDbContext _context;
        public RepoProducto(ATEDbContext context)
        {
            _context = context;
        }
        public async Task<List<Producto>> GetAll()
        {
            return await _context.Productos.Include(p=>p.Proveedores).Include(c=>c.Categoria).ToListAsync();
        }
        public async Task<Producto> Get(int id)
        {
            return await _context.Productos.Include(pr=>pr.Proveedores).Where(r => r.ID_Producto == id).FirstOrDefaultAsync();
        }
        public async Task<Producto> Add(Producto producto)
        {
            //throw new NotImplementedException();
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
            return producto;
        }
        public async Task<Producto> Update(Producto producto)
        {
            Producto productolocal = await _context.Productos.FindAsync(producto.ID_Producto);
            if (productolocal != null)
            {
                _context.Entry(productolocal).CurrentValues.SetValues(producto);
                productolocal.Proveedores = producto.Proveedores;
                await _context.SaveChangesAsync();
            }
            return productolocal;
        }
        public async Task Delete(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
           
        }
    }
}

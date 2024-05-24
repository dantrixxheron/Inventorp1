using Microsoft.EntityFrameworkCore;

namespace AdministrarTiendaElect.Data
{
    public class RepoProveedor: IProveedor
    {
        private ATEDbContext _context;
        public RepoProveedor(ATEDbContext context)
        {
            _context = context;
        }
        public async Task<List<Proveedor>> GetAll()
        {
            return await _context.Proveedores.Include(p=>p.Productos).ToListAsync();
        }
        public async Task<Proveedor> Get(int id)
        {
            //throw new NotImplementedException();
            return await _context.Proveedores.FindAsync(id);
        }
        public async Task<Proveedor> Add(Proveedor proveedor)
        {
            //throw new NotImplementedException();
            await _context.Proveedores.AddAsync(proveedor);
            await _context.SaveChangesAsync();
            return proveedor;
        }
        public async Task<Proveedor> Update(Proveedor proveedor)
        {
            Proveedor proveedorlocal = await _context.Proveedores.FindAsync(proveedor.ID_Proveedor);
            if (proveedorlocal != null)
            {
                _context.Entry(proveedorlocal).CurrentValues.SetValues(proveedor);
                proveedorlocal.Productos = proveedor.Productos;
                await _context.SaveChangesAsync();
            }
            return proveedorlocal;
        }
        public async Task Delete(int id)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);
            if (proveedor != null)
                _context.Proveedores.Remove(proveedor);
            await _context.SaveChangesAsync();
        }   
    }
}

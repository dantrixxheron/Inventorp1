using Microsoft.EntityFrameworkCore;

namespace AdministrarTiendaElect.Data
{
    public class RepoVentaDetalle : IVentaDetalle
    {
        private readonly ATEDbContext _context;

        public RepoVentaDetalle(ATEDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VentaDetalle>> GetAll()
        {
            return await _context.VentaDetalles
                                 .Include(vd => vd.Producto) // Incluyendo la entidad relacionada Producto
                                 .Include(vd => vd.VentaControl) // Incluyendo la entidad relacionada VentaControl
                                 .ToListAsync(); // Ejecutando la consulta y obteniendo la lista de resultados
        }

        public async Task<VentaDetalle> Get(int id)
        {
            return await _context.VentaDetalles
                               .Include(vd => vd.Producto)
                              .Include(vd => vd.VentaControl)
                          .FirstOrDefaultAsync(vd => vd.ID_Venta == id);
        }

        public async Task Add(VentaDetalle ventaDetalle)
        {
            _context.VentaDetalles.Add(ventaDetalle);
        }

        public async Task Update(VentaDetalle ventaDetalle)
        {
            _context.Entry(ventaDetalle).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var ventaDetalle = await _context.VentaDetalles.FindAsync(id);
            if (ventaDetalle != null)
            {
              _context.VentaDetalles.Remove(ventaDetalle);
            await _context.SaveChangesAsync();
            }
        }
    }

}
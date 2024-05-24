using AdministrarTiendaElect.Data;
using Microsoft.EntityFrameworkCore;

public class RepoVentaControl : IVentaControl
{
    private readonly ATEDbContext _context;

    public RepoVentaControl(ATEDbContext context)
    {
        _context = context;
    }

    public async Task<VentaControl> Get(int id)
    {
        return await _context.VentaControles.FindAsync(id);
    }

    public async Task Add(VentaControl ventaControl)
    {
        _context.VentaControles.Add(ventaControl);
    }

    public async Task<IEnumerable<VentaControl>> GetAll()
    {
        return await _context.VentaControles.ToListAsync();
    }
    public async Task Update(VentaControl ventaControl)
    {
        _context.Entry(ventaControl).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
    public async Task GetById(int id)
    {
        await _context.VentaControles.FindAsync(id);
    }
}

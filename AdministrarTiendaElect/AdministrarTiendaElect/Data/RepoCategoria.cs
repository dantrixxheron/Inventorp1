using Microsoft.EntityFrameworkCore;
namespace AdministrarTiendaElect.Data
{
    public class RepoCategoria:ICategoria
    {
        private ATEDbContext _context;
        public RepoCategoria(ATEDbContext context)
        {
            _context = context;
        }
        public async Task<List<Categoria>> GetAll()
        {
            return await _context.Categorias.ToListAsync();
        }
        public async Task<Categoria> Get(int id)
        {
            //throw new NotImplementedException();
            return await _context.Categorias.Include(p => p.Productos).FirstAsync(r=>r.ID_Categoria==id);
        }
        public async Task<Categoria> Add(Categoria categoria)
        {
            //throw new NotImplementedException();
            await _context.Categorias.AddAsync(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }
        public async Task<Categoria> Update(Categoria categoria)
        {
            Categoria categorialocal = await _context.Categorias.FindAsync(categoria.ID_Categoria);
            if (categorialocal != null)
            {
                _context.Entry(categorialocal).CurrentValues.SetValues(categoria);
                await _context.SaveChangesAsync();
            }
            return categorialocal;
        }
        public async Task Delete(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria != null)
                _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
        }       
    }
}

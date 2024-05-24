namespace AdministrarTiendaElect.Data
{
    public interface ICategoria
    {
        Task<List<Categoria>> GetAll();
        Task<Categoria> Get(int id);
        Task<Categoria> Add(Categoria categoria);
        Task<Categoria> Update(Categoria categoria);
        Task Delete(int id);
    }
}

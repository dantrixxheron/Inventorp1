namespace AdministrarTiendaElect.Data
{
    public interface IProducto
    {
        Task<List<Producto>> GetAll();
        Task<Producto> Get(int id);
        Task<Producto> Add(Producto id);
        Task<Producto> Update(Producto producto);
        Task Delete(int id);
    }
}

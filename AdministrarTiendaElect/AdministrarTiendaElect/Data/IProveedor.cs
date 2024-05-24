namespace AdministrarTiendaElect.Data
{
    public interface IProveedor
    {
        Task<List<Proveedor>> GetAll();
        Task<Proveedor> Get(int id);
        Task<Proveedor> Add(Proveedor proveedor);
        Task<Proveedor> Update(Proveedor proveedor);
        Task Delete(int id);
    }
}

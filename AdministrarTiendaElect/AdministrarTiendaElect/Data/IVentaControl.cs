using AdministrarTiendaElect.Data;

public interface IVentaControl
{
    Task<VentaControl> Get(int id);
    Task Add(VentaControl ventaControl);
    Task<IEnumerable<VentaControl>> GetAll();
    Task Update(VentaControl ventaControl);
    Task GetById(int id);
}

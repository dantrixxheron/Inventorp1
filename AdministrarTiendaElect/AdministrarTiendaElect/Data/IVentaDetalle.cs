namespace AdministrarTiendaElect.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IVentaDetalle
{
    Task<IEnumerable<VentaDetalle>> GetAll();
    Task<VentaDetalle> Get(int id);
    Task Add(VentaDetalle ventaDetalle);
    Task Update(VentaDetalle ventaDetalle);
    Task Delete(int id);
}
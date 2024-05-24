using AdministrarTiendaElect.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class VentaDetalle
{
    [Key]
    public int ID_Venta { get; set; }
    [Required(ErrorMessage = "La cantidad de productos vendidos es obligatoria")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "El subtotal de la venta es obligatorio")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Subtotal { get; set; }
    //propiedades de navegación de Entity Framework
    public int ProductoID_Producto { get; set; }
    virtual public Producto Producto { get; set; }
    public int VentaControlID_Ticket { get; set; }
    virtual public VentaControl VentaControl { get; set; }

}

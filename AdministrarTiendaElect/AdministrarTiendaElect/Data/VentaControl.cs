using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdministrarTiendaElect.Data
{
    public class VentaControl
    {
        [Key]
        [Required(ErrorMessage = "El ID es obligatorio")]
        public int ID_Ticket { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El total de la venta es obligatorio")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }
        //propiedades de navegación
        virtual public ICollection<VentaDetalle>? VentaDetalles { get; set; }
    }
}

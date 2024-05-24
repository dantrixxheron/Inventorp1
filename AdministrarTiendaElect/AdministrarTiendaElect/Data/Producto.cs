using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdministrarTiendaElect.Data
{
    public class Producto
    {
        [Key]
        [Required(ErrorMessage ="El identificador del producto es obligatorio")]
        public int ID_Producto { get; set; }
        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripción del producto es obligatoria")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El precio del producto es obligatorio")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "La cantidad en stock del producto es obligatoria")]
        public int Cant_Stock { get; set; }
        [Required(ErrorMessage = "La cantidad mínima del producto es obligatoria")]
        public int Cant_min{ get; set; }
        //propiedades de navegación de Entity Framework
        //[Required(ErrorMessage = "La categoría a la que pertenece el producto es obligatoria")]
        public int CategoriaID_Categoria { get; set; }
        virtual public Categoria? Categoria { get; set; }
        //colección de proveedores que proveen el producto
        virtual public ICollection<Proveedor> Proveedores { get; set; }
    }
}

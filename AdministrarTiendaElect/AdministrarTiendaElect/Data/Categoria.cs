using System.ComponentModel.DataAnnotations;
namespace AdministrarTiendaElect.Data
{
    public class Categoria
    {
        [Key]
        [Required(ErrorMessage = "El identificador de la categoría es obligatorio")]
        public int ID_Categoria { get; set; }
        [Required(ErrorMessage = "El nombre de la categoría es obligatorio")]
        [StringLength(100, ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }
        //propiedades de navegación de Entity Framework
        virtual public ICollection<Producto>? Productos { get; set; }
    }
}

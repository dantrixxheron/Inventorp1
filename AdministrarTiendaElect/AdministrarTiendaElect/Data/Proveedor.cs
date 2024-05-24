using System.ComponentModel.DataAnnotations;

namespace AdministrarTiendaElect.Data
{
    public class Proveedor
    {
        [Key]
        [Required]
        public int ID_Proveedor { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Ingresar alguna dirección es obligatoria")]
        public string Direccion { get; set; }
        [Required]
        [Length(13,13, ErrorMessage = "El teléfono debe tener formato +00 10 dígitos sin espacio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage ="Debe ingresar un correo")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        public string Correo { get; set; }
        //colección de productos que provee el proveedor
        virtual public ICollection<Producto> Productos { get; set; }
    }
}

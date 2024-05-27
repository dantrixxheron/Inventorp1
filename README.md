# Inventario
El propósito de la actividad era realizar una plataforma con Razor - Blazor y Entity donde se mostraran 3 tablas y en al menos 2 relaciones (una de muchos a muchos y otra de uno a muchos) ejecutar la lógica de back y frontend para la realización de páginas funcionales.
## Tablas
Debido al escaso tiempo, acortando el proyecto planeado, se quedaron 3 tablas: Categoría, Producto y Proveedor.
### Tabla Producto
* Descripción de la tabla: almacena la información reelevante de los productos a vender en la tienda de electrónicos.
* Datos a almacenar:
  - Identificador (KEY)
  - Nombre (String)
  - Descripción (String)
  - Precio unitario (decimal)
  - Cantidad en stock (int)
  - Cantidad mínima de stock (int)
* Llaves foráneas:
  - Identificador de categoría (int)
* Colecciones de datos (o arreglos de datos):
  - Proveedor(es) (ICollection*)
### Tabla Categoría
* Descripción de la tabla: almacena la categoría a la que pertenece el producto (celulares, computadoras, televisores, etc).
* Datos a almacenar:
  - Identificador (KEY)
  - Nombre (String)
* Colecciones de datos:
  - Producto(s) (ICollection*)
### Tabla Proveedor
* Descripción de la tabla: almacena la información de contacto con el proveedor así como el producto que suministra.
* Datos a almacenar:
  - Identificador (KEY)
  - Nombre (String)
  - Teléfono (int)
  - Dirección (String)
  - Correo (String)
* Colecciones de datos:
  - Producto(s) (ICollection*)
## Relaciones
1. **Productos <-> Proveedores** Relación de muchos a muchos (N:N). Un proveedor puede suministrar varios productos y un producto puede ser suministrado por uno o más proveedores.
2. **Productos <-> Categorías** Relación de muchos a uno. Un producto puede pertenecer a una sola categoría (muchos a uno), pero una categoría puede tener varios productos (uno a muchos).

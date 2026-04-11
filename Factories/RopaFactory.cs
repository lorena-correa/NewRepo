using System;
using System.Collections.Generic;
using System.Text;

namespace appSubastaTrabajo.Factories
{
    public class RopaFactory : ProductoFactory
    {
        public override Producto CrearProducto()
        {
            return new ProductoRopa
            {
                Nombre = "Producto de Ropa",
                PrecioInicial = 0,
                Descripcion = "Producto de temporada"
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace appSubastaTrabajo.Factories
{
    public class AlimentoFactory : ProductoFactory
    {
        public override Producto CrearProducto()
        {
            return new ProductoAlimento
            {
                Nombre = "Producto Alimenticio",
                PrecioInicial = 0,
                Descripcion = "Producto perecedero"
            };
        }
    }
}

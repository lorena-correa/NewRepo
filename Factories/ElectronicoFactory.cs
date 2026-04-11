using System;
using System.Collections.Generic;
using System.Text;

public class ElectronicoFactory : ProductoFactory
{
    public override Producto CrearProducto()
    {
        return new ProductoElectronico();
    }
}
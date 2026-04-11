using System;
using System.Collections.Generic;
using System.Text;

public class ProductoElectronico : Producto
{
    public override decimal CalcularPrecioFinal()
    {
        return PrecioInicial * 1.10m;
    }
}
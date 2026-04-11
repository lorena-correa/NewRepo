using System;
using System.Collections.Generic;
using System.Text;

public class ProductoRopa : Producto
{
    public override decimal CalcularPrecioFinal()
    {
        return PrecioInicial * 0.80m;
    }
}
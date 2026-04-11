using System;
using System.Collections.Generic;
using System.Text;

public class ProductoAlimento : Producto
{
    public override decimal CalcularPrecioFinal()
    {
        return PrecioInicial * 0.85m;
    }
}
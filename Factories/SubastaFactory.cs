using appSubastaTrabajo.Factories;
using System;

public class SubastaFactory
{
    public static Subasta Crear(SubastaDTO dto)
    {
 
        SubastaStrategy estrategia = dto.TipoSubasta switch
        {
            "Ascendente" => new SubastaAscendente(),
            "Descendente" => new SubastaDescendente(),
            "Cerrada" => new SubastaCerrada(),
            _ => throw new Exception("Tipo inválido")
        };


        ProductoFactory productoFactory = dto.NombreProducto switch
        {
            "Laptop" => new ElectronicoFactory(),
            "Manzanas" => new AlimentoFactory(),
            _ => new RopaFactory()
        };

        Producto producto = productoFactory.CrearProducto();
        producto.Nombre = dto.NombreProducto;
        producto.PrecioInicial = dto.PrecioActual;

        return new Subasta
        {
            NombreProducto = dto.NombreProducto,
            PrecioActual = dto.PrecioActual,
            Activa = dto.Activa,
            Estrategia = estrategia,
            Producto = producto 
        };
    }
}
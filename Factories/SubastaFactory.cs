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

        return new Subasta
        {
            NombreProducto = dto.NombreProducto,
            PrecioActual = dto.PrecioActual,
            Activa = dto.Activa,
            Estrategia = estrategia
        };
    }
}